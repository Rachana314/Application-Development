
using System;

namespace ConsoleApp1
{
    class Operators
    {
        // Method to add two numbers
        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum: {a + b}");
        }

        // Method to subtract two numbers
        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Difference: {a - b}");
        }

        // Method to multiply two numbers
        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Product: {a * b}");
        }

        // Method to divide two numbers
        public void Divide(int a, int b)
        {
            if (b != 0)
                Console.WriteLine($"Division Result: {(double)a / b}");
            else
                Console.WriteLine("Cannot divide by zero!");
        }

        // Method to check Odd or Even using Ternary Operator
        public void OddEvenFinder(int number)
        {
            string result = (number % 2 == 0) ? "Even Number" : "Odd Number";
            Console.WriteLine(result);
        }
    }
}

