using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_MethodOverloading_StephanieLopez
{
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }

        // Subtraction formula
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        // Multiplication formula
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }

        // Division formula
        public double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
        }
    }
}
