using System.Collections.Generic;

namespace Nest252
{
	public class KeyedValueAggregate : ValueAggregate
	{
		public IList<string> Keys { get; set; }
	}
}
