include "./vendor/premake_customization/solution_items.lua"
workspace "CSharpHacker"

	configurations { "Release", "Debug" }
	location ( _OPTIONS["to"] )

	flags { "MultiProcessorCompile" }
	warnings "Extra"

	if not _OPTIONS["no-zlib"] then
		defines { "PREMAKE_COMPRESSION" }
	end

	if not _OPTIONS["no-curl"] then
		defines { "CURL_STATICLIB", "PREMAKE_CURL"}
	end

	filter { "system:macosx", "options:arch=ARM or arch=ARM64" }
		buildoptions { "-arch arm64" }
		linkoptions { "-arch arm64" }

	filter { "system:macosx", "options:arch=x86 or arch=x86_64 or arch=Win32 or arch=x64" }
		buildoptions { "-arch x86_64" }
		linkoptions { "-arch x86_64" }

	filter { "system:macosx", "options:arch=Universal" }
		buildoptions { "-arch arm64", "-arch x86_64" }
		linkoptions { "-arch arm64", "-arch x86_64" }

	filter { "system:windows", "options:arch=ARM" }
		platforms { "ARM" }

	filter { "system:windows", "options:arch=ARM64" }
		platforms { "ARM64" }

	filter { "system:windows", "options:arch=x86 or arch=Win32" }
		platforms { "Win32" }

	filter { "system:windows", "options:arch=x86_64 or arch=x64" }
		platforms { "x64" }

	filter { "system:windows", "options:arch=default" }
		platforms { "x86", "x64" }

	filter "configurations:Debug"
		defines     "_DEBUG"
		flags       { "Symbols" }

	filter "configurations:Release"
		defines     "NDEBUG"
		optimize    "Full"
		flags       { "NoBufferSecurityCheck", "NoRuntimeChecks" }

	filter "action:vs*"
		defines     { "_CRT_SECURE_NO_DEPRECATE", "_CRT_SECURE_NO_WARNINGS", "_CRT_NONSTDC_NO_WARNINGS" }

	filter { "system:windows", "configurations:Release" }
		flags       { "NoIncrementalLink" }

	-- MinGW AR does not handle LTO out of the box and need a plugin to be setup
	filter { "system:windows", "configurations:Release", "toolset:not mingw" }
		flags		{ "LinkTimeOptimization" }

	filter { "system:uwp" }
		systemversion "latest:latest"
		consumewinrtextension "false"

    solution_items
    {
        ".editorconfig"
    }


outputdir = "%{cfg.buildcfg}-%{cfg.system}-%{cfg.architecture}"

-- projects
group "Dependencies"
    include "vendor"
	include "CSharpConcepts"
	include "CSharpFramework"
group ""
include "vendor/premake-core"
