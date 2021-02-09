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
    /// Interaction logic for PageFourB.xaml
    /// </summary>
    public partial class PageFourB : Window
    {
        public PageFourB()
        {
            InitializeComponent();

            if (Settings.Default.btnPageName == "E")
            {
                pgeHeader.Content = Settings.Default.pageFourBHead;

                btn1.Content = Settings.Default.pageFourBbtn1;
                btn2.Content = Settings.Default.pageFourBbtn2;
                btn3.Content = Settings.Default.pageFourBbtn3;
                btn4.Content = Settings.Default.pageFourBbtn4;
                
                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/HomeE.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/BackE.png"));
            }
            if (Settings.Default.btnPageName == "A")
            {

                pgeHeader.Content = Settings.Default.pageFourBHeadA;

                btn1.Content = Settings.Default.pageFourBbtn1A;
                btn2.Content = Settings.Default.pageFourBbtn2A;
                btn3.Content = Settings.Default.pageFourBbtn3A;
                btn4.Content = Settings.Default.pageFourBbtn4A;

                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Home.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Back.png"));
}
            pgeHeader.FontSize = Settings.Default.pageFourBHeadFont;

            btn1.FontSize = Settings.Default.pageFourBbtn1Font;
            btn2.FontSize = Settings.Default.pageFourBbtn2Font;
            btn3.FontSize = Settings.Default.pageFourBbtn3Font;
            btn4.FontSize = Settings.Default.pageFourBbtn4Font;
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
