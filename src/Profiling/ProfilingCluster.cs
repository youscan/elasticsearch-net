using System;
using Nest252;
using Tests.Framework;
using Tests.Framework.Integration;

namespace Profiling
{
	public class ProfilingCluster : ClusterBase
	{
		public override void Bootstrap()
		{
			var seeder = new Seeder(this.Node);
			seeder.DeleteIndicesAndTemplates();
			seeder.CreateIndices();
		}
	}
}
