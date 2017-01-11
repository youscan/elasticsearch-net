using Newtonsoft.Json;

namespace Nest500
{
	public class SecurityNode
	{
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
