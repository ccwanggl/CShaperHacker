project "00_HelloXAML"
	kind "WindowedApp"
	language "C#"
	dotnetframework "4.8"


	targetdir (XAMLOutputDir .. "/bin/" .. outputdir .. "/%{prj.name}")
	objdir (XAMLOutputDir .. "/bin-int/" .. outputdir .. "/%{prj.name}")

	flags {"WPF"}
	namespace "HelloXAML"

	files 
	{
		"**.cs",
		"**.xaml",
		"Properties/**.cs",
		"*.png"
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
	
	filter "files:**.png"
		buildaction "Resource"

	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
