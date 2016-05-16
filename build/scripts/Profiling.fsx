#I @"../../packages/build/FAKE/tools"
#r @"FakeLib.dll"
open Fake

#load @"Paths.fsx"

open System
open System.IO
open System.Linq
open System.Diagnostics
open Paths

module Profiler =
    let private profiledApp = combinePaths (Paths.BinFolder("Profiling")) "Profiling.exe"
    let private snapShotOutput = Paths.Output("ProfilingSnapshot.dtp")
    let private snapShotStatsOutput = Paths.Output("ProfilingSnapshotStats.html")
    let private profileOutput = Paths.Output("ProfilingReport.xml")
    let private patternInput = Paths.Build("profiling/pattern.xml")

    let Run() = 
        // Profile, extract Stats, create Report
        // Tooling.DotTraceProfiler.Exec [@"/app=" + profiledApp; "/profiling_type=sampling"; snapShotOutput; @"/timeout=600"; @"/use_api"; @"/transparent_exit_code"]
        // Tooling.DotTraceSnapshotStats.Exec [snapShotOutput; snapShotStatsOutput; @"/full"]
        // Tooling.DotTraceReporter.Exec [@"/reporting"; snapShotOutput; patternInput; profileOutput]

        Tooling.execProcessWithTimeout profiledApp [] (TimeSpan.FromMinutes 30.) |> ignore
        let performanceOutput = Paths.Output("profiling/performance") |> directoryInfo

        for snapshot in Directory.EnumerateFiles(performanceOutput.FullName, "*.dtp", SearchOption.AllDirectories) do
            let snapshotPath = snapshot |> fileInfo
            let snapShotName = snapshotPath.FullName.Replace(performanceOutput.FullName, "").Replace("/", ".")
            let snapshotReport = combinePaths snapshotPath.Directory.FullName snapShotName
            Tooling.DotTraceReporter.Exec [@"/reporting"; snapshotPath.FullName; patternInput; snapshotReport]
    


