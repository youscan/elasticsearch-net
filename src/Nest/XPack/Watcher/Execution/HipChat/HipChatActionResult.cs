using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public class HipChatActionResult
	{
		[JsonProperty("account")]
		public string Account { get; set; }

		[JsonProperty("sent_messages")]
		public IEnumerable<HipChatActionMessageResult> SentMessages { get; set; }
	}
}