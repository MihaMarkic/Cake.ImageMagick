#addin "Cake.FileHelpers"

var Project = Directory("./Cake.ImageMagick/");
var TestProject = Directory("./Cake.ImageMagick.Tests/");
var CakeAddinProj = Project + File("Cake.ImageMagick.csproj");
var CakeTestAddinProj = TestProject + File("Cake.ImageMagick.Test.csproj");
var CakeTestAddinAssembly = TestProject + Directory("bin/Release") + File("Cake.ImageMagick.Tests.dll");
var AssemblyInfo = Project + File("Properties/AssemblyInfo.cs");
var CakeAddinSln = File("./Cake.ImageMagick.sln");
var CakeAddinNuspec = File("./Cake.ImageMagick.nuspec");
var Nupkg = Directory("./nupkg");

var target = Argument("target", "Default");
var version = "";

Task("Default")
	.Does (() =>
	{
		NuGetRestore (CakeAddinSln);
		DotNetBuild (CakeAddinSln, c => {
			c.Configuration = "Release";
			c.Verbosity = Verbosity.Minimal;
		});
});

Task("UnitTest")
	.IsDependentOn("Default")
	.Does(() =>
	{
		NUnit3(CakeTestAddinAssembly);
	});

Task("NuGetPack")
	.IsDependentOn("GetVersion")
	.IsDependentOn("Default")
	.IsDependentOn("UnitTest")
	.Does (() =>
{
	CreateDirectory(Nupkg);
	NuGetPack (CakeAddinNuspec, new NuGetPackSettings { 
		Version = version,
		Verbosity = NuGetVerbosity.Detailed,
		OutputDirectory = Nupkg,
		BasePath = "./",
	});	
});

Task("GetVersion")
	.Does(() => {
		var assemblyInfo = ParseAssemblyInfo(AssemblyInfo);
		var semVersion = string.Join(".", assemblyInfo.AssemblyVersion.Split('.').Take(3));
		Information("Version {0}", semVersion);
		version = semVersion;
	});

RunTarget (target);
