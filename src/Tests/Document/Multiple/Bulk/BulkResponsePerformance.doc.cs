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

		[U] public void BulkResponseSerializationIsFastEnough()
		{
			var serializer = Client.Serializer;
			var tinyResponse = serializer.SerializeToBytes(this.ReturnBulkResponse(1));
			var mediumResponse = serializer.SerializeToBytes(this.ReturnBulkResponse(100));
			var largeResponse = serializer.SerializeToBytes(this.ReturnBulkResponse(1000));
			var hugeResponse = serializer.SerializeToBytes(this.ReturnBulkResponse(100000));

			var warmup = this.Deserialize(tinyResponse);

			var timings = new List<TimeSpan>();
			var sw = Stopwatch.StartNew();
			var mediumBulkResponse = this.Deserialize(mediumResponse);
			timings.Add(sw.Elapsed);
			sw.Restart();
			var largeBulkResponse = this.Deserialize(largeResponse);
			timings.Add(sw.Elapsed);
			sw.Restart();
			var hugeBulkResponse = this.Deserialize(hugeResponse);
			timings.Add(sw.Elapsed);
			sw.Restart();
			hugeBulkResponse = this.Deserialize(hugeResponse);
			timings.Add(sw.Elapsed);
			sw.Restart();

			var tinyBulkResponse = this.Deserialize(tinyResponse);
			timings.Add(sw.Elapsed);
			sw.Restart();
			using (var r = new JsonTextReader(new StreamReader(new MemoryStream(hugeResponse))))
			{
				while (r.Read());
			}
			timings.Add(sw.Elapsed);
			sw.Stop();

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
			return new {
				took = 276,
				errors = false,
				items = Enumerable.Range(0, numberOfItems)
					.Select(i => BulkItemResponse())
					.ToArray()
			};
		}
	}
}
