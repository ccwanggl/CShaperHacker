-- NOTE: What C# can do
group "CSharpConcepts/00_CSharpHelloWorld"
	-- include "00_CSharpHelloWorld/DotNET"
	-- include "00_CSharpHelloWorld/DotNETWinForm"
	-- include "00_CSharpHelloWorld/DotNETWPF"
	include "00_CSharpHelloWorld/DotNETFramework"
	include "00_CSharpHelloWorld/DotNETFrameworkWPF"
	include "00_CSharpHelloWorld/DotNETFrameworkWinForms"
group ""

-- NOTE: namespace
group "CSharpConcepts/01_BlackAndWhiteBoxRef"
	include "01_BlackAndWhiteBoxRef/LibSuperCalculator"
	include "01_BlackAndWhiteBoxRef/APP"
group ""

-- NOTE: C# programming overview
group "CSharpConcepts/02_CSharpProgrammingOverview"
	include "02_CSharpProgrammingOverview/WriteLine"
group ""

-- NOTE: C# type overview
group "CSharpConcepts/03_CSharpType"
	include "03_CSharpType/PredefinedType"
	include "03_CSharpType/UserDefinedTypeClass"
	include "03_CSharpType/UserDefinedTypeEnum"
	include "03_CSharpType/UserDefinedTypeStruct"
	include "03_CSharpType/UserDefinedTypeArray"
	include "03_CSharpType/AnonymousType"
	include "03_CSharpType/DynamicType"
	include "03_CSharpType/TypeSample"
group ""

-- NOTE: C# Class
group "CSharpConcepts/04_CSharpClass"
	include "04_CSharpClass/ClassDefinition"
	include "04_CSharpClass/AbstractClass"
	include "04_CSharpClass/AbstractClassWithDataMember"
	include "04_CSharpClass/InterfaceAbstractClass"
	include "04_CSharpClass/OverrideInClass"
	include "04_CSharpClass/OverrideMethod"
	include "04_CSharpClass/CVClass"
	include "04_CSharpClass/Indexer"
	include "04_CSharpClass/BaseClassAccess"
	include "04_CSharpClass/BaseClassRef"
	include "04_CSharpClass/UseBaseReference"
	include "04_CSharpClass/VirtualMethod"
	include "04_CSharpClass/CtorExec"
	include "04_CSharpClass/SealedClass"
	include "04_CSharpClass/StaticClass"
	include "04_CSharpClass/ExtensionMethods"
	include "04_CSharpClass/RefTypeAsValueParamVsRefParam"
group ""

-- NOTE: C# Class
group "CSharpConcepts/05_CSharpMethod"
	include "05_CSharpMethod/MethodExample"
group ""

group "CSharpConcepts/06_CSharpEvent"
	include "06_CSharpEvent/EventExample"
	include "06_CSharpEvent/EventExample_Click"
	include "06_CSharpEvent/EventExample_Clicked"
	include "06_CSharpEvent/EventExample_Custom"
	include "06_CSharpEvent/EventExample_Custom_Lite"
	include "06_CSharpEvent/EventExample_fourth"
	include "06_CSharpEvent/EventExample_Owner_Responer_Same"
	include "06_CSharpEvent/EventExample_MultiButton_One_Resp"
	include "06_CSharpEvent/EventSample"
group ""
-- NOTE: C# Class
group "CSharpConcepts/07_CSharpExpressionsAndOperator"
	include "07_CSharpExpressionsAndOperator/Arrow"
	include "07_CSharpExpressionsAndOperator/Checked"
	include "07_CSharpExpressionsAndOperator/Nullable"
	include "07_CSharpExpressionsAndOperator/CreateOperator"
	include "07_CSharpExpressionsAndOperator/DelegateOpr"
	include "07_CSharpExpressionsAndOperator/ToString"
	include "07_CSharpExpressionsAndOperator/Literal"
	include "07_CSharpExpressionsAndOperator/NameofOpr"
	include "07_CSharpExpressionsAndOperator/SizeofOpr"
	include "07_CSharpExpressionsAndOperator/IsOperator"
	include "07_CSharpExpressionsAndOperator/ExpressionReturn"
	include "07_CSharpExpressionsAndOperator/OperatorExamples"
	include "07_CSharpExpressionsAndOperator/NewOperator"
	include "07_CSharpExpressionsAndOperator/ExplicitConvertClass"
group ""

group "CSharpConcepts/08_CSharpDelegate"
	include "08_CSharpDelegate/DelegateExample"
	include "08_CSharpDelegate/DelegateExample_callback"
	include "08_CSharpDelegate/DelegateExample_interface"
	include "08_CSharpDelegate/DelegateExample_Pattern"
	include "08_CSharpDelegate/MulticastDelegateExample"
	include "08_CSharpDelegate/MulticastDelegateExample_asyn"
	include "08_CSharpDelegate/MulticastDelegateExample_task"
	include "08_CSharpDelegate/MulticastDelegateExample_thread"
	include "08_CSharpDelegate/AdvancedExample_Type_delegate"

group ""

group "CSharpConcepts/09_CSharpGeneric"
	include "09_CSharpGeneric/GenericExample"
	include "09_CSharpGeneric/GenericExample2"
	include "09_CSharpGeneric/GenericExample3"
	include "09_CSharpGeneric/GenericExample4"
	include "09_CSharpGeneric/GenericExample5"
	include "09_CSharpGeneric/GenericExample6"
group ""

-- NOTE: C# Parameter
group "CSharpConcepts/10_CSharpParameter"
	include "10_CSharpParameter/ParameterArray"
	include "10_CSharpParameter/ParameterDefault"
	include "10_CSharpParameter/ParameterLINQ"
	include "10_CSharpParameter/ParameterWithOut"
	include "10_CSharpParameter/ParameterWithOut2"
	include "10_CSharpParameter/ParameterNamedParam"
	include "10_CSharpParameter/ParameterPassByValue"
	include "10_CSharpParameter/ParameterPassByValue2"
	include "10_CSharpParameter/ParameterPassWithRef"
	include "10_CSharpParameter/ParameterPassWithRef2"
	include "10_CSharpParameter/ParameterPassWithRef3"
	include "10_CSharpParameter/ParameterScalAble"
group ""

group "CSharpConcepts/11_CSharpInterface"
	include "11_CSharpInterface/HelloCSharpInterface"
	include "11_CSharpInterface/InterfaceExample"
	include "11_CSharpInterface/InterfaceExample_Depend"
	include "11_CSharpInterface/InterfaceExample_DI"
	include "11_CSharpInterface/InterfaceExample_DIP"
	include "11_CSharpInterface/InterfaceExample_DIP.Tests"
	include "11_CSharpInterface/InterfaceExample_Interface"
	include "11_CSharpInterface/InterfaceExample_Reflection"

group ""

group "CSharpConcepts/12_CSharpProperty"
	include "12_CSharpProperty/PropertySamples"

group ""

group "CSharpConcepts/13_CSharpStruct"
	include "13_CSharpStruct/HelloCSharpStruct"
	include "13_CSharpStruct/ValueType"
	include "13_CSharpStruct/Ctor"
group ""

group "CSharpConcepts/14_CSharpEnum"
	include "14_CSharpEnum/HelloCSharpEnum"
group ""

group "CSharpConcepts/15_CSharpLINQ"
	include "15_CSharpLINQ/HelloLINQ"
group ""

group "CSharpConcepts/15_CSharpLINQ"
	include "16_CSharpAsync/HelloCSharpAsync"
group ""

-- NOTE: C# STD
group "CSharpConcepts/CSharpSTD/List"
	include "CSharpSTD/List/ListDemo"
group ""
