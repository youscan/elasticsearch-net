using Newtonsoft.Json;

namespace Nest252
{
	public class ShieldNode
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("status")]
		public ShieldNodeStatus Status { get; set; }
	}
}