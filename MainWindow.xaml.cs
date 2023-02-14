using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace krenol1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int player = 0;
        private string smena = "O";
        private string krestik = "X";
        private string nolik = "O";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            
            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
            pobeda.Text = "";
            if (start.IsEnabled == true)
            {
            smena = krestik;
            krestik = nolik;
            nolik = smena;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 0:
                    sender.GetType().GetProperty("Content").SetValue(sender, nolik);
                    player = 1;
                    break;
                case 1:
                    sender.GetType().GetProperty("Content").SetValue(sender, krestik);
                    player = 0;
                    break;
            }
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            Win();
        }
        private void Win()
        {
            //строки
            if (button1.Content == "X" && button1.Content == button2.Content && button2.Content == button3.Content)
            {
                pobeda.Text = "Победили крестики";
                start.IsEnabled = true;
            }
            if (button4.Content == "X" && button4.Content == button5.Content && button5.Content == button6.Content)
            {
                pobeda.Text = "Победили крестики";
                start.IsEnabled = true;
            }
            if (button7.Content == "X" && button7.Content == button8.Content && button8.Content == button9.Content)
            {
                pobeda.Text = "Победили крестики";
                start.IsEnabled = true;
            }
            if (button1.Content == "O" && button1.Content == button2.Content && button2.Content == button3.Content)
            {
                pobeda.Text = "Победили нолики";
                start.IsEnabled = true;
            }
            if (button4.Content == "O" && button4.Content == button5.Content && button5.Content == button6.Content)
            {
                pobeda.Text = "Победили нолики";
                start.IsEnabled = true;
            }
            if (button7.Content == "O" && button7.Content == button8.Content && button8.Content == button9.Content)
            {
                pobeda.Text = "Победили нолики";
                start.IsEnabled = true;
            }
            //столбики
            if (button1.Content == "X" && button1.Content == button4.Content && button4.Content == button7.Content)
            {
                pobeda.Text = "Победили крестики";
                start.IsEnabled = true;
            }
            if (button2.Content == "X" && button2.Content == button5.Content && button5.Content == button8.Content)
            {
                pobeda.Text = "Победили крестики";
                start.IsEnabled = true;
            }
            if (button3.Content == "X" && button3.Content == button6.Content && button6.Content == button9.Content)
            {
                pobeda.Text = "Победили крестики";
                start.IsEnabled = true;
            }
            if (button1.Content == "O" && button1.Content == button4.Content && button4.Content == button7.Content)
            {
                pobeda.Text = "Победили нолики";
                start.IsEnabled = true;
            }
            if (button2.Content == "O" && button2.Content == button5.Content && button5.Content == button8.Content)
            {
                pobeda.Text = "Победили нолики";
                start.IsEnabled = true;
            }
            if (button3.Content == "O" && button3.Content == button6.Content && button6.Content == button9.Content)
            {
                pobeda.Text = "Победили нолики";
                start.IsEnabled = true;
            }
            //диагональ
            if (button1.Content == "X" && button1.Content == button5.Content && button5.Content == button9.Content)
            {
                pobeda.Text = "Победили крестики";
                start.IsEnabled = true;
            }
            if (button3.Content == "X" && button3.Content == button5.Content && button5.Content == button7.Content)
            {
                pobeda.Text = "Победили крестики";
                start.IsEnabled = true;
            }
            if (button1.Content == "O" && button1.Content == button5.Content && button5.Content == button9.Content)
            {
                pobeda.Text = "Победили нолики";
                start.IsEnabled = true;
            }
            if (button3.Content == "O" && button3.Content == button5.Content && button5.Content == button7.Content)
            {
                pobeda.Text = "Победили нолики";
                start.IsEnabled = true;
            }
            if (button1.IsEnabled == false && button2.IsEnabled == false && button3.IsEnabled == false && button4.IsEnabled == false && button5.IsEnabled == false && button6.IsEnabled == false && button7.IsEnabled == false && button8.IsEnabled == false && button9.IsEnabled == false)
            {
                pobeda.Text = "Ничья";
                start.IsEnabled = true;
            }
        }
    }
}
