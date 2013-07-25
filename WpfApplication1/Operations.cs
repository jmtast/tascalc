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

        public abstract int operate(int a, int b);

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

        public override int operate(int a, int b)
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

        public override int operate(int a, int b)
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

        public override int operate(int a, int b)
        {
            return a * b;
        }
    }
}
