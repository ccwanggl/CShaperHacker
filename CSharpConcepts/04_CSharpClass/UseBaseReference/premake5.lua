project "UseBaseReference"
	kind "ConsoleApp"
	language "C#"
	dotnetframework "4.8"
	csversion "7.0"
	clr "unsafe"

	targetdir ("../bin/" .. outputdir .. "/%{prj.name}")
	objdir ("../bin-int/" .. outputdir .. "/%{prj.name}")

	files 
	{
		"**.cs",
	}

	links
	{
		"System",
		"Microsoft.CSharp",
	}

	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"