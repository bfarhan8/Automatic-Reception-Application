using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Robot.Properties;
namespace Robot
{
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Window
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void btnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
                var goBack = new PageFour();
                goBack.Show();
                Close();
            
        }

        private void btnBack_TouchDown(object sender, TouchEventArgs e)
        {
            var goBack = new PageFour();
            goBack.Show();
            Close();
        }
    }
}
