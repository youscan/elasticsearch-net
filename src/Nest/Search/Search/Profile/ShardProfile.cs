using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest252
{
	public class ShardProfile
	{
		[JsonProperty("id")]
		public string Id { get; internal set; }

		[JsonProperty("searches")]
		public IEnumerable<SearchProfile> Searches { get; internal set; }

	}
}
