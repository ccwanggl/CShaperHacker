project "EventExample_MultiButton_One_Resp"
	kind "WindowedApp"
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
		"System.Data",
		"System.Drawing",
		"System.Windows.Forms"
	}

	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
