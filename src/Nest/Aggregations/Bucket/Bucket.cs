using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest500
{
	public interface IBucket { }

	public abstract class BucketBase : AggregationsHelper, IBucket
	{
		protected BucketBase() { }
		protected BucketBase(IDictionary<string, IAggregate> aggregations) : base(aggregations) { }
	}
}
