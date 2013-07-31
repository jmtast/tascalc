using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    public abstract class Operations
    {
        public virtual String operations
        {
            get { return ""; }
        }

        public abstract double operate(double a, double b);

        public override String ToString()
        {
            return operations;
        }
    }

    public class Sum : Operations
    {
        public override String operations
        {
            get { return "+"; }
        }

        public override double operate(double a, double b)
        {
            return a + b;
        }
    }

    public class Substract : Operations
    {
        public override String operations
        {
            get { return "-"; }
        }

        public override double operate(double a, double b)
        {
            return a - b;
        }
    }

    public class Multiply : Operations
    {
        public override String operations
        {
            get { return "*"; }
        }

        public override double operate(double a, double b)
        {
            return a * b;
        }
    }

    public class Divide : Operations
    {
        public override String operations
        {
            get { return "/"; }
        }

        public override double operate(double a, double b)
        {
            if (b != 0)
            {
                return a / b;    
            }
            else
            {
                throw new DivideByZeroException("");
            }
        }
    }

    public class Repeat : Operations
    {
        Operations _operation = new Sum();

        public Repeat(Operations lastOperator)
        {
            _operation = lastOperator;
        }
        public override String operations
        {
            get { return "="; }
        }

        public override double operate(double a, double b)
        {
            return _operation.operate(a,b);
        }
    }

    public class Percentage : Operations
    {
        public override String operations
        {
            get { return "%"; }
        }

        public override double operate(double a, double b)
        {
            return (a * b)/100;
        }
    }

    public class OperationBuffer : Operations
    {
        private double firstOperand, secondOperand;
        private Operations operation;

        public OperationBuffer()
        {
            firstOperand = 0;
            secondOperand = 0;
            operation = new Sum();
        }

        public override double operate(double a, double b)
        {
            return 0;
        }

        internal double Solve()
        {
            firstOperand = operation.operate(firstOperand, secondOperand);
            setFirstOperand(firstOperand);
            return firstOperand;
        }

        internal void setFirstOperand(double operand)
        {
            firstOperand = operand;
        }

        internal double getFirstOperand()
        {
            return firstOperand;
        }

        internal void setSecondOperand(double operand)
        {
            secondOperand = operand;
        }

        internal void setOperation(Operations _operation)
        {
            operation = _operation;
        }
        
        internal Operations getOperation()
        {
            return operation;
        }
    }
}
