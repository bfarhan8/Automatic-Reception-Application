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
    /// Interaction logic for PageFourE.xaml
    /// </summary>
    public partial class PageFourE : Window
    {
        public PageFourE()
        {
            InitializeComponent();

            if (Settings.Default.btnPageName == "E")
            {
                pgeHeader.Content = Settings.Default.pageFourEHead;

                btn1.Content = Settings.Default.pageFourEbtn1;
                btn2.Content = Settings.Default.pageFourEbtn2;
                btn3.Content = Settings.Default.pageFourEbtn3;
                btn4.Content = Settings.Default.pageFourEbtn4;

                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/HomeE.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/BackE.png"));
            }
            if (Settings.Default.btnPageName == "A")
            {

                pgeHeader.Content = Settings.Default.pageFourEHeadA;

                btn1.Content = Settings.Default.pageFourEbtn1A;
                btn2.Content = Settings.Default.pageFourEbtn2A;
                btn3.Content = Settings.Default.pageFourEbtn3A;
                btn4.Content = Settings.Default.pageFourEbtn4A;


                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Home.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Back.png"));
            }
            pgeHeader.FontSize = Settings.Default.pageFourEHeadFont;

            btn1.FontSize = Settings.Default.pageFourEbtn1Font;
            btn2.FontSize = Settings.Default.pageFourEbtn2Font;
            btn3.FontSize = Settings.Default.pageFourEbtn3Font;
            btn4.FontSize = Settings.Default.pageFourEbtn4Font;

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
