XAMLOutputDir = os.getcwd()
print("XAML Output dir: " .. XAMLOutputDir)

group "CSharpFramework/WPF/XAML"
	include "AttributeEvent"
	include "HelloXAML"
	include "PropertyAssignment"
	include "TypeConvert"
	include "MarkupExtension"
	include "ControlLibrary"
	include "Xnamespace"
	include "CallDll"

	group "CSharpFramework/WPF/XAML/Control_and_Layout"
		-- layout control
		include "LayoutGrid"
		include "LayoutStackpanel"
		include "LayoutCanvas"
		include "LayoutDockPanel"
		include "LayoutWrapPanel"
		include "LayoutContent"

		-- content control
		include "ContentControl"
	group ""
group ""
