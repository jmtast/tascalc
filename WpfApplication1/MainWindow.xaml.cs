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

        public abstract class Operations
        {
            public abstract int operate(int a, int b);
        }
        public class Sum : Operations
        {
            public String operation = "+";

            public override int operate(int a, int b)
            {
                return a + b;
            }

            public override String ToString()
            {
                return operation;
            }
        }

        public class Substraction : Operations
        {
            public String operation = "-";

            public override int operate(int a, int b)
            {
                return a - b;
            }

            public override String ToString()
            {
                return operation;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            operations.Items.Add(new Sum());
            operations.Items.Add(new Substraction());
            operations.SelectedItem = operations.Items[0];
        }

        private void operation_Click(object sender, RoutedEventArgs e, Operations operation)
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
                int result = operation.operate(a, b);
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
            //String operation = (String)operations.SelectedItem;
            operation_Click(this, null, (Operations)operations.SelectedItem);
        }

        private void invalidParameters()
        {
            resultBlock.Text = "Invalid parameters";
        }
    }

    
}
