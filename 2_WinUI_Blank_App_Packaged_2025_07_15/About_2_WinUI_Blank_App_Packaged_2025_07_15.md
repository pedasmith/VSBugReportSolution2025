# Issues: don't start your project names with numbers


## Links

Blog post: (Don't start your project names with numbers)[https://sunriseprogrammer.blogspot.com/2025/07/vs-dont-start-your-project-names-with.html]
Bug report: 
Github: 


## Blog post copy:

Ever get an error in a brand new project saying that "App.WinRTVtable.g.cs" is failing and that "global::WinRT is a namespace?Tearing your hair out because what in the world could you have done to make this fail?

It turns out it's your project name. When you make a WinUI Blank App (Packaged) in Visual Studio 2022, and the project starts with a letter, it makes a broken project.

Here's the dump from the Output window for building.

```
1>------ Build started: Project: 2_WinUI_Blank_App_Packaged_2025_07_15, Configuration: Debug x64 ------

1>C:\temp\2025\testrepos\VSBugReportSolution\2_WinUI_Blank_App_Packaged_2025_07_15\obj\x64\Debug\net8.0-windows10.0.19041.0\win-x64\intermediatexaml\WinRT.SourceGenerator\Generator.WinRTAotSourceGenerator\_2_WinUI_Blank_App_Packaged_2025_07_15.App.WinRTVtable.g.cs(4,40,4,53): error CS0118: 'global::WinRT' is a namespace but is used like a type

1>C:\temp\2025\testrepos\VSBugReportSolution\2_WinUI_Blank_App_Packaged_2025_07_15\obj\x64\Debug\net8.0-windows10.0.19041.0\win-x64\intermediatexaml\WinRT.SourceGenerator\Generator.WinRTAotSourceGenerator\_2_WinUI_Blank_App_Packaged_2025_07_15.App.WinRTVtable.g.cs(4,56,4,104): error CS0103: The name 'WinUI_Blank_App_Packaged_2025_07_15VtableClasses' does not exist in the current context

1>C:\temp\2025\testrepos\VSBugReportSolution\2_WinUI_Blank_App_Packaged_2025_07_15\obj\x64\Debug\net8.0-windows10.0.19041.0\win-x64\intermediatexaml\WinRT.SourceGenerator\Generator.WinRTAotSourceGenerator\_2_WinUI_Blank_App_Packaged_2025_07_15.App.WinRTVtable.g.cs(4,2,4,164): error CS1729: 'WinRTExposedTypeAttribute' does not contain a constructor that takes 3 arguments

1>Done building project "2_WinUI_Blank_App_Packaged_2025_07_15.csproj" -- FAILED.
```


