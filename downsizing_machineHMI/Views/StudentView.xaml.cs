using downsizing_machineHMI.ViewModels;
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
using System.Windows.Shapes;

namespace downsizing_machineHMI.Views
{
    /// <summary>
    /// StudentView.xaml 的交互逻辑
    /// </summary>
    public partial class StudentView : Window
    {
        public StudentView()
        {
            InitializeComponent();
            this.DataContext = new StudentViewModel();
        }
    }
}
