using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, RoutedEventArgs e)
        {
            int a, b;
            if (numberA.Text != "")
            {
                a = Convert.ToInt32(numberA.Text);    
            }
            else
            {
                a = 0;
            }
            
            if (numberB.Text != "")
            {
                b = Convert.ToInt32(numberB.Text);    
            }
            else
            {
                b = 0;
            }
            int result = a + b;
            resultBlock.Text = Convert.ToString(result);
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
