using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public class PagerDutyActionResult
	{
		[JsonProperty("sent_event")]
		public PagerDutyActionEventResult SentEvent { get; set; }
	}
}