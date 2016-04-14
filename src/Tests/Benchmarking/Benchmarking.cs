#if DOTNETCORE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tests.Benchmarking
{
	[AttributeUsage(AttributeTargets.Method)]
	public class PerfSetupAttribute : Attribute
    {
    }

	[AttributeUsage(AttributeTargets.Method)]
	public class PerfBenchmarkAttribute : Attribute
	{
		public const int DefaultNumberOfIterations = 10;
		public const TestMode DefaultTestType = TestMode.Measurement;
		public const RunMode DefaultRunType = RunMode.Iterations;
		public const int DefaultRuntimeMilliseconds = 0;

		public int NumberOfIterations { get; set; }

		public int RunTimeMilliseconds { get; set; }

		public TestMode TestMode { get; set; }

		public RunMode RunMode { get; set; }

		public string Description { get; set; }

		public string Skip { get; set; }

		public PerfBenchmarkAttribute()
		{
			this.TestMode = TestMode.Measurement;
			this.RunMode = RunMode.Iterations;
			this.NumberOfIterations = 10;
			this.RunTimeMilliseconds = 0;
		}
	}

	[AttributeUsage(AttributeTargets.Method)]
	public class PerfCleanupAttribute : Attribute
	{
	}

	public enum RunMode
	{
		Iterations,
		Throughput,
	}

	public enum TestMode
	{
		Test,
		Measurement,

	}
}
#endif
