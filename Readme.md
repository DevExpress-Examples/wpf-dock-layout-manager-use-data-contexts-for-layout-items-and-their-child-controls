# WPF Dock Layout Manager - Use DataContexts for LayoutItems and Their Child Controls

This example uses **DataContexts** with layout items.

<img src="https://user-images.githubusercontent.com/12169834/175366187-e8830ef4-f547-4700-90ff-f9a375fd7156.png" width=575px/>

In this example, a **DataContext** is set for the [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager). A label (FixedItem) that is positioned within a top panel is bound to a property from this **DataContext**. 


The FixedItem object is not a FrameworkElement. To bind it to the inherited **DataContext**, the Binding.Path attribute must be specified with explicit syntax, plus Relative Source Mode must be set to **Self**:

```Xaml
Text="{Binding Path=DataContext.Description, RelativeSource={RelativeSource Mode=Self}}"

```

Another **DataContext** is set for the _panelPerson1_ panel, overriding the default **DataContext** (which is inherited from the [DockLayoutManager](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager)). TextBox controls are FrameworkElements that support the standard binding mechanism. You can use implicit and explicit syntaxes to bind them to properties from this **DataContext**:

```Xaml
Text="{Binding Title}"

```

Another [DataContext](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager) is set for a group that displays _panelPerson2Name_ and _panelPerson2Address_ panels. These panels and their elements inherit the **DataContext**. You can use implicit syntax to bind TextBox controls that are placed in these panels to properties from the inherited [DataContext](https://docs.devexpress.com/WPF/DevExpress.Xpf.Docking.DockLayoutManager).

<!-- default file list -->
## Files to Look At

* [Class1.cs](./CS/DataContext_Ex/Class1.cs) (VB: [Class1.vb](./VB/DataContext_Ex/Class1.vb))
* [MainWindow.xaml](./CS/DataContext_Ex/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DataContext_Ex/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DataContext_Ex/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DataContext_Ex/MainWindow.xaml.vb))
<!-- default file list end -->

## Documentation
* [Dock Items](http://docs.devexpress.com/WPF/7209/controls-and-libraries/layout-management/dock-windows/dock-items)
