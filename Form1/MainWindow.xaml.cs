using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
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
using System.Xml;

namespace Form1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
   
        double player = 0;

        public MainWindow()
        {
            InitializeComponent();
            button2.Click += button1_Click;
            button3.Click += button1_Click;
            button4.Click += button1_Click;
            button5.Click += button1_Click;
            button6.Click += button1_Click;
            button7.Click += button1_Click;
            button8.Click += button1_Click;
            button9.Click += button1_Click;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            int index = Convert.ToInt32(button.Name.Last().ToString());


            switch (player)
            {
                case 0:
                    button.Content = "x";
                    button.IsEnabled = false;
                    player = 1;
                    label1.Content = "Игрок : 2";
                    break;

                case 1:
                    button.Content = "o";
                    button.IsEnabled = false;
                    player = 0;
                    label1.Content = "Игрок : 1";
                    break;
            }
          
            CheckWinner();
        }
        

        private void CheckWinner()
        {
            
            if (button1.Content == button2.Content && button2.Content == button3.Content)
            {
                if(button1.Content != "")

                MessageBox.Show("Вы победили!");
            }
            if (button4.Content == button5.Content && button5.Content == button6.Content)
            {
                if (button4.Content != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button7.Content == button8.Content && button8.Content == button9.Content)
            {
                if (button7.Content != "")
                    MessageBox.Show("Вы победили!");
            }


            if (button1.Content == button4.Content && button4.Content == button7.Content)
            {
                if (button1.Content != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button2.Content == button5.Content && button5.Content == button8.Content)
            {
                if (button2.Content != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button3.Content == button6.Content && button6.Content == button9.Content)
            {
                if (button3.Content != "")
                    MessageBox.Show("Вы победили!");
            }

            if (button1.Content == button5.Content && button5.Content == button9.Content)
            {
                if (button1.Content != "")
                    MessageBox.Show("Вы победили!");
            }
            if (button3.Content == button5.Content && button5.Content == button7.Content)
            {
                if (button3.Content != "")
                    MessageBox.Show("Вы победили!");
            }
            



        }



        private void button10_Click(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;
            button10.Visibility = Visibility.Hidden;
            button11.Visibility = Visibility.Visible;
            button11. IsEnabled = true;
            button10.IsEnabled = false;
            label1.Content = "Игрок : 1";

        }





        private void Button11_Click(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = false;
            button2.IsEnabled = false;
            button3.IsEnabled = false;
            button4.IsEnabled = false;
            button5.IsEnabled = false;
            button6.IsEnabled = false;
            button7.IsEnabled = false;
            button8.IsEnabled = false;
            button9.IsEnabled = false;
            button10.Visibility = Visibility.Visible;
            button11.Visibility = Visibility.Hidden;
            button11.IsEnabled = false;
            button10.IsEnabled = true;

            button1.Content = "";
            button2.Content = "";
            button3.Content = "";
            button4.Content = "";
            button5.Content = "";
            button6.Content = "";
            button7.Content = "";
            button8.Content = "";
            button9.Content = "";

        }

    }
}