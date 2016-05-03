using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using Elasticsearch.Net;
using Nest;
using Newtonsoft.Json;
using Tests.Framework;

namespace Tests.Document.Multiple.Bulk
{
	public class BulkResponsePerformance
	{
		private static Random Random = new Random(1337);
		private static IElasticClient Client = TestClient.GetInMemoryClient();

		[U]
		public void BulkResponseSerializationIsFastEnough()
		{
			var serializer = Client.Serializer;

			var tiny = 1;
			var tinyResponse = serializer.SerializeToBytes(this.ReturnBulkResponse(tiny));
			var tinySize = PrettySize(tinyResponse.LongLength);

			var medium = 100;
			var mediumResponse = serializer.SerializeToBytes(this.ReturnBulkResponse(medium));
			var mediumSize = PrettySize(mediumResponse.LongLength);

			var large = 1000;
			var largeResponse = serializer.SerializeToBytes(this.ReturnBulkResponse(large));
			var largeSize = PrettySize(largeResponse.LongLength);

			var huge = 100000;
			var hugeResponse = serializer.SerializeToBytes(this.ReturnBulkResponse(huge));
			var hugeSize = PrettySize(hugeResponse.LongLength);
			File.WriteAllText("C:\\temp\\huge.json", Encoding.UTF8.GetString(hugeResponse));

			var warmup = this.Deserialize(tinyResponse);

			var timings = new Dictionary<string, TimeSpan>();
			var sw = Stopwatch.StartNew();

			var mediumBulkResponse = this.Deserialize(mediumResponse);
			timings.Add($"medium: {medium} items ({mediumSize})", sw.Elapsed);
			sw.Restart();

			var largeBulkResponse = this.Deserialize(largeResponse);
			timings.Add($"large: {large} items ({largeSize})", sw.Elapsed);
			sw.Restart();

			var hugeBulkResponse = this.Deserialize(hugeResponse);
			timings.Add($"huge: {huge} items ({hugeSize})", sw.Elapsed);
			sw.Restart();
			hugeBulkResponse = this.Deserialize(hugeResponse);
			timings.Add($"huge (2nd time): {huge} items ({hugeSize})", sw.Elapsed);
			sw.Restart();

			var tinyBulkResponse = this.Deserialize(tinyResponse);
			timings.Add($"tiny: {tiny} items ({tinySize})", sw.Elapsed);
			using (var r = new JsonTextReader(new StreamReader(new MemoryStream(hugeResponse))))
			{
				sw.Restart();
				while (r.Read());
			}
			timings.Add($"raw read: {huge} items ({hugeSize})", sw.Elapsed);
			sw.Stop();
			throw new Exception(timings.Aggregate(new StringBuilder().AppendLine(), (sb, kv) => sb.AppendLine($"{kv.Key}: {kv.Value}"), sb =>sb.ToString()));
		}

		private string PrettySize(long len)
		{

			string[] sizes = { "B", "KB", "MB", "GB" };
			int order = 0;
			while (len >= 1024 && order + 1 < sizes.Length)
			{
				order++;
				len = len / 1024;
			}
			return $"{len:0.##} {sizes[order]}";
		}

		private BulkResponse Deserialize(byte[] response)
		{
			using (var ms = new MemoryStream(response))
				return Client.Serializer.Deserialize<BulkResponse>(ms);
		}

		private object BulkItemResponse() => new
		{
			index = new
			{
				_index = "nest-52cfd7aa",
				_type = "project",
				_id = "Kuhn LLC",
				_version = 1,
				_shards = new
				{
					total = 2,
					successful = 1,
					failed = 0
				},
				created = true,
				status = 201
			}
		};


		private object ReturnBulkResponse(int numberOfItems)
		{
			return new
			{
				took = 276,
				errors = false,
				items = Enumerable.Range(0, numberOfItems)
					.Select(i => BulkItemResponse())
					.ToArray()
			};
		}
	}
}
