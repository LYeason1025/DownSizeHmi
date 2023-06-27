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
    /// AutoView.xaml 的交互逻辑
    /// </summary>
    public partial class AutoView : UserControl
    {
 
        public AutoView()
        {
            InitializeComponent();
        }

        private void List_Click(object sender, RoutedEventArgs e)
        {

            var MonitorContent = (ContentControl)MainWindow.GetWindow(this).FindName("ContentControlRight");
            MonitorContent.Visibility = Visibility.Collapsed;
            var listContent = (ContentControl)MainWindow.GetWindow(this).FindName("MainArea");
            listContent.Visibility = Visibility.Visible;
            listContent.Content = new ListView();
            var mainLeft = (ContentControl)MainWindow.GetWindow(this).FindName("ContentControl");
            mainLeft.Visibility = Visibility.Collapsed;
        }

        private void Detail_Click(object sender, RoutedEventArgs e)
        {
            var mainLeft = (ContentControl)MainWindow.GetWindow(this).FindName("ContentControl");
            DetailView detail = new DetailView();
            mainLeft.Content = detail;
            detail.DetailContent.Content = new DetailView1();
            detail.Detail_1.IsChecked = true;

        }

        private void SwitchZ1_Checked(object sender, RoutedEventArgs e)
        {
            this.SwitchZ1.Content = "ON";
        }
        private void SwitchZ2_Checked(object sender, RoutedEventArgs e)
        {
            this.SwitchZ2.Content = "ON";
        }
        private void SwitchZ1_Unchecked(object sender, RoutedEventArgs e)
        {
            this.SwitchZ1.Content = "OFF";
        }
        private void SwitchZ2_Unchecked(object sender, RoutedEventArgs e)
        {
            this.SwitchZ2.Content = "OFF";
        }
    }
}
