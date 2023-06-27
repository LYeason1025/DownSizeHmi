using Microsoft.VisualBasic;
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
using downsizing_machineHMI.Views;
using System.Windows.Forms.Integration;

using AxActProgTypeLib;
using AxActUtlTypeLib;
using System.ComponentModel;

namespace downsizing_machineHMI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool HO_Clicked = false;
       AxActUtlType axActUtlType1 =new AxActUtlType();
        public MainWindow()
        {
            InitializeComponent();
            AutoBtn.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }

    

        private void titleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void AutoBtn_Click(object sender, RoutedEventArgs e)
        {
            MainArea.Visibility = Visibility.Collapsed;
            ContentControl.Visibility = Visibility.Visible;
            ContentControl.Content = new AutoView();
            ContentControlRight.Visibility = Visibility.Visible;
            ContentControlRight.Content = new MonitorView();
            
        }

 
        private void MiniBtn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InitialBtn_Click(object sender, RoutedEventArgs e)
        {

            menuLeft.Visibility = Visibility.Collapsed;
            menuRight.Visibility = Visibility.Collapsed;
            menuSkip.Visibility = Visibility.Collapsed;

            initialTextBox.Visibility = Visibility.Visible;
            initialStart.Visibility = Visibility.Visible;
            initialTextBox.Visibility = Visibility.Visible;


            menuExit.Visibility = Visibility.Visible;
        }


        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (HO_Clicked==true)
            {

                FAPasue.Visibility = Visibility.Collapsed;
                MainArea.Visibility = Visibility.Collapsed;


                ContentControl.Content = new AutoView();
                ContentControl.Visibility = Visibility.Visible;
                ContentControlRight.Visibility = Visibility.Visible;

                FAPasueCL.Visibility = Visibility.Visible;

                HO_Clicked= false;
               
            }
            else
            {
                menuLeft.Visibility = Visibility.Visible;
                menuRight.Visibility = Visibility.Visible;
                menuSkip.Visibility = Visibility.Visible;

                ContentControl.Content = new AutoView();
                ContentControl.Visibility = Visibility.Visible;
               
                ContentControlRight.Visibility = Visibility.Visible;

                initialTextBox.Visibility = Visibility.Collapsed;
                initialStart.Visibility = Visibility.Collapsed;
                initialTextBox.Visibility = Visibility.Collapsed;
                menuExit.Visibility = Visibility.Collapsed;
                WarmUpStart.Visibility = Visibility.Collapsed;
                FAPasueCL.Visibility = Visibility.Collapsed;
                MainArea.Visibility = Visibility.Collapsed;
                initialTextBox.Visibility = Visibility.Collapsed;
                FAPasue.Visibility= Visibility.Collapsed;

            }

        }


        private void InitialStartBtn_Click(object sender, RoutedEventArgs e)
        {
            initialStart.Visibility = Visibility.Collapsed;
        }

        private void WarmUpBtn_Click(object sender, RoutedEventArgs e)
        {
            ContentControl.Content = new WarmUpView();
            menuLeft.Visibility = Visibility.Collapsed;
            menuRight.Visibility = Visibility.Collapsed;
            menuSkip.Visibility = Visibility.Collapsed;


            WarmUpStart.Visibility = Visibility.Visible;
            menuExit.Visibility = Visibility.Visible;
        }

        private void FABtn_Click(object sender, RoutedEventArgs e)
        {
            menuLeft.Visibility = Visibility.Collapsed;
            menuRight.Visibility = Visibility.Collapsed;
            menuSkip.Visibility = Visibility.Collapsed;

            FAPasue.Visibility = Visibility.Visible;
            menuExit.Visibility = Visibility.Visible;
        }

        private void FAPasueBtn_Click(object sender, RoutedEventArgs e)
        {
            FAPasue.Visibility = Visibility.Collapsed;

            FAPasueCL.Visibility = Visibility.Visible;
        }

        private void Height_Offset_Click(object sender, RoutedEventArgs e)
        {
            MainArea.Content = new ThicknessAdjustView();
            MainArea.Visibility = Visibility.Visible;
            ContentControl.Visibility= Visibility.Collapsed;
            FAPasueCL.Visibility = Visibility.Collapsed;
            ContentControlRight.Visibility = Visibility.Collapsed;

            switch (HO_Clicked)
            {
                case true:
                    HO_Clicked = true;
                    break;
                case false:
                    HO_Clicked = true;
                    break;
            }


        }

        private void FAPasueContinueBtn_Click(object sender, RoutedEventArgs e)
        {
            FAPasueCL.Visibility= Visibility.Collapsed;
            FAPasue.Visibility = Visibility.Visible;
        }


        private void IOcheck_Click(object sender, RoutedEventArgs e)
        {
        }

        private void IOPort_Click(object sender, RoutedEventArgs e)
        {
            Grid CTSGrid = new Grid();
            WindowsFormsHost host = new WindowsFormsHost();

            ((ISupportInitialize)(this.axActUtlType1)).BeginInit();
            host.Child = axActUtlType1;
            CTSGrid.Children.Add(host);
            ((ISupportInitialize)(this.axActUtlType1)).EndInit();

            axActUtlType1.ActLogicalStationNumber = 1;
            axActUtlType1.ActPassword = null;

            int iReturnCode = axActUtlType1.Open();

            if (iReturnCode == 0)
            {
                MessageBox.Show("连接成功");
                
            }
            else
            {
                MessageBox.Show("连接失败");
            }
        }

    }
 }
