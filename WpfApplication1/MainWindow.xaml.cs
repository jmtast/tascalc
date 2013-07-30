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
        private bool repeat = false;

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
            if (repeat)
            {
                // Repeat setup
                double firstRepeatOperand = operationBuffer.getFirstOperand();
                Operations lastOperator = operationBuffer.getOperation();
                double secondRepeatOperand = Convert.ToDouble(resultBlock.Text);

                operationBuffer.setOperation(new Repeat(lastOperator));

                double result = operationBuffer.Solve();
                writeMessage(Convert.ToString(result));
                operationBuffer.setFirstOperand(Convert.ToDouble(resultBlock.Text));
            }
            else
            {
                // Normal operation
                double secondOperand = Convert.ToDouble(resultBlock.Text);
                operationBuffer.setSecondOperand(secondOperand);
                try
                {
                    double result = operationBuffer.Solve();
                    writeMessage(Convert.ToString(result));
                    operationBuffer.setFirstOperand(Convert.ToDouble(resultBlock.Text));
                }
                catch (DivideByZeroException exception)
                {
                    writeMessage("Divided by zero");
                    operationBuffer.setFirstOperand(0);
                }   
            }
            cleanDisplay = true;
            repeat = true;
        }

        private void ClickNumber(String number)
        {
            if (cleanDisplay)
            {
                writeMessage(number);
                cleanDisplay = false;
                hasDot = false;
            }
            else
            {
                addCharacter(number);
            }
        }

        private void Click0(object sender, RoutedEventArgs e)
        {
            ClickNumber("0");
        }

        private void Click1(object sender, RoutedEventArgs e)
        {
            ClickNumber("1");
        }

        private void Click2(object sender, RoutedEventArgs e)
        {
            ClickNumber("2");
        }

        private void Click3(object sender, RoutedEventArgs e)
        {
            ClickNumber("3");
        }

        private void Click4(object sender, RoutedEventArgs e)
        {
            ClickNumber("4");
        }

        private void Click5(object sender, RoutedEventArgs e)
        {
            ClickNumber("5");
        }

        private void Click6(object sender, RoutedEventArgs e)
        {
            ClickNumber("6");
        }

        private void Click7(object sender, RoutedEventArgs e)
        {
            ClickNumber("7");
        }

        private void Click8(object sender, RoutedEventArgs e)
        {
            ClickNumber("8");
        }

        private void Click9(object sender, RoutedEventArgs e)
        {
            ClickNumber("9");
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
                repeat = false;
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
                repeat = false;
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
                repeat = false;
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
                repeat = false;
            }
        }

        private void ClickNegate(object sender, RoutedEventArgs e)
        {
            double firstOperand = Convert.ToDouble(resultBlock.Text);
            firstOperand = -firstOperand;
            operationBuffer.setFirstOperand(firstOperand);
            writeMessage(Convert.ToString(firstOperand));
        }

        private void ClickSquareRoot(object sender, RoutedEventArgs e)
        {
            if (!cleanDisplay)
            {
                double operand = Convert.ToDouble(resultBlock.Text);
                if (operand >= 0)
                {
                    operand = Math.Sqrt(operand);
                    operationBuffer.setFirstOperand(operand);
                    writeMessage(Convert.ToString(operand));
                }
                else
                {
                    writeMessage("Negative Sqrt");
                }
                cleanDisplay = true;
                repeat = false;
            }
        }

        private void ClickPercentage(object sender, RoutedEventArgs e)
        {
            if (!cleanDisplay)
            {
                double firstOperand = Convert.ToDouble(resultBlock.Text);
                operationBuffer.setFirstOperand(firstOperand);
                operationBuffer.setOperation(new Percentage());
                cleanDisplay = true;
                repeat = false;
            }
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
