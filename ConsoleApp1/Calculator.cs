public class Calculator
{
    // Method 1: void method
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // Method 2: Add() method
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Method 3: Multiply() with optional parameter
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}