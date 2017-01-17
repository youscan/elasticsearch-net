﻿using Newtonsoft.Json;

namespace Nest252
{
	[JsonObject]
	[JsonConverter(typeof(BulkResponseItemJsonConverter))]
	public class BulkDeleteResponseItem : BulkResponseItemBase
	{
		public override string Operation { get; internal set; }
		[JsonProperty("found")]
		public bool Found { get; internal set; }
	}
}