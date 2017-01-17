using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest252
{
	public class RecoveryStatus
	{
		[JsonProperty("shards")]
		public IEnumerable<ShardRecovery> Shards { get; internal set; }
	}
}