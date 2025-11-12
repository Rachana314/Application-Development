
using System;

namespace ConsoleApp1
{
    class AgeCategory
    {
        public static void Main(String[] args)
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 13)
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 20)
            {
                Console.WriteLine("Adult");
            }
            else
            {
                Console.WriteLine("Invalid age entered!");
            }
        }
    }
}
