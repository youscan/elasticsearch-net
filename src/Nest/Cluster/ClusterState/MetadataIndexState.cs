using System.Collections.Generic;
using Elasticsearch252.Net;
using Newtonsoft.Json;

namespace Nest252
{
	public class MetadataIndexState
	{
		[JsonProperty("state")]
		public string State { get; internal set; }

		[JsonProperty("settings")]
		[JsonConverter(typeof(VerbatimDictionaryKeysJsonConverter))]
		public DynamicResponse Settings { get; internal set; }

		[JsonProperty("mappings")]
		public IMappings Mappings { get; internal set; }

		[JsonProperty("aliases")]
		public IEnumerable<string> Aliases { get; internal set; }
	}
}