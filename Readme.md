<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->
# How to customize the SchedulerControl presentation differently for different themes


<p>This example illustrates a very flexible approach of customizing <a href="http://documentation.devexpress.com/#WPF/CustomDocument8923"><u>DXScheduler Styles</u></a> (DateHeaderStyle and VerticalResourceHeaderStyle in this example) for different themes (DeepBlue and Office2007Blue in this example). To accomplish this task, simple define corresponding styles with appropriate <strong>x:Key</strong> and <strong>TargetType</strong> attributes. Note that you can use the <strong>BasedOn</strong> attribute to inherit your custom style from an existing one. This will allow you to significantly reduce XAML size because in this scenario it is required to override only necessary style elements. If you wish to fully customize a style, simply omit the <strong>BasedOn</strong> attribute specification and re-define the style completely. The default style implementation of a particular DXScheduler element can be found in the ...\DevExpress 2011.1\Components\Sources\DevExpress.Xpf.Scheduler\DevExpress.Xpf.Scheduler\Themes\Generic\ folder (only if the DXScheduler source code is installed). Note that this is the most flexible approach of overriding styles as it has the following advantages:</p><p>1) Different styles can be defined for different themes (note that it is necessary to use the <strong>ThemeName</strong> attribute in XAML to specify a target theme).<br />
2) It is not required to explicitely connect a style to SchedulerControl (e.g. set it via a property) or write any additional code to apply this style. When all styles has been defined, simply assign a required value to the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfCoreThemeManager_ThemeNametopic"><u>ThemeManager.ThemeName Attached Property</u></a> to apply a corresponding set of styles.</p><p><strong>See </strong><strong>A</strong><strong>lso:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E3419">How to customize DateNavigator presentation for specific themes</a></p>

<br/>


