group "CSharpFramework/WPF"
	include "src/WPF/HelloWPF"

	group "CSharpFramework/WPF/AngeISix"
		include "src/WPF/AngeISix/WPFBasics"
		include "src/WPF/AngeISix/TreeViews"
	group ""
group ""

include "src/WPF/Binding"
include "src/WPF/XAML"
include "src/WPF/Property"

group "CSharpFramework/WPF/Event"
	include "src/WPF/Event/DirectAccessEvent"
	include "src/WPF/Event/RoutedEvent"
	include "src/WPF/Event/CustomRoutedEvent"
	include "src/WPF/Event/RoutedEventArgs"
	include "src/WPF/Event/AttachedEvent"
group ""

group "CSharpFramework/WPF/Command"
	include "src/WPF/Command/HelloCommand"
	include "src/WPF/Command/CommandParameter"
group ""

group "CSharpFramework/WPF/Template"
	include "src/WPF/Template/HelloTemplate"
	include "src/WPF/Template/HelloDataTemplate"
group ""

group "CSharpFramework/WPF/Resource"
	include "src/WPF/Resource/HelloResource"
	include "src/WPF/Resource/StaticDynamicResource"
group ""

group "CSharpFramework/WinForm"
	include "src/WinForm/HelloWindowsForms/"
group ""
