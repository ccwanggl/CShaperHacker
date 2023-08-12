project "NugetExample"
	kind "ConsoleApp"
	language "C#"
	dotnetframework "4.8"
	csversion "latest"

	targetdir ("../bin/" .. outputdir .. "/%{prj.name}")
	objdir ("../bin-int/" .. outputdir .. "/%{prj.name}")

	files 
	{
		"**.cs",
	}

	nuget 
	{
		"OSVersionExt:2.0.0"
	}
	links
	{
		"System",
		"OSVersionExt"
	}
	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
