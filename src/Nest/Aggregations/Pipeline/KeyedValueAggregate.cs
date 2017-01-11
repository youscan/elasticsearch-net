using System.Collections.Generic;

namespace Nest500
{
	public class KeyedValueAggregate : ValueAggregate
	{
		public IList<string> Keys { get; set; }
	}
}
