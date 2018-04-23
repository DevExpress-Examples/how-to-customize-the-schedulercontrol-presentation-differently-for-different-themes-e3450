Imports System.Windows
Imports DevExpress.XtraScheduler

Namespace SchedulerThemeBasedStylesWpf
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            GenerateResources()
        End Sub

        Private Sub GenerateResources()
            schedulerControl1.Storage.BeginUpdate()
            Dim res As Resource = schedulerControl1.Storage.ResourceStorage.CreateResource(0)
            res.Caption = "First Resource"
            schedulerControl1.Storage.ResourceStorage.Add(res)

            res = schedulerControl1.Storage.ResourceStorage.CreateResource(1)
            res.Caption = "Second Resource"
            schedulerControl1.Storage.ResourceStorage.Add(res)
            schedulerControl1.Storage.EndUpdate()
        End Sub
    End Class
End Namespace
