project "EmployedSchedulerSystem"
	kind "ConsoleApp"
	language "C#"
	dotnetframework "4.8"
	csversion "10.0"

	targetdir ("../bin/" .. outputdir .. "/%{prj.name}")
	objdir ("../bin-int/" .. outputdir .. "/%{prj.name}")

	files 
	{
		"**.cs",
	}

	links
	{
		"System",
	}

	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
