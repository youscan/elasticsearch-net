using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public class IndexActionResult
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("response")]
		public IndexActionResultIndexResponse Response { get; set; }
	}
}
