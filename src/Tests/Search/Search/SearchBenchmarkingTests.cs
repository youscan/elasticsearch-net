using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tests.Framework.Integration;
using Tests.Framework.MockData;
using Tests.Framework.Configuration;
using Nest;
using System.IO;
using Tests.Framework;
#if !DOTNETCORE
using NBench;
using TestMode = NBench.TestMode;
#else
using Tests.Benchmarking;
using TestMode = Tests.Benchmarking.TestMode;
#endif

namespace Tests.Search.Search
{
	public class SearchBenchmarkingTests
	{
		private IIntegrationCluster _cluster;
		private IElasticClient _client;

		[PerfSetup]
		public void Setup()
		{
			TestClient.Configuration = new BenchmarkingTestConfiguration();
			_cluster = new BenchmarkingCluster();
			_client = _cluster.Client(s => s);
		}

		[PerfBenchmark(Description = "Test to ensure that a minimal throughput test can be rapidly executed.",
			NumberOfIterations = 1, RunMode = RunMode.Throughput, TestMode = TestMode.Measurement)]
		[MemoryMeasurement(MemoryMetric.TotalBytesAllocated)]
		[GcMeasurement(GcMetric.TotalCollections, GcGeneration.AllGc)]
		public void Benchmark()
		{
			_client.Search<Developer>(s => s.Query(q => q.MatchAll()));
		}

		[PerfCleanup]
		public void Cleanup()
		{
			_cluster.Node.Stop();
		}
	}

	public class BenchmarkingTestConfiguration : YamlConfiguration
	{
		public override string ElasticsearchVersion => "2.3.1";

		private static readonly string YamlConfigurationPath;

		static BenchmarkingTestConfiguration()
		{
			var directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());

			// If running the classic .NET solution, tests run from bin/{config} directory,
			// but when running DNX solution, tests run from the test project root
			YamlConfigurationPath = directoryInfo.Name == "Tests" &&
										directoryInfo.Parent != null &&
										directoryInfo.Parent.Name == "src"
				? "tests.yaml"
				: @"..\..\..\tests.yaml";
		}

		public override bool RunIntegrationTests => true;

		public override bool ForceReseed { get; protected set; } = true;

		public override bool DoNotSpawnIfAlreadyRunning { get; protected set; } = false;

		public BenchmarkingTestConfiguration()
			: base(YamlConfigurationPath)
		{
		}
	}

	public class BenchmarkingCluster : ClusterBase
	{
	}
}
