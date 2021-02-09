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
    /// Interaction logic for PageFourA.xaml
    /// </summary>
    public partial class PageFourA : Window
    {
        public PageFourA()
        {
            InitializeComponent();

            if (Settings.Default.btnPageName == "E")
            {
                pgeHeader.Content = Settings.Default.pageFourAHead;
                btn1.Content = Settings.Default.pageFourAbtn1;
                btn2.Content = Settings.Default.pageFourAbtn2;
                btn3.Content = Settings.Default.pageFourAbtn3;
                btn4.Content = Settings.Default.pageFourAbtn4;

                
                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/HomeE.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/BackE.png"));

            }


            if (Settings.Default.btnPageName == "A")
            {
                pgeHeader.Content = Settings.Default.pageFourAHeadA;
                btn1.Content = Settings.Default.pageFourAbtn1A;
                btn2.Content = Settings.Default.pageFourAbtn2A;
                btn3.Content = Settings.Default.pageFourAbtn3A;
                btn4.Content = Settings.Default.pageFourAbtn4A;

                

                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Home.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Back.png"));
            }
            pgeHeader.FontSize = Settings.Default.pageFourHeadFont;
            btn1.FontSize = Settings.Default.pageFourAbtn1Font;
            btn2.FontSize = Settings.Default.pageFourAbtn2Font;
            btn3.FontSize = Settings.Default.pageFourAbtn3Font;
            btn4.FontSize = Settings.Default.pageFourAbtn4Font;

        }

        private void homeButton_TouchDown(object sender, TouchEventArgs e)
        {
            var mainPage = new MainWindow();
            mainPage.Show();
            Close();
        }

        private void homeButton_MouseDown(object sender, MouseButtonEventArgs e)
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
