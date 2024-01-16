project "DotNET"
	kind "ConsoleApp"
	language "C#"
	dotnetframework "net8.0"
	clr "NetCore"

	targetdir (finaldir .. "/bin/" .. outputdir .. "/%{prj.name}")
	objdir (finaldir .. "/bin-int/" .. outputdir .. "/%{prj.name}")

	
	files
	{
		"**.cs",
	}
	links
	{
		"System"
	}
	
	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
