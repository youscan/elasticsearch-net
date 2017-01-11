using System;
using System.Collections.Generic;

namespace Nest500
{
	public abstract class MetricAggregateBase : IAggregate
	{
		public IReadOnlyDictionary<string, object> Meta { get;  set; } = EmptyReadOnly<string, object>.Dictionary;
	}
}
