include "./vendor/premake_customization/solution_items.lua"
workspace "CSharpHacker"
    solution_items
    {
        ".editorconfig"
    }


outputdir = "%{cfg.buildcfg}-%{cfg.system}-%{cfg.architecture}"

include "vendor/premake-core"
-- projects
group "PracticePrjs"
	include "CSharpHacker/vendor/EmployedSchedulerSystemSource/EmployedSchedulerSystem"
group ""
include "CSharpConcepts"
include "CSharpFramework"
include "vendor"
include "Github"
