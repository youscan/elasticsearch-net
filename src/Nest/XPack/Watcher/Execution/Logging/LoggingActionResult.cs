using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public class LoggingActionResult
	{
		[JsonProperty("logged_text")]
		public string LoggedText { get; set; }
	}
}