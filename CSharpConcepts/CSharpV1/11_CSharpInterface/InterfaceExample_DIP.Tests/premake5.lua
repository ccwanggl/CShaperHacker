project "InterfaceExample_DIP.Tests"
	kind "SharedLib"
	language "C#"
	dotnetframework "net6.0"
	csversion "10.0"
	clr "NetCore"

	targetdir (finaldir .. "/bin/" .. outputdir .. "/%{prj.name}")
	objdir (finaldir .. "/bin-int/" .. outputdir .. "/%{prj.name}")

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
