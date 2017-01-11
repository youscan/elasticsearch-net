using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public class CompactNodeInfo
	{
		[JsonProperty(PropertyName = "name")]
		public string Name { get; internal set; }
	}
}