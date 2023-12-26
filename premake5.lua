include "./vendor/premake_customization/solution_items.lua"
workspace "CSharpHacker"
    solution_items
    {
        ".editorconfig"
    }


outputdir = "%{cfg.buildcfg}-%{cfg.system}-%{cfg.architecture}"

-- projects
include "CSharpConcepts"
include "CSharpFramework"
group "Dependencies"
    include "vendor"
group ""
include "vendor/premake-core"
