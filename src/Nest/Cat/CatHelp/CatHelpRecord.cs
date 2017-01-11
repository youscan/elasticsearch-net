using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public class CatHelpRecord : ICatRecord
	{
		[JsonProperty("endpoint")]
		public string Endpoint { get; set; }

	}
}
