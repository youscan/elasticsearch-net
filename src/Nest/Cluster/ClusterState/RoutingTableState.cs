using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nest500
{
	public class RoutingTableState
	{
		[JsonProperty("indices")]
		[JsonConverter(typeof(VerbatimDictionaryKeysJsonConverter<string, IndexRoutingTable>))]
		public IReadOnlyDictionary<string, IndexRoutingTable> Indices { get; internal set; } = EmptyReadOnly<string, IndexRoutingTable>.Dictionary;
	}
}
