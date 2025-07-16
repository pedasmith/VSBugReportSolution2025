# Issue: a WinUI blank project doesn't compile out of the box

**Note**: ignore any mention of "WinUI3" in the code. That was incorrect.

## Summary

Making a project from any template should "just work". But the "WinUI Blank App (Packaged)" template does not compile out of the box.


## Repro steps

1. Create a new project using the "WinUI Blank App (Packaged)" project
2. In the VS menu, select "Build" + "Rebuild Solution"

Expected result: the project builds successfully
Actual result: the project fails to build with the error message:

```
Rebuild started at 6:01 PM...
1>------ Rebuild All started: Project: 2025-07-15-WinUI3-doesnt-compile-release, Configuration: Debug x64 ------
Restored C:\temp\2025\testrepos\VSBugReportSolution\2025-07-15-WinUI3-doesnt-compile-release\2025-07-15-WinUI3-doesnt-compile-release.csproj (in 62 ms).
1>C:\temp\2025\testrepos\VSBugReportSolution\2025-07-15-WinUI3-doesnt-compile-release\obj\x64\Debug\net8.0-windows10.0.19041.0\win-x64\intermediatexaml\WinRT.SourceGenerator\Generator.WinRTAotSourceGenerator\_2025_07_15_WinUI3_doesnt_compile_release.App.WinRTVtable.g.cs(4,40,4,53): error CS0118: 'global::WinRT' is a namespace but is used like a type
1>C:\temp\2025\testrepos\VSBugReportSolution\2025-07-15-WinUI3-doesnt-compile-release\obj\x64\Debug\net8.0-windows10.0.19041.0\win-x64\intermediatexaml\WinRT.SourceGenerator\Generator.WinRTAotSourceGenerator\_2025_07_15_WinUI3_doesnt_compile_release.App.WinRTVtable.g.cs(4,65,4,107): error CS0103: The name 'WinUI3_doesnt_compile_releaseVtableClasses' does not exist in the current context
1>C:\temp\2025\testrepos\VSBugReportSolution\2025-07-15-WinUI3-doesnt-compile-release\obj\x64\Debug\net8.0-windows10.0.19041.0\win-x64\intermediatexaml\WinRT.SourceGenerator\Generator.WinRTAotSourceGenerator\_2025_07_15_WinUI3_doesnt_compile_release.App.WinRTVtable.g.cs(4,2,4,170): error CS1729: 'WinRTExposedTypeAttribute' does not contain a constructor that takes 3 arguments
1>Done building project "2025-07-15-WinUI3-doesnt-compile-release.csproj" -- FAILED.
========== Rebuild All: 0 succeeded, 1 failed, 0 skipped ==========
========== Rebuild completed at 6:01 PM and took 05.308 seconds ==========

```


## History

The original failing project is [TestNmeaGpsParserWinUI](https://github.com/pedasmith/BluetoothDeviceController/tree/main/SmallProjects/TestNmeaGpsParserWinUI) That project uses WinUI3 (probably :-) )

## Other bugs discovered