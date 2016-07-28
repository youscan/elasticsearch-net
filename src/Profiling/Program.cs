using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using Profiling.Memory;
using Profiling.Performance;
using Profiling.Timeline;
using Tests.Framework;
using Tests.Search.Search;

namespace Profiling
{
	class Program
	{
		private const string SdkUrl = "http://download-cf.jetbrains.com/resharper/" + Zip;
		private const string Zip = ZipDirectory + ".zip";
		private const string ZipDirectory = "ProfilerSelfSdk02";

		private static readonly string SdkPath =
			new DirectoryInfo(
				Path.Combine(
					AppDomain.CurrentDomain.BaseDirectory,
					$@".\..\..\..\..\..\build\tools\{ZipDirectory}")).FullName;

		private static readonly string OutputPath =
			new DirectoryInfo(
				Path.Combine(
					AppDomain.CurrentDomain.BaseDirectory,
					$@".\..\..\..\..\..\build\output\profiling")).FullName;

		private static void DownloadSdkIfNeeded(ColoredConsoleWriter output)
		{
			if (!Directory.Exists(SdkPath))
			{
				Directory.CreateDirectory(SdkPath);
				output.WriteLine(ConsoleColor.Yellow, $"profiling sdk not found at {SdkPath}. Downloading...");
				using (var client = new WebClient())
				{
					var zipPath = Path.Combine(SdkPath, Zip);
					client.DownloadFile(SdkUrl, zipPath);
					output.WriteLine(ConsoleColor.Green, "Extract zip file");
					ZipFile.ExtractToDirectory(zipPath, SdkPath);
					File.Delete(zipPath);
				}
				output.WriteLine(ConsoleColor.Green, "profiling sdk downloaded");
			}
		}

		// TODO: allow use of explicit and ignored timeline and profile tests
		static void Main(string[] args)
		{
			if (!Directory.Exists(OutputPath))
				Directory.CreateDirectory(OutputPath);

			var output = new ColoredConsoleWriter();
			output.WriteLine(ConsoleColor.Green, $"app directory: {AppDomain.CurrentDomain.BaseDirectory}");
			DownloadSdkIfNeeded(output);

			// TODO move the tests.yml to a more general location and Add Existing Item -> Add Link?
			TestClient.Configuration = new ProfilingTestConfiguration();
			var assembly = typeof(SearchProfileTests).Assembly;

			using (var cluster = new ProfilingCluster())
			{
				var profilingFactories = new List<IProfileFactory>
				{
					new TimelineProfileFactory(SdkPath, OutputPath, cluster, assembly, output),
					new PerformanceProfileFactory(SdkPath, OutputPath, cluster, assembly, output),
					new MemoryProfileFactory(SdkPath, OutputPath, cluster, assembly, output),
				};

				foreach (var profilingFactory in profilingFactories)
				{
					profilingFactory.Run();
					profilingFactory.RunAsync().ConfigureAwait(false).GetAwaiter().GetResult();
				}
			}
		}
	}
}
