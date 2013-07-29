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
        bool hasDot = false;

        public MainWindow()
        {
            InitializeComponent();
            operations.Items.Add(new Sum());
            operations.Items.Add(new Substract());
            operations.Items.Add(new Multiply());
            operations.Items.Add(new Divide());
            operations.SelectedItem = operations.Items[0];
            writeMessage("0");
        }

        private void operation_Click(object sender, RoutedEventArgs e, Operations operation)
        {
            double a, b;
            bool emptyFields = false;
            if (numberA.Text != "")
            {
                a = Convert.ToDouble(numberA.Text);    
            }
            else
            {
                a = 0;
                emptyFields = true;
            }
            
            if (numberB.Text != "")
            {
                b = Convert.ToDouble(numberB.Text);    
            }
            else
            {
                b = 0;
                emptyFields = true;
            }
            if (emptyFields)
            {
                writeMessage("A field is empty");
            }
            else
            {
                try
                {
                    double result = operation.operate(a, b);
                    resultBlock.Text = Convert.ToString(result);
                }
                catch (DivideByZeroException exception)
                {
                    writeMessage("Divided by zero");
                }
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

        private void writeMessage(String message)
        {
            resultBlock.Text = message;
        }

        private void addCharacter(String message)
        {
            if (resultBlock.Text.Equals("0") && !(message.Equals(".")))
            {
                writeMessage(message);
            }
            else
            {
                resultBlock.Text += message;
            }
        }

        private void doit_Click_1(object sender, RoutedEventArgs e)
        {
            operation_Click(this, null, (Operations)operations.SelectedItem);
        }

        private void Click0(object sender, RoutedEventArgs e)
        {
            addCharacter("0");
        }

        private void Click1(object sender, RoutedEventArgs e)
        {
            addCharacter("1");
        }

        private void Click2(object sender, RoutedEventArgs e)
        {
            addCharacter("2");
        }

        private void Click3(object sender, RoutedEventArgs e)
        {
            addCharacter("3");
        }

        private void Click4(object sender, RoutedEventArgs e)
        {
            addCharacter("4");
        }

        private void Click5(object sender, RoutedEventArgs e)
        {
            addCharacter("5");
        }

        private void Click6(object sender, RoutedEventArgs e)
        {
            addCharacter("6");
        }

        private void Click7(object sender, RoutedEventArgs e)
        {
            addCharacter("7");
        }

        private void Click8(object sender, RoutedEventArgs e)
        {
            addCharacter("8");
        }

        private void Click9(object sender, RoutedEventArgs e)
        {
            addCharacter("9");
        }

        private void ClickC(object sender, RoutedEventArgs e)
        {
            writeMessage("0");
            hasDot = false;
        }

        private void ClickDot(object sender, RoutedEventArgs e)
        {
            if (!hasDot)
            {
                hasDot = true;
                addCharacter(".");
            }
        }
    }
}
