# vscode-spice

This project was generated with [dotnet core](https://dotnet.microsoft.com/download/) version 2.2.1.
[Install latest templates](https://www.nuget.org/packages/Microsoft.DotNet.Web.Spa.ProjectTemplates)

## Clone our app on git in Visual Studio Code

In terminal `git clone https://github.com/JosVermoesen/vscode-spice.git` to get the codefiles on your computer.
Step into the directory `cd vscode-spice` and do a `dotnet restore`

## Development server

Run `dotnet watch run` for a dev server. Navigate to `https://localhost:5001/`. The app will automatically reload if you change any of the code source files. For changes to the html razorpages refresh your browser

## Further help

To get more help on dotnet commands use `dotnet -h` or go check out the [dotnet documentation](https://docs.microsoft.com/nl-be/dotnet/).

## Fresh start in Visual Studio Code

In terminal `dotnet new --install Microsoft.DotNet.Web.Spa.ProjectTemplates::2.2.1` to get the latest templates.
In terminal `dotnet new -h` to list the available templates.

I.e. in terminal
a) make a directory `md vscode-spice`
b) cd into that directory `cd vscode-spice`
c) generate the new project with template `dotnet new webapp vscode-spice --auth Individual` for MVC Webapp with razor pages and identity with sql lite database.
d) add package reference for generating all identity `dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design` followed by `dotnet restore`
e) for adding complete identity functions `dotnet aspnet-codegenerator identity -dc vscode_spice.Data.ApplicationDbContext`
f) remove the sqllite database and migrations folder
g) start a clean db with full identity functionality `dotnet ef migrations add InitDbWithFullIdentity` and refresh the new db `dotnet ef database update`
