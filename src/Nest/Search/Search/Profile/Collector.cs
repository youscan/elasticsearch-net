using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest252
{
	public class Collector
	{
		[JsonProperty("name")]
		public string Name { get; internal set; }

		[JsonProperty("reason")]
		public string Reason { get; internal set; }

		[JsonProperty("time")]
		public Time Time { get; internal set; }

		[JsonProperty("children")]
		public IEnumerable<Collector> Children { get; internal set; }


	}
}
