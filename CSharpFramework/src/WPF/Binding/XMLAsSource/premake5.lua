project "05.004_XMLAsSource"
	kind "WindowedApp"
	language "C#"
	dotnetframework "4.8"
	dotnetsdk "WindowsDesktop"
	namespace "XMLAsSource"

	targetdir (BindingOutputDir .. "/bin/" .. outputdir .. "/%{prj.name}")
	objdir (BindingOutputDir .. "/bin-int/" .. outputdir .. "/%{prj.name}")
	
	files 
	{
		"**.cs",
		"**.xaml",
		"**.xml",
		"Properties/**"
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

	filter "files:**.xml"
		buildaction "Embed"
		buildaction "Copy"
	
	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
