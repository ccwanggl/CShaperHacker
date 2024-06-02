project "01_WPFTreeView"
	kind "WindowedApp"
	language "C#"
	dotnetframework "4.8"
	namespace "WPFTreeView"

	targetdir ("../bin/" .. outputdir .. "/%{prj.name}")
	objdir ("../bin-int/" .. outputdir .. "/%{prj.name}")

	flags {"WPF"}
	
	files
	{
		"**.cs",
		"**.xaml",
		"Properties/**.cs",
		"Images/**.png"
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
	
	filter"files:Images/**.png"
		buildaction "Resource"

	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
