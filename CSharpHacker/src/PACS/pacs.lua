project "PACS"
	kind "WindowedApp"
	language "C#"
	dotnetframework "4.8"
	namespace "PACS"

	targetdir ("bin/" .. outputdir .. "/%{prj.name}")
	objdir ("bin-int/" .. outputdir .. "/%{prj.name}")

	flags {"WPF"}
	
	nuget 
	{
	
	}
	files 
	{
		"**.cs",
		"**.xaml",
		"Properties/**.cs",
		"component/**.png",
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

	filter "files:component/**.png"
		buildaction "Resource"
	
	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
