Price Divergence Monitor (C#)

A small C# implementation of a **Price Divergence Monitor** that tracks pairs of correlated stocks and **reports** when the absolute price difference between a monitored pair exceeds a configured threshold.

This repo contains:
- `Price.cs` — the `PriceDivergenceMonitor` implementation
- `Div.cs` — the `DivergenceReporter` helper used to log divergences
- `TestCase` — sample `xUnit` test cases showing expected behavior

Right now the repo is just source files. If you want to run xUnit tests locally, the easiest setup is:

-Create a solution + projects:

dotnet new sln -n project_2
dotnet new classlib -n Project2
dotnet new xunit -n Project2.Tests
dotnet sln project_2.sln add Project2/Project2.csproj
dotnet sln project_2.sln add Project2.Tests/Project2.Tests.csproj
dotnet add Project2.Tests/Project2.Tests.csproj reference Project2/Project2.csproj

-Copy files into the projects:

Put Div.cs and Price.cs into Project2/
Put TestCase (rename to SampleTestCases.cs) into Project2.Tests/

-Run tests:

'dotnet test'
