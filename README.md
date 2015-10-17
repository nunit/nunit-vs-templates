# NUnit Visual Studio Templates

An extension that adds Project and Item templates to Visual Studio
along with Code Snippets to make unit testing with NUnit 3 easier. 
We currently only plan to add templates for NUnit 3, but will add 
templates for NUnit 2.6.4 if there is demand.

This project is build using [SideWaffle](http://sidewaffle.com/), many
thanks for their great work.

## Content

The project currently provides the following templates.

### Project Templates

| Template                     | Language     |
|------------------------------|--------------|
| NUnit 3 Unit Test Project    | C#           |
| NUnit 3 Unit Test Project    | Visual Basic |

### Item Templates

| Template             | Language     |
|----------------------|--------------|
| NUnit Test Fixture  | C#           |
| NUnit Test Fixture  | Visual Basic |

### Code Snippets

| Snippet         | Shortcut | Language      |
|-----------------|----------|---------------|
| Test Class      | ntc      | C#            |
| Test Method     | ntm      | C#            |

## Contributing

Don't see the template you need or your favorite code snippet? All you need
to do is fork the repository, add it and create a pull request. We love help
and contributions.

For information on how to add templates and snippets, head over to the
[SideWaffle Documentation](https://github.com/ligershark/side-waffle/wiki)

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

TBC

### Adding Item Templates

TBC

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