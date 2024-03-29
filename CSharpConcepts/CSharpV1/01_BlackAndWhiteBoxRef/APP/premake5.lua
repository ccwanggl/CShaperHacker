project "APP"
	kind "ConsoleApp"
	language "C#"
	dotnetframework "4.8"
	csversion "9.0"

	targetdir (finaldir .. "/bin/" .. outputdir .. "/%{prj.name}")
	objdir (finaldir .. "/bin-int/" .. outputdir .. "/%{prj.name}")

	files
	{
		"**.cs",
	}

	links
	{
		"System",
		"System.Windows.Forms",
		"libSuperCalculator",
	}

	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
