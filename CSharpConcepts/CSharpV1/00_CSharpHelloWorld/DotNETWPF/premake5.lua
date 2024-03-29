project "DotNETWPF"
	kind "WindowedApp"
	language "C#"
	dotnetframework "net6.0"
	clr "NetCore"

	 targetdir (finaldir .. "/bin/" .. outputdir .. "/%{prj.name}")
	objdir (finaldir .. "/bin-int/" .. outputdir .. "/%{prj.name}")

	buildaction ("Application")

	flags
	{
		"WPF"
	}
	files 
	{
		"**.cs",
		"**.xaml",
		"Properties/**.cs"
	}

	links
	{
		"Microsoft.Csharp",
		"PresentationCore",
		"PresentationFramework",
		"WindowsBase",
		"System",
		"System.Core",
		"System.Data",
		"System.Data.DataSetExtensions",
		"System.Xaml",
		"System.Xml",
		"System.Xml.Linq"
	}
	
	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
