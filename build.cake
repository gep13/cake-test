#module nuget:?package=Cake.BuildSystems.Module&version=4.2.0

Setup(context =>
{
    Information("This is the setup...");
});

Task("DependencyA")
    .IsDependentOn("DependencyB")
    .Does(() =>
{
    Information("Dependency A");
});

Task("DependencyB")
    .Does(() =>
{
    Information("Dependency B");
});

Task("Default")
    .IsDependentOn("DependencyA")
    .Does(() => 
{
    Information("Running build...");
});

Teardown(context =>
{
    //GitHubActions.Commands.SetStepSummary("This is where the final step summary will go...");
});

RunTarget("Default");