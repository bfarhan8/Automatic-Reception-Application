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
    /// Interaction logic for PageFour.xaml
    /// </summary>
    public partial class PageFour : Window
    {
        public PageFour()
        {
            InitializeComponent();

            if (Settings.Default.btnPageName == "E")
            {
                pgeHeader.Content = Settings.Default.pageFourHead;

                btn1Text.Text = Settings.Default.pageFourbtn1;
                btn2Text.Text = Settings.Default.pageFourbtn2;
                btn3Text.Text = Settings.Default.pageFourbtn3;
                btn4Text.Text = Settings.Default.pageFourbtn4;
                btn5Text.Text = Settings.Default.pageFourbtn5;
                btn6Text.Text = Settings.Default.pageFourbtn6;
                btn7Text.Text = Settings.Default.pageFourbtn7;
                btn8Text.Text = Settings.Default.pageFourbtn8;

                pgeHeader.FontSize = Settings.Default.pageFourHeadFont;
                btn1Text.FontSize = Settings.Default.pageFourbtn1Font;
                btn2Text.FontSize = Settings.Default.pageFourbtn2Font;
                btn3Text.FontSize = Settings.Default.pageFourbtn3Font;
                btn4Text.FontSize = Settings.Default.pageFourbtn4Font;
                btn5Text.FontSize = Settings.Default.pageFourbtn5Font;
                btn6Text.FontSize = Settings.Default.pageFourbtn6Font;
                btn7Text.FontSize = Settings.Default.pageFourbtn7Font;
                btn8Text.FontSize = Settings.Default.pageFourbtn8Font;

                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/HomeE.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/BackE.png"));
            }

            if (Settings.Default.btnPageName == "A")
            {
                pgeHeader.Content = Settings.Default.pageFourHeadA;

                btn1Text.Text = Settings.Default.pageFourbtn1A;
                btn2Text.Text = Settings.Default.pageFourbtn2A;
                btn3Text.Text = Settings.Default.pageFourbtn3A;
                btn4Text.Text = Settings.Default.pageFourbtn4A;
                btn5Text.Text = Settings.Default.pageFourbtn5A;
                btn6Text.Text = Settings.Default.pageFourbtn6A;
                btn7Text.Text = Settings.Default.pageFourbtn7A;
                btn8Text.Text = Settings.Default.pageFourbtn8A;

                pgeHeader.FontSize = Settings.Default.pageFourHeadFont;
                btn1Text.FontSize = Settings.Default.pageFourbtn1Font;
                btn2Text.FontSize = Settings.Default.pageFourbtn2Font;
                btn3Text.FontSize = Settings.Default.pageFourbtn3Font;
                btn4Text.FontSize = Settings.Default.pageFourbtn4Font;
                btn5Text.FontSize = Settings.Default.pageFourbtn5Font;
                btn6Text.FontSize = Settings.Default.pageFourbtn6Font;
                btn7Text.FontSize = Settings.Default.pageFourbtn7Font;
                btn8Text.FontSize = Settings.Default.pageFourbtn8Font;

                homeButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Home.png"));
                backButton.Source = new BitmapImage(new Uri("pack://application:,,,/Robot;component/Resources/Back.png"));
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

        private void backButton_TouchDown(object sender, TouchEventArgs e)
        {
            var pageThree = new PageThree();
            pageThree.Show();
            Close();
        }

        private void backButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var pageThree = new PageThree();
            pageThree.Show();
            Close();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (Settings.Default.btnPageName == "E")
            { 
            var pageFourA = new PageFourA();
            pageFourA.Show();
            Close();
            }
            if (Settings.Default.btnPageName == "A")
            {
                var pageFourE = new PageFourE();
                pageFourE.Show();
                Close();
            }

        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Settings.Default.btnPageName == "E")
            {
                var pageFourB = new PageFourB();
                pageFourB.Show();
                Close();
            }
            if (Settings.Default.btnPageName == "A")
            {
                var pageFourF = new PageFourF();
                pageFourF.Show();
                Close();
            }

        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (Settings.Default.btnPageName == "E")
            {
                var pageFourC = new PageFourC();
                pageFourC.Show();
                Close();
            }
            if (Settings.Default.btnPageName == "A")
            {
                var pageFourG = new PageFourG();
                pageFourG.Show();
                Close();
            }
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (Settings.Default.btnPageName == "E")
            {
                var pageFourD = new PageFourD();
                pageFourD.Show();
                Close();
            }
            if (Settings.Default.btnPageName == "A")
            {
                var pageFourH = new PageFourH();
                pageFourH.Show();
                Close();
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Settings.Default.btnPageName == "E")
            {
                var pageFourE = new PageFourE();
                pageFourE.Show();
                Close();
            }
            if (Settings.Default.btnPageName == "A")
            {
                var pageFourA = new PageFourA();
                pageFourA.Show();
                Close();
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (Settings.Default.btnPageName == "E")
            {
                var pageFourF = new PageFourF();
                pageFourF.Show();
                Close();
            }
            if (Settings.Default.btnPageName == "A")
            {
                var pageFourB = new PageFourB();
                pageFourB.Show();
                Close();
            }
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (Settings.Default.btnPageName == "E")
            {
                var pageFourG = new PageFourG();
                pageFourG.Show();
                Close();
            }
            if (Settings.Default.btnPageName == "A")
            {
                var pageFourC = new PageFourC();
                pageFourC.Show();
                Close();
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (Settings.Default.btnPageName == "E")
            {
                var pageFourH = new PageFourH();
                pageFourH.Show();
                Close();
            }
            if (Settings.Default.btnPageName == "A")
            {
                var pageFourD = new PageFourD();
                pageFourD.Show();
                Close();
            }
        }
    }
}
