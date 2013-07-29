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

    public class OperationBuffer : Operations
    {
        private double firstOperand, secondOperand;
        private Operations operation;

        public override double operate(double a, double b)
        {
            return 0;
        }

        internal double Solve()
        {
            return operation.operate(firstOperand, secondOperand);
        }

        internal void setFirstOperand(double operand)
        {
            firstOperand = operand;
        }

        internal void setSecondOperand(double operand)
        {
            secondOperand = operand;
        }

        internal void setOperation(Operations _operation)
        {
            operation = _operation;
        }
    }
}
