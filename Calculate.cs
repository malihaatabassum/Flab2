using System;
using System.Collections.Generic;
using System.Text;

namespace Flab2
{
    class Calculator : IBasicCalcu
    {
        public int Summation(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public int Subtraction(int a, int b)
        {
            int c = a - b;
            return c;
        }

       

        public int Multiplication(int a, int b)
        {
            int c = a * b;
            return c;
        }

        public int Division(int a, int b)
        {
            int c = a / b;
            return c;

        }

    }
}