project "ParameterPassWithRef2"
	kind "ConsoleApp"
	language "C#"
	dotnetframework "4.8"
	csversion "8.0"
	clr "unsafe"

	targetdir (finaldir .. "/bin/" .. outputdir .. "/%{prj.name}")
	objdir (finaldir .. "/bin-int/" .. outputdir .. "/%{prj.name}")

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
