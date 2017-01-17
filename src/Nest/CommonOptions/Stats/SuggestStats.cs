﻿using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	public class SuggestStats
	{
		[JsonProperty("current")]
		public long Current { get; set; }

		[JsonProperty("total")]
		public long Total { get; set; }

		[JsonProperty("total_time")]
		public string TotalTime { get; set; }
		[JsonProperty("total_time_in_millis")]
		public long TotalTimeInMilliseconds { get; set; }

	}
}