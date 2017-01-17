using Newtonsoft.Json;

namespace Nest252
{
	public class ShieldNodeStatus : Throwable
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}