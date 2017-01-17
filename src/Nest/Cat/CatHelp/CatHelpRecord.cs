using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public class CatHelpRecord : ICatRecord
	{
		[JsonProperty("endpoint")]
		public string Endpoint { get; set; }

	}
}
