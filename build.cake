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