using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGeneration.LowLevelClient.Overrides.Descriptors
{
	public class XpackWatcherStatsDescriptorOverrides : DescriptorOverridesBase
	{
		public override IEnumerable<string> SkipQueryStringParams => new []
		{
			"metric" // Can be set as part of the url instead
		};
	}
}
