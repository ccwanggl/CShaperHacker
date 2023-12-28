include "./vendor/premake_customization/solution_items.lua"
workspace "CSharpHacker"
    solution_items
    {
        ".editorconfig"
    }


outputdir = "%{cfg.buildcfg}-%{cfg.system}-%{cfg.architecture}"

-- projects
include "CSharpHacker/vendor/EmployedSchedulerSystemSource"
include "CSharpConcepts"
include "CSharpFramework"
include "vendor"
include "vendor/premake-core"
include "Github"
