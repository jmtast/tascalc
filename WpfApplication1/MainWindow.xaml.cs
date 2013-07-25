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
            operations.Items.Add("+");
            operations.Items.Add("-");
            operations.SelectedItem = operations.Items[0];
        }

        private void operation_Click(object sender, RoutedEventArgs e, String operation)
        {
            int a, b;
            bool emptyFields = false;
            if (numberA.Text != "")
            {
                a = Convert.ToInt32(numberA.Text);    
            }
            else
            {
                a = 0;
                emptyFields = true;
            }
            
            if (numberB.Text != "")
            {
                b = Convert.ToInt32(numberB.Text);    
            }
            else
            {
                b = 0;
                emptyFields = true;
            }
            if (emptyFields)
            {
                invalidParameters();
            }
            else
            {
                int result = 0;
                if (operation.Equals("+"))
                {
                    result = a + b;                    
                }
                else
                {
                    if (operation.Equals("-"))
                    {
                        result = a - b;
                    }
                }
                resultBlock.Text = Convert.ToString(result);
            }

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void operations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void doit_Click(object sender, RoutedEventArgs e)
        {
            String operation = (String)operations.SelectedItem;
            operation_Click(this, null, operation);
        }

        private void invalidParameters()
        {
            resultBlock.Text = "Invalid parameters";
        }
    }
}
