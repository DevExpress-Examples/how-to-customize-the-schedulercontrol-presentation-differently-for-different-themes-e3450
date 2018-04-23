using System.Windows;
using DevExpress.XtraScheduler;

namespace SchedulerThemeBasedStylesWpf {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            GenerateResources();
        }

        private void GenerateResources() {
            schedulerControl1.Storage.BeginUpdate();
            Resource res = schedulerControl1.Storage.ResourceStorage.CreateResource(0);
            res.Caption = "First Resource";
            schedulerControl1.Storage.ResourceStorage.Add(res);

            res = schedulerControl1.Storage.ResourceStorage.CreateResource(1);
            res.Caption = "Second Resource";
            schedulerControl1.Storage.ResourceStorage.Add(res);
            schedulerControl1.Storage.EndUpdate();
        }
    }
}
