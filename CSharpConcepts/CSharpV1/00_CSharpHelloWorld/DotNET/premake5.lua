project "DotNET"
	kind "ConsoleApp"
	language "C#"
	dotnetframework "net6.0"

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
