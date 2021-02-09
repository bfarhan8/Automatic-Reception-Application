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
    /// Interaction logic for PageThree.xaml
    /// </summary>
    public partial class PageThree : Window
    {
        public PageThree()
        {
            InitializeComponent();
            if (Settings.Default.btnPageName == "E")
            {
                //Set the content for the Elements in this page.

                pgeHeader.Content = Settings.Default.pageThreeHead;
                btn1.Content = Settings.Default.pageThreebtn1;
                btn2.Content = Settings.Default.pageThreebtn2;
                btn3.Content = Settings.Default.pageThreebtn3;
                btn4.Content = Settings.Default.pageThreebtn4;

                //Set the Font Size

                pgeHeader.FontSize = Settings.Default.pageThreeHeadFont;
                btn1.FontSize = Settings.Default.pageThreebtn1Font;
                btn2.FontSize = Settings.Default.pageThreebtn2Font;
                btn3.FontSize = Settings.Default.pageThreebtn3Font;
                btn4.FontSize = Settings.Default.pageThreebtn4Font;

                pgeHeader.HorizontalAlignment = HorizontalAlignment.Center;
                btnHome.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/HomeE.png"));
                btnBack.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/BackE.png"));
            }
            if(Settings.Default.btnPageName == "A")
            {
                   //Set the content for the Elements in this page.

                    pgeHeader.Content = Settings.Default.pageThreeHeadA;
                    btn1.Content = Settings.Default.pageThreebtn1A;
                    btn2.Content = Settings.Default.pageThreebtn2A;
                    btn3.Content = Settings.Default.pageThreebtn3A;
                    btn4.Content = Settings.Default.pageThreebtn4A;

                    //Set the Font Size

                    pgeHeader.FontSize = Settings.Default.pageThreeHeadFont;
                    btn1.FontSize = Settings.Default.pageThreebtn1Font;
                    btn2.FontSize = Settings.Default.pageThreebtn2Font;
                    btn3.FontSize = Settings.Default.pageThreebtn3Font;
                    btn4.FontSize = Settings.Default.pageThreebtn4Font;

                    pgeHeader.HorizontalAlignment = HorizontalAlignment.Center;

                btnHome.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Home.png"));
                btnBack.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Back.png"));
            }
            

        }

        private void btnBack_TouchDown(object sender, TouchEventArgs e)
        {
            var pageTwo = new PageTwo();
            pageTwo.Show();
            Close();
        }

        private void btnHome_TouchDown(object sender, TouchEventArgs e)
        {
            var mainPage = new MainWindow();
            mainPage.Show();
            Close();
        }

        private void btnHome_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var mainPage = new MainWindow();
            mainPage.Show();
            Close();
        }

        private void btnBack_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var pageTwo = new PageTwo();
            pageTwo.Show();
            Close();
        }
    }
}
