using System;
using System.Collections.Generic;

namespace Nest252
{
	public abstract class MetricAggregateBase : IAggregate
	{
		public IDictionary<string, object> Meta { get; set; }
	}
}
