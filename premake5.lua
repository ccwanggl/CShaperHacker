include "./vendor/premake_customization/solution_items.lua"
workspace "CSharpHacker"
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
