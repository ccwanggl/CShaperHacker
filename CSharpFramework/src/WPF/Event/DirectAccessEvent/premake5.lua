project "01_HelloEvent"
	kind "WindowedApp"
	language "C#"
	dotnetframework "4.8"
	namespace "HelloEvent"

	targetdir ("../bin/" .. outputdir .. "/%{prj.name}")
	objdir ("../bin-int/" .. outputdir .. "/%{prj.name}")

	files 
	{
		"**.cs",
		"Properties/**.cs"
	}

	links
	{
		"System",
		"System.Windows.Forms",
	}
	
	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
