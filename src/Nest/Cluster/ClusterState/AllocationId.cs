using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest252
{
	public class AllocationId
	{
		[JsonProperty("id")]
		public string Id { get; internal set; }
	}
}