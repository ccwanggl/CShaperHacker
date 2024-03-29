project "DotNET"
	kind "ConsoleApp"
	language "C#"
	flags "WPF"
	dotnetframework "net6.0"
	clr "NETCore"

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
