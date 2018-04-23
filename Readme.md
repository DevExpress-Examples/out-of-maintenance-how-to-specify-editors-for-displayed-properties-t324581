# How to: Specify Editors for Displayed Properties


<p>Cell editors can be specified at the PropertyGridControl level as well as in a ViewModel/Model.<br><br>In the first case, we will need to create <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfPropertyGridPropertyDefinitiontopic">PropertyDefinition</a> objects for required properties. There are several ways to map definitions to properties, please refer to <a href="https://documentation.devexpress.com/#WPF/CustomDocument15521">Property Definitions</a> for detailed information.<br>To assign an editor, you can use either of the following properties

* <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinition_EditSettingstopic">EditSettings</a>;
* <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinition_CellTemplatetopic">CellTemplate</a>. Pay special attention that CellTemplate should be defined in a specific manner in order not to break navigation, validation, and synchronizing values. These requirements are listed described at <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinition_CellTemplatetopic">PropertyDefinition</a><a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinition_CellTemplatetopic">.</a><a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinition_CellTemplatetopic">CellTemplate</a> <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinition_CellTemplatetopic">Property</a>.<br><br>On the ViewModel/Model level, use the <strong>DefaultEditorAttribute </strong>(it is used by GridControl, PropertyGridControl, and DataLayoutControl) and <strong>PropertyGridEditorAttribute</strong>.</p>

<br/>


