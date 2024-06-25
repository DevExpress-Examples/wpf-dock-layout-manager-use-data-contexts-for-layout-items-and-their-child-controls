<!-- default file list -->
*Files to look at*:

* [Class1.cs](./CS/DataContext_Ex/Class1.cs) (VB: [Class1.vb](./VB/DataContext_Ex/Class1.vb))
* [MainWindow.xaml](./CS/DataContext_Ex/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DataContext_Ex/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DataContext_Ex/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DataContext_Ex/MainWindow.xaml.vb))
<!-- default file list end -->
# How to provide and use DataContexts for layout items and their controls


<p>This example demonstrates how to use DataContexts with layout items.</p><p>In this example, a DataContext is set for the DockLayoutManager. By default, this DataContext is inherited by all layout elements and their controls. In the example, a label (FixedItem) positioned within a top panel is bound to a property on this DataContext. The FixedItem object is not a FrameworkElement. So, to bind it to the inherited DataContext, the Binding.Path attribute must be set using the explicit syntax, plus Relative Source Mode must be set to Self:<br />


```Xaml
<newline/>
Text="{Binding Path=DataContext.Description, RelativeSource={RelativeSource Mode=Self}}"<newline/>

```

</p><p>Another DataContext is set for the panelPerson1 panel, overriding the default DataContext (that is inherited from the DockLayoutManager). TextBox controls are FrameworkElements. So, they intrinsically support the standard binding mechanism. So they can be bound to properties on this DataContext using an implicit syntax (you are still able to use the explicit syntax):</p>

```Xaml
<newline/>
Text="{Binding Title}"<newline/>

```

<p>Another DataContext is set for a group displaying two panels: panelPerson2Name and panelPerson2Address. The DataContext is inherited by these panels and their elements. Since TextBox controls that reside within these panels are FrameworkElements, they can be bound to properties on the inherited DataContext using the implicit syntax.</p>

<br/>


