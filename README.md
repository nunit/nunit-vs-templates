# NUnit Visual Studio Templates

[![Build status](https://ci.appveyor.com/api/projects/status/lx7icpyp4g0m0223/branch/master?svg=true)](https://ci.appveyor.com/project/CharliePoole/nunit-templates/branch/master)

An extension that adds Project and Item templates to Visual Studio
along with Code Snippets to make unit testing with NUnit 3 easier. 
We currently only plan to add templates for NUnit 3, but will add 
templates for NUnit 2.6.4 if there is demand.

This project is build using [SideWaffle](http://sidewaffle.com/), many
thanks for their great work.

## Download

You can download the extension for Visual Studio 2012, 2013 and 2015 from the [Visual Studio Gallery](https://visualstudiogallery.msdn.microsoft.com/6cd55f79-4936-49e7-b81d-c40fcd81abc7)
or from the [GitHub Releases](https://github.com/nunit/nunit.templates/releases) page.

## Content

The project currently provides the following templates.

### Project Templates

| Template                     | Platform        | Language     |
|------------------------------|-----------------|--------------|
| NUnit 3 Unit Test Project    | Desktop         | C#           |
| NUnit 3 Unit Test Project    | Desktop         | Visual Basic |
| NUnit 3 Unit Test Project    | Xamarin Android | C#           |
| NUnit 3 Unit Test Project    | Xamarin iOS     | C#           |
| NUnit 3 Unit Test Project    | Xamarin UWP     | C#           |
| NUnit 3 Unit Test Project    | Xamarin WP8.1   | C#           |

### Item Templates

| Template             | Language     |
|----------------------|--------------|
| NUnit Test Fixture  | C#           |
| NUnit Test Fixture  | Visual Basic |

### Code Snippets

| Snippet         | Shortcut     | Language      |
|-----------------|--------------|---------------|
| Test Fixture    | ntestfixture | C#            |
| Test Method     | ntest        | C#            |
| Test Case       | ntestcase    | C#            |

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

- [SideWaffle](http://sidewaffle.com/) (Required) - Adds the 
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
- If you use NuGet packages in your project, remove packages.config and edit the project file to remove all of your NuGet references. You then add them to your vstemplate file. See the [NuGet docs](http://docs.nuget.org/Create/Packages-in-Visual-Studio-Templates) for more information.
- Test your project template by compiling and running the project. This will open an experimental
instance of Visual Studio with the extension installed for testing.
- Once you are happy with your project, **remove it from all build configurations**.- Add your project template to README.md
- Push your branch to GitHub and create a Pull Request

### Adding Item Templates

- *TBC*
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