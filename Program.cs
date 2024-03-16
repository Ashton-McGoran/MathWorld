using System;

namespace LambdaExpressionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            // Lambda expression to add the numbers
            Func<double, double, double> add = (x, y) => x + y;

            // Lambda expression to multiply the numbers
            Func<double, double, double> multiply = (x, y) => x * y;

            // Lambda statement to compare and return the smaller value
            Func<double, double, double> getSmaller = (x, y) =>
            {
                if (x < y)
                    return x;
                else
                    return y;
            };

            Console.WriteLine($"Sum of {number1} and {number2} is: {add(number1, number2)}");
            Console.WriteLine($"Product of {number1} and {number2} is: {multiply(number1, number2)}");
            Console.WriteLine($"Smaller value between {number1} and {number2} is: {getSmaller(number1, number2)}");
        }
    }
}
