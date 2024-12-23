PropertyOutputDir = os.getcwd()
print("Property build files output dir: " .. PropertyOutputDir)

group "CSharpFramework/WPF/Property"
	include "HelloProperty"
	include "AttachedProperties"
	include "MyButton"
group ""
