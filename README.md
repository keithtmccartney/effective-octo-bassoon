# effective-octo-bassoon
[Chris Sainty] Creating a Reusable, JavaScript-Free Blazor Modal

Grab the article at [https://www.telerik.com/blogs/creating-a-reusable-javascript-free-blazor-modal](https://www.telerik.com/blogs/creating-a-reusable-javascript-free-blazor-modal)

## Tips/Run

* Ensuring the Blazor Templates version is up to date: ```dotnet new -i Microsoft.AspNetCore.Blazor.Templates```;
* Newly created directory 'BlazorModal': ```mkdir BlazorModal```;
* Creating a new blazorlib: ```dotnet new blazorlib```;
* Creating a new blazor: ```dotnet new blazor -n BlazorTest```;

## Errors Experienced

* I was dealt with an error - ```rzc generate exited with code 1``` - which I assumed came from removing some elements of a fresh project early on though this error was reproduced also on the generating of a new ```blazor``` project. Some suggestions from 2019 (and on earlier .NET Core builds) suggested suppressing the error with a ```@ref:suppressField``` but I'm continuing to investigate; it turns out the installing of the latest Blazor Templates targets a stable version and not a preview, thus I needed to run a latest specific version install via ```dotnet new --install Microsoft.AspNetCore.Blazor.Templates::3.2.0-preview1.20073.1``` (as of today 22nd October 2020);
* There are core issues to be corrected here in this project due to versioning between Blazor.Templates versions, this is not a task I am undertaking at the present time due to the desire for understanding the framework via a learning curve rather than a complete refactoring exercise in upgrading a project. That task I will undertake at a later point;

## Notes:

* I learned about the ```RenderFragment``` (dependent on ```Microsoft.AspNetCore.Blazor.RenderTree```) which 'Represents a segment of UI content, implemented as a delegate that writes the content to a ```Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder```';
* I learned about the ```BlazorComponent``` (dependent on ```Microsoft.AspNetCore.Blazor.Components```) which is an 'Optional base class for Blazor components. Alternatively, Blazor components may implement Microsoft.AspNetCore.Blazor.Components.IComponent directly';

## What's it all about?

* In this guide, Chris Sainty helps you learn how to build a reusable modal without using any JavaScript for your Blazor and Razor applications;

## Thanks

Thanks goes out to Chris Sainty for the FREE stuff!

* [Chris Sainty's Telerik profile](https://www.telerik.com/blogs/author/chris-sainty) ...Chris is a Microsoft MVP, software engineer and blogger with over 15 years experience working with ASP.NET...
