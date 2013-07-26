using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    public abstract class Operations
    {
        public virtual String operation
        {
            get { return ""; }
        }

        public abstract double operate(double a, double b);

        public override String ToString()
        {
            return operation;
        }
    }

    public class Sum : Operations
    {
        public override String operation
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
        public override String operation
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
        public override String operation
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
        public override String operation
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
}
