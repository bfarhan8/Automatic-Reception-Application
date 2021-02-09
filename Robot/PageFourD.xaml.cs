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
using System.Windows.Shapes;

namespace Robot
{
    /// <summary>
    /// Interaction logic for PageFourD.xaml
    /// </summary>
    public partial class PageFourD : Window
    {
        public PageFourD()
        {
            InitializeComponent();

            if (Settings.Default.btnPageName == "E")
            {
                btn3.Visibility = Visibility.Hidden;

                pgeHeader.Content = Settings.Default.pageFourDHead;

                btn1.Content = Settings.Default.pageFourDbtn1;
                btn2.Content = Settings.Default.pageFourDbtn2;


                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/HomeE.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/BackE.png"));

            }
            if (Settings.Default.btnPageName == "A")
            {
                btn3.Visibility = Visibility.Visible;
                pgeHeader.Content = Settings.Default.pageFourDHeadA;

                btn1.Content = Settings.Default.pageFourDbtn1A;
                btn2.Content = Settings.Default.pageFourDbtn2A;
                btn3.Content = Settings.Default.pageFourDbtn3A;

                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Home.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Back.png"));
            }
            pgeHeader.FontSize = Settings.Default.pageFourDHeadFont;

            btn1.FontSize = Settings.Default.pageFourDbtn1Font;
            btn2.FontSize = Settings.Default.pageFourDbtn2Font;
            btn3.FontSize = Settings.Default.pageFourDbtn3Font;
          

        }

        private void homeButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var mainPage = new MainWindow();
            mainPage.Show();
            Close();
        }

        private void homeButton_TouchDown(object sender, TouchEventArgs e)
        {
            var mainPage = new MainWindow();
            mainPage.Show();
            Close();
        }

        private void backButton_MouseDown(object sender, MouseButtonEventArgs e)
        {

            var pageFour = new PageFour();
            pageFour.Show();
            Close();
        }

        private void backButton_TouchDown(object sender, TouchEventArgs e)
        {

            var pageFour = new PageFour();
            pageFour.Show();
            Close();
        }
    }
}
