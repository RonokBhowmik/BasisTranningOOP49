using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public string Add(string firstNumber,string secondNumber)
        {
            if (firstNumber!=string.Empty && secondNumber!= string.Empty)
            {
                double number1 = double.Parse(firstNumber);
                double number2 = double.Parse(secondNumber);
                return (number1 + number2).ToString();   
            }
            else
            {
                return "Enter your Values first";
            }

        }

        public double Subtract(double firstNumber, double secondNumber)
        {
            return (firstNumber - secondNumber);
        }

        public double Multiply(double firstNumber, double secondNumber)
        {
            return (firstNumber * secondNumber);
        }

        public double Divide(double firstNumber, double secondNumber)
        {
            return (firstNumber / secondNumber);
        }


       
    }
}