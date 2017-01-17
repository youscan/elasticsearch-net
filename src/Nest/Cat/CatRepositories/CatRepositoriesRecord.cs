using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public class CatRepositoriesRecord : ICatRecord
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}
}
