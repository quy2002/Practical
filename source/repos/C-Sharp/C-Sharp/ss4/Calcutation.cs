using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp.ss4
{
    public delegate int Calculate(int a, int b);
    public class Calcutation
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Multi(int a, int b)
        {
            return a * b;
        }

        public static int Div(int a, int b)
        {
            return a / (b > 0 ? b : 1);
        }
    }
}
