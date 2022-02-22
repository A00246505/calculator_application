using System;

namespace calculator_library
{
    public class Calculator
    {
 
        public double multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
 
        public double division(double num1, double num2)
        {
            //check if divisor is 0
            if(num2 == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return num1 / num2;
            }
 
        }

        public double addition(double num1, double num2)
        {
            return num1 + num2;

        }

        public double subtraction(double num1, double num2)
        {
            return num1 - num2;

        }
    }
}
