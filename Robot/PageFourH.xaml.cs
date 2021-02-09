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
    /// Interaction logic for PageFourH.xaml
    /// </summary>
    public partial class PageFourH : Window
    {
        public PageFourH()
        {
            InitializeComponent();

            if (Settings.Default.btnPageName == "E")
            {
                pgeHeader.Content = Settings.Default.pageFourHHead;

                btn1.Content = Settings.Default.pageFourHbtn1;
                btn2.Content = Settings.Default.pageFourHbtn2;
                btn3.Content = Settings.Default.pageFourHbtn3;
                btn4.Content = Settings.Default.pageFourHbtn4;


                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/HomeE.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/BackE.png"));
            }
            if (Settings.Default.btnPageName == "A")
            {

                pgeHeader.Content = Settings.Default.pageFourHHeadA;

                btn1.Content = Settings.Default.pageFourHbtn1A;
                btn2.Content = Settings.Default.pageFourHbtn2A;
                btn3.Content = Settings.Default.pageFourHbtn3A;
                btn4.Content = Settings.Default.pageFourHbtn4A;


                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Home.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Back.png"));
            }
            pgeHeader.FontSize = Settings.Default.pageFourHHeadFont;

            btn1.FontSize = Settings.Default.pageFourHbtn1Font;
            btn2.FontSize = Settings.Default.pageFourHbtn2Font;
            btn3.FontSize = Settings.Default.pageFourHbtn3Font;
            btn4.FontSize = Settings.Default.pageFourHbtn4Font;

        }

        private void homeButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var mainPage = new MainWindow();
            mainPage.Show();
            Close();
        }

        private void backButton_TouchDown(object sender, TouchEventArgs e)
        {
            var mainPage = new MainWindow();
            mainPage.Show();
            Close();
        }

        private void homeButton_TouchDown(object sender, TouchEventArgs e)
        {
            var pageFour = new PageFour();
            pageFour.Show();
            Close();
        }

        private void backButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var pageFour = new PageFour();
            pageFour.Show();
            Close();
        }
    }
}
