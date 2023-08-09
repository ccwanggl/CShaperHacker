project "XAML"
	kind "WindowedApp"
	language "C#"
	dotnetframework "4.8"

	targetdir ("../bin/" .. outputdir .. "/%{prj.name}")
	objdir ("../bin-int/" .. outputdir .. "/%{prj.name}")

	flags {"WPF"}
	
	files 
	{
		"**.cs",
		"**.xaml",
		"Properties/**.cs"
	}

	links
	{
	}
	
	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
