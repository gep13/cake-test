Task("Default")
    .Does(() => 
{
    Information("Running build...");

    GitHubActions.Commands.SetStepSummary("test");
});

RunTarget("Default");