using Newtonsoft.Json;

namespace Nest500
{
	public class SecurityNodeStatus : Throwable
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}
