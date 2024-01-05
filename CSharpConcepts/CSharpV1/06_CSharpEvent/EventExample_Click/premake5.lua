project "EventExample_AllInOne"
	kind "ConsoleApp"
	language "C#"
	dotnetframework "4.8"
	csversion "7.0"

	targetdir (finaldir .. "/bin/" .. outputdir .. "/%{prj.name}")
	objdir (finaldir .. "/bin-int/" .. outputdir .. "/%{prj.name}")

	files
	{
		"**.cs",
	}

	links
	{
		"System",
		"System.Windows.Forms"
	}

	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
