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
    /// Interaction logic for PageFourF.xaml
    /// </summary>
    public partial class PageFourF : Window
    {
        public PageFourF()
        {
            InitializeComponent();

            if (Settings.Default.btnPageName == "E")
            {
                pgeHeader.Content = Settings.Default.pageFourFHead;

                btn1.Content = Settings.Default.pageFourFbtn1;
                btn2.Content = Settings.Default.pageFourFbtn2;
                btn3.Content = Settings.Default.pageFourFbtn3;
                btn4.Content = Settings.Default.pageFourFbtn4;
                btn5.Content = Settings.Default.pageFourFbtn5;


                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/HomeE.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/BackE.png"));
            }
            if (Settings.Default.btnPageName == "A")
            {

                pgeHeader.Content = Settings.Default.pageFourFHeadA;

                btn1.Content = Settings.Default.pageFourFbtn1A;
                btn2.Content = Settings.Default.pageFourFbtn2A;
                btn3.Content = Settings.Default.pageFourFbtn3A;
                btn4.Content = Settings.Default.pageFourFbtn4A;
                btn5.Content = Settings.Default.pageFourFbtn5A;


                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Home.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Back.png"));
            }
            pgeHeader.FontSize = Settings.Default.pageFourFHeadFont;

            btn1.FontSize = Settings.Default.pageFourFbtn1Font;
            btn2.FontSize = Settings.Default.pageFourFbtn2Font;
            btn3.FontSize = Settings.Default.pageFourFbtn3Font;
            btn4.FontSize = Settings.Default.pageFourFbtn4Font;
            btn5.FontSize = Settings.Default.pageFourFbtn5Font;

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
