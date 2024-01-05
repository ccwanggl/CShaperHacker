project "DotNETFrameworkWinForms"
	kind "ConsoleApp"
	language "C#"
	dotnetframework "4.8"

	 targetdir (finaldir .. "/bin/" .. outputdir .. "/%{prj.name}")
	objdir (finaldir .. "/bin-int/" .. outputdir .. "/%{prj.name}")
	
	files 
	{
		"**.cs",
		"Properties/**.cs"
	}

	links
	{
		"Microsoft.Csharp",
		"System",
		"System.Core",
		"System.Data",
		"System.Data.DataSetExtensions",
		"System.Deployment",
		"System.Drawing",
		"System.Net.Http",
		"System.Windows.Forms",
		"System.Xml",
		"System.Xml.Linq"
	}
	
	filter "configurations:Debug"
		optimize "Off"
		symbols "Default"

	filter "configurations:Release"
		optimize "On"
		symbols "Default"
