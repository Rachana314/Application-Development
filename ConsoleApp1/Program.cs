using System;
using System.Collections.Generic;

namespace ConsoleTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
        }

        static void Task1()
        {
            string userName = "Rachana Khatri";
            int luckyNumber = 3;
            Console.WriteLine($"My name is: {userName}");
            Console.WriteLine($"My lucky number is: {luckyNumber}");
            Console.WriteLine($"Hello {userName}! your lucky number is {luckyNumber}");
            Console.WriteLine();
        }

        static void Task2()
        {
            const double PI = 3.14;
            Console.WriteLine($"Constant value of PI: {PI}");
            Console.WriteLine();
        }

        static void Task3()
        {
            byte byteValue = 10;
            short shortValue = 200;
            int intValue = 1000;
            long longValue = 50000L;
            float floatValue = 3.14f;
            double doubleValue = 6.28;
            decimal decimalValue = 9.99m;
            char charValue = 'A';
            bool boolValue = true;

            string intToString = intValue.ToString();
            string numberString = "3.14";
            double stringToDouble = Convert.ToDouble(numberString);

            Console.WriteLine($"byte: {byteValue}");
            Console.WriteLine($"short: {shortValue}");
            Console.WriteLine($"int: {intValue}");
            Console.WriteLine($"long: {longValue}");
            Console.WriteLine($"float: {floatValue}");
            Console.WriteLine($"double: {doubleValue}");
            Console.WriteLine($"decimal: {decimalValue}");
            Console.WriteLine($"char: {charValue}");
            Console.WriteLine($"bool: {boolValue}");
            Console.WriteLine($"Converted int to string: {intToString}");
            Console.WriteLine($"Converted string to double: {stringToDouble}");
            Console.WriteLine();
        }

        static void Task4()
        {
            int[] favoriteNumbers = { 7, 3, 9, 1, 5 };
            Array.Sort(favoriteNumbers);

            Console.WriteLine("Array after sorting (ascending):");
            for (int i = 0; i < favoriteNumbers.Length; i++)
                Console.Write(favoriteNumbers[i] + " ");

            Console.WriteLine("\n");

            Array.Reverse(favoriteNumbers);
            Console.WriteLine("Array after reversing (descending):");
            for (int i = 0; i < favoriteNumbers.Length; i++)
                Console.Write(favoriteNumbers[i] + " ");

            Console.WriteLine("\n");

            int specificNumber = 5;
            int position = Array.IndexOf(favoriteNumbers, specificNumber);

            if (position != -1)
                Console.WriteLine($"The number {specificNumber} is found at index position: {position}");
            else
                Console.WriteLine($"The number {specificNumber} is not found in the array.");

            Console.WriteLine();
        }

        static void Task5()
        {
            DateTime birthDate = new DateTime(2004, 6, 15);
            DateTime currentDate = DateTime.Now;
            TimeSpan ageSpan = currentDate - birthDate;
            int ageInYears = (int)(ageSpan.TotalDays / 365.25);

            Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Age: {ageInYears} years");

            DateTime newDate = birthDate.AddDays(10);
            Console.WriteLine($"Date after adding 10 days: {newDate.ToShortDateString()}");
            Console.WriteLine();
        }

        static void Task6()
        {
            List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };
            fruits.Add("Orange");
            fruits.Remove("Apple");

            Console.WriteLine("List of Fruits:");
            foreach (string fruit in fruits)
                Console.WriteLine($"- {fruit}");

            Console.WriteLine();

            Dictionary<int, string> fruitDictionary = new Dictionary<int, string>()
            {
                { 1, "Mango" },
                { 2, "Banana" },
                { 3, "Orange" }
            };

            fruitDictionary.Add(4, "Pineapple");

            Console.WriteLine("Fruit Dictionary:");
            foreach (KeyValuePair<int, string> kvp in fruitDictionary)
                Console.WriteLine($"ID: {kvp.Key}, Fruit: {kvp.Value}");

            Console.WriteLine();
        }
    }
}