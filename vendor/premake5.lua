project "Premake"
	kind "Utility"

	targetdir ("%{wks.location}/bin/" .. outputdir .. "/%{prj.name}")
	objdir ("%{wks.location}/bin-int/" .. outputdir .. "/%{prj.name}")

	files
	{
		"%{wks.location}/**premake5.lua"
	}

	postbuildmessage "Regenerating project files with Premake5!"
	postbuildcommands
	{
		"%{prj.location}bin/premake5 %{_ACTION} --file=\"%{wks.location}premake5.lua\""
	}

group "GithubRepos/PDFPatcher"
	externalproject "PDFPatcher"
		location "PDFPatcher/App"
		uuid="FAE04EC0-301F-11D3-BF4B-00C04F79EFBC"
		kind "WindowedApp"
		language "C#"

	externalproject "jbig2"
		location "PDFPatcher/JBig2"
		uuid="a8c76a16-25e3-45b6-b974-4f4cb88e5ae2"
		kind "SharedLib"
		language "C++"
group ""
