Task("Default")
    .Does(() => 
{
    Information("Running build...");
});

Teardown(context =>
{
    GitHubActions.Commands.SetStepSummary("This is where the final step summary will go...");
});

RunTarget("Default");