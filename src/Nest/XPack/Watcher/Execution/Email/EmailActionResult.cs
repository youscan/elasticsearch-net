﻿using Newtonsoft.Json;

namespace Nest500
{
	[JsonObject]
	public class EmailActionResult
	{
		[JsonProperty("reason")]
		public string Reason { get; set; }

		[JsonProperty("account")]
		public string Account { get; set; }

		[JsonProperty("message")]
		public EmailResult Message { get; set; }
	}
}
