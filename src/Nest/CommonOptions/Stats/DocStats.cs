using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public class DocStats
	{
		[JsonProperty(PropertyName = "count")]
		public long Count { get; set; }

		[JsonProperty(PropertyName = "deleted")]
		public long Deleted { get; set; }
	}
}
