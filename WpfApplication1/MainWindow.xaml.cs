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
        OperationBuffer operationBuffer = new OperationBuffer();
        private bool cleanDisplay = false;

        public MainWindow()
        {
            InitializeComponent();
            writeMessage("0");
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

        private void Solve(object sender, RoutedEventArgs e)
        {
            double secondOperand = Convert.ToDouble(resultBlock.Text);
            operationBuffer.setSecondOperand(secondOperand);
            try
                {
                    double result = operationBuffer.Solve();
                    resultBlock.Text = Convert.ToString(result);
                    operationBuffer.setFirstOperand(Convert.ToDouble(resultBlock.Text));
                }
            catch (DivideByZeroException exception)
                {
                    writeMessage("Divided by zero");
                    operationBuffer.setFirstOperand(0);
                }
            cleanDisplay = true;
        }

        private void Click0(object sender, RoutedEventArgs e)
        {
            if (cleanDisplay)
            {
                writeMessage("0");
                cleanDisplay = false;
                hasDot = false;
            }
            else
            {
                addCharacter("0");
            }
        }

        private void Click1(object sender, RoutedEventArgs e)
        {
            if (cleanDisplay)
            {
                writeMessage("1");
                cleanDisplay = false;
                hasDot = false;
            }
            else
            {
                addCharacter("1");
            }
        }

        private void Click2(object sender, RoutedEventArgs e)
        {
            if (cleanDisplay)
            {
                writeMessage("2");
                cleanDisplay = false;
                hasDot = false;
            }
            else
            {
                addCharacter("2");
            }
        }

        private void Click3(object sender, RoutedEventArgs e)
        {
            if (cleanDisplay)
            {
                writeMessage("3");
                cleanDisplay = false;
                hasDot = false;
            }
            else
            {
                addCharacter("3");
            }
        }

        private void Click4(object sender, RoutedEventArgs e)
        {
            if (cleanDisplay)
            {
                writeMessage("4");
                cleanDisplay = false;
                hasDot = false;
            }
            else
            {
                addCharacter("4");
            }
        }

        private void Click5(object sender, RoutedEventArgs e)
        {
            if (cleanDisplay)
            {
                writeMessage("5");
                cleanDisplay = false;
                hasDot = false;
            }
            else
            {
                addCharacter("5");
            }
        }

        private void Click6(object sender, RoutedEventArgs e)
        {
            if (cleanDisplay)
            {
                writeMessage("6");
                cleanDisplay = false;
                hasDot = false;
            }
            else
            {
                addCharacter("6");
            }
        }

        private void Click7(object sender, RoutedEventArgs e)
        {
            if (cleanDisplay)
            {
                writeMessage("7");
                cleanDisplay = false;
                hasDot = false;
            }
            else
            {
                addCharacter("7");
            }
        }

        private void Click8(object sender, RoutedEventArgs e)
        {
            if (cleanDisplay)
            {
                writeMessage("8");
                cleanDisplay = false;
                hasDot = false;
            }
            else
            {
                addCharacter("8");
            }
        }

        private void Click9(object sender, RoutedEventArgs e)
        {
            if (cleanDisplay)
            {
                writeMessage("9");
                cleanDisplay = false;
                hasDot = false;
            }
            else
            {
                addCharacter("9");
            }
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

        private void ClickSum(object sender, RoutedEventArgs e)
        {
            if (!cleanDisplay)
            {
                double firstOperand = Convert.ToDouble(resultBlock.Text);
                operationBuffer.setFirstOperand(firstOperand);
                operationBuffer.setOperation(new Sum());
                cleanDisplay = true;   
            }
        }

        private void ClickSubstract(object sender, RoutedEventArgs e)
        {
            if (!cleanDisplay)
            {
                double firstOperand = Convert.ToDouble(resultBlock.Text);
                operationBuffer.setFirstOperand(firstOperand);
                operationBuffer.setOperation(new Substract());
                cleanDisplay = true;
            }
        }

        private void ClickMultiply(object sender, RoutedEventArgs e)
        {
            if (!cleanDisplay)
            {
                double firstOperand = Convert.ToDouble(resultBlock.Text);
                operationBuffer.setFirstOperand(firstOperand);
                operationBuffer.setOperation(new Multiply());
                cleanDisplay = true;
            }
        }

        private void ClickDivide(object sender, RoutedEventArgs e)
        {
            if (!cleanDisplay)
            {
                double firstOperand = Convert.ToDouble(resultBlock.Text);
                operationBuffer.setFirstOperand(firstOperand);
                operationBuffer.setOperation(new Divide());
                cleanDisplay = true;
            }
        }

    }
}
