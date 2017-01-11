using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest500
{
	public class RecoveryStatus
	{
		[JsonProperty("shards")]
		public IReadOnlyCollection<ShardRecovery> Shards { get; internal set; } =
			EmptyReadOnly<ShardRecovery>.Collection;
	}
}
