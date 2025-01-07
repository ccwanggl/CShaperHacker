project "01_HelloDataTemplate"
	kind "WindowedApp"
	language "C#"
	dotnetframework "4.8"
	namespace "HelloDataTemplate"

	targetdir ("../bin/" .. outputdir .. "/%{prj.name}")
	objdir ("../bin-int/" .. outputdir .. "/%{prj.name}")

	flags {"WPF"}
	
	files
	{
		"**.cs",
		"**.xaml",
		"Properties/**.cs",
		"Properties/**",
		"Resources/**"
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

	filter "files:Resources/**.png or files:Resources/**.jpg"
		buildaction "Resource"

	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
