#module nuget:?package=Cake.BuildSystems.Module&version=4.2.0

Setup(context =>
{
    Information("This is the setup...");
});

Teardown(context =>
{
    Information("This is the teardown...");
});

TaskSetup(setupContext =>
{
    var message = string.Format("Task Setup: {0}", setupContext.Task.Name);
    Information(message);
});

TaskTeardown(teardownContext =>
{
    var message = string.Format("Task TearDown: {0}", teardownContext.Task.Name);
    Information(message);
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

RunTarget("Default");