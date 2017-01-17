using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public class IndexSegment
	{
		[JsonProperty(PropertyName = "shards")]
		[JsonConverter(typeof(VerbatimDictionaryKeysJsonConverter))]
		public Dictionary<string, ShardsSegment> Shards { get; internal set; }
	}
}