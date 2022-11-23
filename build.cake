#module nuget:?package=Cake.BuildSystems.Module&version=4.2.0

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