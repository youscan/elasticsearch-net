using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest252
{
	public class IndexRoutingTable
	{
		[JsonProperty("shards")]
		[JsonConverter(typeof(VerbatimDictionaryKeysJsonConverter))]
		public Dictionary<string, List<RoutingShard>> Shards { get; internal set; }
	}
}