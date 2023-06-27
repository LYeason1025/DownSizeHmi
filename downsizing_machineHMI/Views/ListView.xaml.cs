using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace downsizing_machineHMI.Views
{
    /// <summary>
    /// LitsView.xaml 的交互逻辑
    /// </summary>
    public partial class ListView : UserControl
    {
        private MainViewModel viewModel;

        public ListView()
        {
            InitializeComponent();
        }

        private void Select_Click(object sender, RoutedEventArgs e)
        {
            var MonitorContent = (ContentControl)MainWindow.GetWindow(this).FindName("ContentControlRight");
            MonitorContent.Visibility = Visibility.Visible;
            var listContent = (ContentControl)MainWindow.GetWindow(this).FindName("MainArea");
            listContent.Visibility = Visibility.Collapsed;
            var mainLeft = (ContentControl)MainWindow.GetWindow(this).FindName("ContentControl");
            mainLeft.Visibility = Visibility.Visible;
        }

        public class MainViewModel
        {
            public ObservableCollection<Grinder> grinders { get; set; }

            public MainViewModel()
            {
                grinders = new ObservableCollection<Grinder>
            {
                new Grinder {ID="1",Comment="GRINDER",size=8,Org=725,Fin=400,data="" },
                new Grinder {ID="2",Comment="GRINDER",size=8,Org=725,Fin=400,data="" },
                new Grinder {ID="3",Comment="GRINDER",size=8,Org=725,Fin=400,data="" },
            };


            }
        }

        public class Grinder
        {
            public string ID { get; set; }
            public string Comment { get; set; }
            public int size { get; set; }
            public int Org { get; set; }

            public int Fin { get; set; }

            public int Attr { get; set; }

            public string data { get; set; }

        }
    }
}
