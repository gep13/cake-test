Setup(context =>
{
    Information("This is the setup...");
});

Teardown(context =>
{
    Information("This is the teardown...");
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

Task("Skipped")
    .WithCriteria(() => false, "This is a skipped task")
    .Does(() =>
{
    Information("This is a skipped task");
});

Task("Default")
    .IsDependentOn("DependencyA")
    .IsDependentOn("Skipped")
    .Does(() => 
{
    Information("Running build...");
});

RunTarget("Default");
