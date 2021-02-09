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
    /// Interaction logic for PageTwo.xaml
    /// </summary>
    public partial class PageTwo : Window
    {
        public PageTwo()
        {
            InitializeComponent();

            //Set the details for label
            if (Settings.Default.btnPageName =="E" )
            {
               

                pgeHeader.Content = Settings.Default.pageTwoHead.ToString();
            pgeHeader.FontSize = Settings.Default.pageTwoHeadFont;
          
           
            //Set the details for Buttons

            btn1.Content = Settings.Default.pageTwobtn1.ToString();
            btn2.Content = Settings.Default.pageTwobtn2.ToString();

            btn1.FontSize = Settings.Default.pageTwobtn1Font;
            btn2.FontSize = Settings.Default.pageTwobtn2Font;
                btnHome.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/HomeE.png"));

            }
            if (Settings.Default.btnPageName == "A")
            {
            
                pgeHeader.Content = Settings.Default.pageTwoHeadA.ToString();
                pgeHeader.FontSize = Settings.Default.pageTwoHeadFontA;
              
                //Set the details for Buttons

                btn1.Content = Settings.Default.pageTwobtn1A.ToString();
                btn2.Content = Settings.Default.pageTwobtn2A.ToString();
              
                btn1.FontSize = Settings.Default.pageTwobtn1FontA;
                btn2.FontSize = Settings.Default.pageTwobtn2FontA;
                btnHome.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Home.png"));

            }

     
           

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

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            var pageThree = new PageThree();
            pageThree.Show();
            Close();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            var pageFour = new PageFour();
            pageFour.Show();
            Close();
        }
    }
}
