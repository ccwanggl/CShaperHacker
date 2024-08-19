project "MultiBinding"
	kind "WindowedApp"
	language "C#"
	dotnetframework "4.8"
	namespace "MultiBinding"

	targetdir ("../bin/" .. outputdir .. "/%{prj.name}")
	objdir ("../bin-int/" .. outputdir .. "/%{prj.name}")

	flags {"WPF"}
	
	files 
	{
		"**.cs",
		"**.xaml",
		"Properties/**.cs",
		"Properties/**.resx",
		"Properties/**.settings",
		"*.config"
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
		"System.Xml.Linq",
	}
	
	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
