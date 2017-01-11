using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public class IndicesStats
	{
		[JsonProperty(PropertyName = "primaries")]
		public IndexStats Primaries { get; set; }
		[JsonProperty(PropertyName = "total")]
		public IndexStats Total { get; set; }
	}
}
