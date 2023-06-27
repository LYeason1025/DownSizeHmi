using downsizing_machineHMI.Views;
using System;
using System.Collections.Generic;
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
    /// DetailView.xaml 的交互逻辑
    /// </summary>
    public partial class DetailView : UserControl
    {
        public DetailView()
        {
            InitializeComponent();
        }

        private void Detail_2_Checked(object sender, RoutedEventArgs e)
        {
            if (Detail_1.IsChecked == true)
            {
                Detail_1.IsChecked = false;
            }

            this.DetailContent.Content = new DetailView2();
            Detail_2.IsChecked = true;

            this.WaferResset.Visibility = Visibility.Collapsed;
            this.TimeResset.Visibility = Visibility.Collapsed;
        }

        private void Detail_1_Checked(object sender, RoutedEventArgs e)
        {
            if (Detail_2.IsChecked == true)
            {
                Detail_2.IsChecked = false;
            }

            this.DetailContent.Content = new DetailView1();
            Detail_1.IsChecked = true;

            this.WaferResset.Visibility = Visibility.Visible;
            this.TimeResset.Visibility = Visibility.Visible;
        }

        private void Detail_Exit_Click(object sender, RoutedEventArgs e)
        {
            var mainleft = (ContentControl)MainWindow.GetWindow(this).FindName("ContentControl");

            mainleft.Content = new AutoView();
        }
    }
}
