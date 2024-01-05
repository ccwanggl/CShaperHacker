project "ListDemo"
	kind "ConsoleApp"
	language "C#"
	dotnetframework "4.8"
	csversion "latest"
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
		"System.Text.Json",
	}

	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
