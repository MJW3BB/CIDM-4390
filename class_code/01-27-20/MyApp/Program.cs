using System;
using MyLibrary;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            double x = Convert.ToDouble(Console.ReadLine()); // Convert user input to double and store it in the X variable
            Console.WriteLine("Enter a second number:");
            double y = Convert.ToDouble(Console.ReadLine()); // Convert user input and store in Y variable
            Console.WriteLine("Addition Result is {0}", MathRoutines.Add(x,y));
            Console.WriteLine("Subtract Result is {0}", MathRoutines.Subtract(x,y));
            Console.WriteLine("Multiplication Result is {0}", MathRoutines.Multiply(x,y));
            Console.WriteLine("Division Result is {0}", MathRoutines.Divide(x,y));
        }
    }
}
