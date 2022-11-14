Task("Default")
    .Does(() => 
{
    Information("Running build...");
});

RunTarget("Default");