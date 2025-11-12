
using System;

namespace ConsoleApp1
{
    class LoopsExample
    {
        // Loops to calculate sum from 1 to N
        public void Main(String[] args)
        {
            Console.Write("Enter a number (N): ");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine($"Sum from 1 to {N} = {sum}");
        }

        //Loop to print numbers from 1 to 20
        public void PrintNumbersUsingWhile()
        {
            int i = 1;

            Console.WriteLine("\nNumbers from 1 to 20 (skip multiples of 4, stop at 15):");

            while (i <= 20)
            {
                if (i % 4 == 0)
                {
                    i++;
                    continue; // Skip multiples of 4
                }

                if (i == 15)
                {
                    Console.WriteLine("Reached 15 — stopping loop.");
                    break; // Stop when number is 15
                }

                Console.WriteLine(i);
                i++;
            }
        }

        // Loop to find sum of elements in an array
        public void SumUsingForEach()
        {
            int[] numbers = { 2, 4, 6, 8, 10 };
            int total = 0;

            foreach (int num in numbers)
            {
                total += num;
            }

            Console.WriteLine($"\nSum of array elements = {total}");
        }
    }
}
