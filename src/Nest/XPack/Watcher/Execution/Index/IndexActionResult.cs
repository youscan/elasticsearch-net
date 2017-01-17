using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public class IndexActionResult
	{
		[JsonProperty("id")]
		public Id Id { get; set; }

		[JsonProperty("response")]
		public IndexActionResultIndexResponse Response { get; set; }
	}
}
