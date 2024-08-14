project "HelloWPFUI"
	kind "WindowedApp"
	language "C#"
	dotnetframework "4.8"

	targetdir ("../bin/" .. outputdir .. "/%{prj.name}")
	objdir ("../bin-int/" .. outputdir .. "/%{prj.name}")

	flags 
	{
		"WPF"
	}
	
	nuget 
	{
		"WPF-UI:3.0.5",
	}
	files 
	{
		"**.cs",
		"**.xaml",
		"Properties/**.cs",
		"Properties/**.settings",
		"Properties/**.resx"
	}

	links
	{
		"System",
		"System.Core",
		"System.Data",
		"System.Data.DataSetExtensions",
		"System.Xaml",
		"System.Xml",
		"System.Xml.Linq",
		"Microsoft.Csharp",
		"PresentationCore",
		"PresentationFramework",
		"WindowsBase",
	}
	
	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
