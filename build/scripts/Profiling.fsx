#I @"../../packages/build/FAKE/tools"
#r @"FakeLib.dll"
#r @"System.Xml.Linq.dll"
open Fake

#load @"Paths.fsx"

open System
open System.IO
open System.Linq
open System.Diagnostics
open System.Xml
open System.Xml.Serialization
open System.Xml.Linq
open Paths

module Profiler =
    let private profiledApp = combinePaths (Paths.Source("Profiling/bin/Net45/Release")) "Profiling.exe"
    let private snapShotOutput = Paths.Output("ProfilingSnapshot.dtp")
    let private snapShotStatsOutput = Paths.Output("ProfilingSnapshotStats.html")
    let private profileOutput = Paths.Output("ProfilingReport.xml")
    let private patternInput = Paths.Build("profiling/pattern.xml")

    let private element name children =
        XElement(XName.Get name, (children:XObject seq)) :> XObject

    let private attribute name value =
        XAttribute(XName.Get name, value) :> XObject

    let Run() = 
        // Profile, extract Stats, create Report
        // Tooling.DotTraceProfiler.Exec [@"/app=" + profiledApp; "/profiling_type=sampling"; snapShotOutput; @"/timeout=600"; @"/use_api"; @"/transparent_exit_code"]
        // Tooling.DotTraceSnapshotStats.Exec [snapShotOutput; snapShotStatsOutput; @"/full"]
        // Tooling.DotTraceReporter.Exec [@"/reporting"; snapShotOutput; patternInput; profileOutput]

        Tooling.execProcessWithTimeout profiledApp [] (TimeSpan.FromMinutes 30.) |> ignore

        let performanceOutput = Paths.Output("profiling/performance") |> directoryInfo

        for snapshot in Directory.EnumerateFiles(performanceOutput.FullName, "*.dtp", SearchOption.AllDirectories) do
            let snapshotPath = snapshot |> fileInfo
            let snapShotName = snapshotPath.Directory.FullName
                                    .Replace(performanceOutput.FullName, "")
                                    .Replace(@"\", ".")
                                    .TrimStart('.')
            let snapShotFileName = snapShotName + ".xml"                     
            let snapshotReport = combinePaths snapshotPath.Directory.FullName snapShotFileName

            Tooling.DotTraceSnapshotStats.Exec [snapshotPath.FullName; (combinePaths Paths.BuildOutput (snapShotName + ".html")); @"/full"]
            Tooling.DotTraceReporter.Exec [@"/reporting"; snapshotPath.FullName; patternInput; snapshotReport]

            let report = XDocument.Load snapshotReport
            let reportElem = report.Element(XName.Get "Report")
            reportElem.Add (attribute "Name" snapShotName)
            report.Save snapshotReport

            if fileExists profileOutput = false then
                let reports = element "Reports" [ reportElem ]
                let doc = new XDocument([| reports |])
                doc.Save profileOutput
            else
                let reports = XDocument.Load profileOutput
                let reportsElem = reports.Element(XName.Get "Reports")
                reportsElem.Add reportElem
                reports.Save profileOutput
                