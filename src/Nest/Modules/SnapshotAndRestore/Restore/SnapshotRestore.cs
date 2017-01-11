using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest500
{
	public class SnapshotRestore
	{
		[JsonProperty("snapshot")]
		public string Name { get; internal set;  }

		[JsonProperty("indices")]
		public IReadOnlyCollection<IndexName> Indices { get; internal set; } =
			EmptyReadOnly<IndexName>.Collection;

		[JsonProperty("shards")]
		public ShardsMetaData Shards { get; internal set;  }
	}
}
