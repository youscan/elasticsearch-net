using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public class ClusterRerouteDecision
	{
		[JsonProperty("decider")]
		public string Decider { get; set; }

		[JsonProperty("decision")]
		public string Decision { get; set; }

		[JsonProperty("explanation")]
		public string Explanation { get; set; }
	}
}
