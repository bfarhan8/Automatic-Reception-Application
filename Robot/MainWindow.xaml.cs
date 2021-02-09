using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Robot.Properties;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Robot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnglish_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.btnPageName = "E";
            Settings.Default.Save();

            var page2 = new PageTwo();
            page2.Show();
            Close();
        }

        private void btnArabic_Click(object sender, RoutedEventArgs e)
        {
            Settings.Default.btnPageName = "A";
            Settings.Default.Save();

            var page2 = new PageTwo();
            page2.Show();
            Close();
        }
    }
}
