include "./vendor/premake_customization/solution_items.lua"
workspace "CSharpHacker"
    architecture "x86_64"
    solution_items
    {
        ".editorconfig"
    }

    configurations
    {
        "Debug",
        "Release",
    }

    flags
    {
        "MultiProcessorCompile"
    }

outputdir = "%{cfg.buildcfg}-%{cfg.system}-%{cfg.architecture}"

-- projects

include "CSharpConcepts"
include "CSharpFramework"
include "vendor"
