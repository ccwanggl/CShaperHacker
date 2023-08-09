include "./vendor/premake_customization/solution_items.lua"
workspace "CSharpHacker"
    architecture "x64"

    configurations
    {
        "Debug",
        "Release",
    }

    solution_items
    {
        ".editorconfig"
    }

    flags
    {
        "MultiProcessorCompile"
    }

outputdir = "%{cfg.buildcfg}-%{cfg.system}-%{cfg.architecture}"

-- projects
group "Dependencies"
    include "vendor"
	include "CSharpConcepts"
	include "CSharpFramework"
group ""
