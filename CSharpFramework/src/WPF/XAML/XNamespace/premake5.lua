project "06_Xnamespace"
	kind "WindowedApp"
	language "C#"
	dotnetframework "4.8"
	namespace "Xnamespace"

	targetdir (XAMLOutputDir .. "/bin/" .. outputdir .. "/%{prj.name}")
	objdir (XAMLOutputDir .. "/bin-int/" .. outputdir .. "/%{prj.name}")

	files 
	{
		"**.cs",
		"**.xaml",
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
		"System.Xml.Linq"
	}
	
	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
