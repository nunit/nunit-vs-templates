# NUnit Visual Studio Templates

**This project has been archived.**  

**This is a VSIX project, which we don't support anymore.  Use `dotnet new nunit` instead, or install using Visual Studio - New Project dialog, selecting NUnit.**

---------

[![Build status](https://ci.appveyor.com/api/projects/status/lx7icpyp4g0m0223/branch/master?svg=true)](https://ci.appveyor.com/project/CharliePoole/nunit-templates/branch/master)

An extension that adds Project and Item templates to Visual Studio
along with Code Snippets to make unit testing with NUnit 3 easier. 
We currently only plan to add templates for NUnit 3, but will add 
templates for NUnit 2.6.4 if there is demand.

This project is build using [SideWaffle](http://sidewaffle.com/), many
thanks for their great work.

## Download

You can download the extension for Visual Studio 2012-2019 from the [Visual Studio Gallery](https://visualstudiogallery.msdn.microsoft.com/6cd55f79-4936-49e7-b81d-c40fcd81abc7)
or from the [GitHub Releases](https://github.com/nunit/nunit-vs-templates/releases) page.

## Content

The project currently provides the following templates.

### Project Templates

| Template                     | Platform                     | Language     | Project Type         |
|------------------------------|------------------------------|--------------|----------------------|
| NUnit 3 Unit Test Project    | Desktop                      | C#           | Traditional Style <sup>3</sup> |
| NUnit 3 Unit Test Project    | Desktop                      | C#           | Sdk Style            | 
| NUnit 3 Unit Test Project    | Desktop .NET Core            | C#           | SDK Style            | 
| NUnit 3 Unit Test Project    | Desktop                      | Visual Basic | Traditional Style <sup>3</sup> |
| NUnit 3 Unit Test Project    | Xamarin Android <sup>1</sup> | C#           | Traditional Style    |
| NUnit 3 Unit Test Project    | Xamarin iOS <sup>1</sup>     | C#           | Traditional Style    |
| NUnit 3 Unit Test Project    | Xamarin UWP <sup>1,2</sup>   | C#           | Traditional Style    |

1. Requires [Xamarin for Visual Studio](https://xamarin.com/visual-studio) be installed.
2. Requires the [Windows 10 SDK](https://dev.windows.com/en-us/downloads/windows-10-sdk) be installed.
3. Legacy csproj format 

### Item Templates

| Template             | Language      | Description |
|----------------------|---------------|-------------|
| NUnit Test Fixture   | C#            | An NUnit unit test class |
| NUnit Test Fixture   | Visual Basic  | An NUnit unit test class |
| NUnit SetUp Fixture  | C#            | Code that runs before and after all the tests in the assembly |
| NUnit SetUp Fixture  | Visual Basic  | Code that runs before and after all the tests in the assembly |

### Code Snippets

| Snippet         | Shortcut     | Language      | Comment |
|-----------------|--------------|---------------|---------|
| Test Fixture    | ntestfixture | C#            | |
| Test Method     | ntest        | C#            | |
| Test Case       | ntestcase    | C#            | |
| Test Case Source | ntestcasesource     | C#  | Form 1 |
| Test Case Source | ntestcasesource2    | C#  | Form 2 |
| Test Case Source | ntestcasesource3    | C#  | Form 3 |
| Test Case Source | ntestcasesource4    | C#  | Form 3 with testdata|
| Assert.Multiple | nmultiple | C# | Surround snippet |

Note:  "Form": Refer to [documentation for details](https://github.com/nunit/docs/wiki/TestCaseSource-Attribute)

## Contributing

Don't see the template you need or your favorite code snippet? All you need
to do is fork the repository, add it and create a pull request. We love help
and contributions.

For information on how to add templates and snippets, head over to the
[SideWaffle Documentation](https://github.com/ligershark/side-waffle/wiki).

There is also a great walkthrough on creating templates in the 
[June 2015 MSDN Magazine](https://msdn.microsoft.com/en-us/magazine/mt147242.aspx).

### Prerequisites

We highly recommend that you use the following extensions for Visual Studio when
working on this project.

- [SideWaffle](http://sidewaffle.com/) (Not needed, now included as nuget package) - Adds the 
templates and functionality you will need to work on this project.
- [Snippet Designer](https://github.com/mmanela/SnippetDesigner) - Provides a
friendly UI for editing code snippets.
- [EditorConfig](http://editorconfig.org/) - Configures tabs and spaces to the 
project defaults.
- [Rebracer](https://github.com/SLaks/Rebracer) - Configures code formating to 
the NUnit project defaults in Visual Studio.

### Adding Project Templates

- Add a new project that will serve as your template
- Modify the project to ensure it builds and produces the correct output
- Right click on the nunit.templates project and select **Add | Add Template Reference (SideWaffle project)**.
- Select your project from the dropdown and add it.
- Your project will have two new files added, `_Definitions\_project.vstemplate.xml` and `_preprocess.xml`.
- Edit both of these files using those from other projects as a reference.
- Delete **sw-file-icon.png** from your project.
- Copy **nunit.png** from **nunit-tests.csharp** into your project directory, but don't add it to your project.
- Remove packages.config and edit the project file to remove all of your NuGet references.
- Add NuGet packages to your *vstemplate* file. See the other *vstemplate* files and [NuGet docs](http://docs.nuget.org/Create/Packages-in-Visual-Studio-Templates) for more information.
- If the NuGet package isn't already in the `nunit.templates\Packages` directory, you will have to add it, set it as *Include in VSIX* and add it to the *vsixmanifest* file.
- Test your project template by compiling and running the project. This will open an experimental
instance of Visual Studio with the extension installed for testing.
- Once you are happy with your project, **remove it from all build configurations**.- Add your project template to README.md
- Push your branch to GitHub and create a Pull Request

### Adding Item Templates

- Right-click on the *ItemTemplates\Test* folder in the **nunit.templates** project, **Add | New Item...** and add a **SideWaffle Item Template**. Don't worry about the name, it is not used
- This will create a *CSharp* folder, rename it for your template 
- Add your source file into your new folder and set the **Build Action** in properties to **Content**
- Replace your namespace with *$rootnamespace$* and your class name with *$safeitemname$*
- Four vstemplate files were created in a *Definitions* sub-folder. Delete any for languages your template does not support and then rename the remaining from **.vstemplat-* to **.vstemplate*
- Fill in the *vstemplate* files using existing templates as a reference
- Delete the *readme.txt* file and overwrite *icon.png* with an existing NUnit icon from another template.
- Test your item template by compiling and running the project. This will open an experimental
instance of Visual Studio with the extension installed for testing.
- Add your item template to README.md
- Push your branch to GitHub and create a Pull Request

### Adding Code Snippets

- In the language specific Snippets folder of the **nunit.templates** project,
right click on the **Test** folder and **Add | New item...***
- Search for snippet and add a new **Code Snippet**
- Make sure the build type for your new snippet is set to **Content** in the properties
- Edit your snippet making sure to give it a unique shortcut. We are currently starting
all NUnit snippets with the letter n
- Test your snippet by compiling and running the project. This will open an experimental
instance of Visual Studio with the extension installed for testing.
- Add your snippet to README.md
- Push your branch to GitHub and create a Pull Request
