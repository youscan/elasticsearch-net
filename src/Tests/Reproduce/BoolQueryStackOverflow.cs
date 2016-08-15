using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Framework;
using Tests.Framework.MockData;

namespace Tests.Reproduce
{
	public class BoolQueryStackOverflow
	{
		[U]
		public void LotsOfBoolClauses()
		{
			var n = 2000;
			var container = new QueryContainer();
			for (int i = 0; i < n; i++)
			{
				container |= Query<Project>.Bool(b => b
					.Must(must => must.Term(p => p.Name, "foo"))
				);
			}
		}
	}
}
