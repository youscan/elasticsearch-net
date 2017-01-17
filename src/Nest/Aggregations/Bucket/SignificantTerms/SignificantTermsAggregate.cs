using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest252
{
	public class SignificantTermsAggregate : MultiBucketAggregate<SignificantTermsBucket>
	{
		public SignificantTermsAggregate() { }
		public SignificantTermsAggregate(IDictionary<string, IAggregate> aggregations) : base(aggregations) { }

		public long DocCount { get; set; }
	}
}
