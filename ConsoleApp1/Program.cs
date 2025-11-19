﻿using System;

class Program
{
    static void Main(string[] args)
    {
        //Task 1
        Student s1 = new Student("Rachana", 20, "Computing");
        Student s2 = new Student("Joe", 22, "Networking");

        Console.WriteLine("Student 1:");
        Console.WriteLine(s1.name);
        Console.WriteLine(s1.age);
        Console.WriteLine(s1.course);

        Console.WriteLine();

        Console.WriteLine("Student 2:");
        Console.WriteLine(s2.name);
        Console.WriteLine(s2.age);
        Console.WriteLine(s2.course);

        Console.WriteLine();

        Console.WriteLine("College: " + Student.collegeName);

        // Task 2
        Calculator calc = new Calculator();

        // Calling methods
        calc.PrintWelcome();

        int sum = calc.Add(10, 20);
        int product1 = calc.Multiply(5, 4);  
        int product2 = calc.Multiply(7);     

        // Printing results
        Console.WriteLine("Addition: " + sum);
        Console.WriteLine("Multiplication (5 * 4): " + product1);
        Console.WriteLine("Multiplication with default (7 * 1): " + product2);

        //Task 3
        ParameterDemo demo = new ParameterDemo();

        // Calling Increase (ref)
        int value = 5;
        demo.Increase(ref value);
        Console.WriteLine("Value after Increase: " + value);

        // Calling GetFullName (out)
        string fullName;
        demo.GetFullName(out fullName);
        Console.WriteLine("Full Name: " + fullName);

        // Calling SumAll (params)
        int total = demo.SumAll(10, 20, 30, 40);
        Console.WriteLine("Sum of all numbers: " + total);

        //Task 4
        // Object 1 using default constructor
        Player p1 = new Player();
        Console.WriteLine("Default Constructor Object:");
        Console.WriteLine("Name: " + p1.playerName);
        Console.WriteLine("Level: " + p1.level);
        Console.WriteLine("Health: " + p1.health);

        Console.WriteLine();

        // Object 2 using parameterized constructor
        Player p2 = new Player("Rachana", 5, 100);
        Console.WriteLine("Parameterized Constructor Object:");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);


        //Task 5
        // -------------------------------

        // Part 1: Enum DayType (Weekend / Weekday)
  

        Console.Write("Enter a day: ");
        string day = Console.ReadLine()!; // Null-forgiving operator avoids warning

        // Convert input to lowercase for comparison
        string lowerDay = day.ToLower();
        DayType type;

        if (lowerDay == "friday" || lowerDay == "saturday")
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }

        Console.WriteLine("It is: " + type);
        Console.WriteLine();

        // Part 2: Book Record
        // -------------------------------

        // First book object
        Book book1 = new Book("C# Basics", "John Doe", 499.99);

        // Second book using 'with' expression (change title and price)
        Book book2 = book1 with
        {
            title = "Advanced C#",
            price = 799.50
        };

        // Print first book object
        Console.WriteLine("Book 1 Details:");
        Console.WriteLine($"Title: {book1.title}, Author: {book1.author}, Price: {book1.price}");
        Console.WriteLine();

        // Deconstruct second book object
        var (title2, author2, price2) = book2;

        Console.WriteLine("Book 2 (Deconstructed):");
        Console.WriteLine($"Title: {title2}, Author: {author2}, Price: {price2}");

        //Task 6

        // Ask for marks
        Console.Write("Enter marks obtained: ");
        string marksInput = Console.ReadLine();
        bool isMarksValid = int.TryParse(marksInput, out int marks);

        // Ask for total
        Console.Write("Enter total marks: ");
        string totalInput = Console.ReadLine();
        bool isTotalValid = int.TryParse(totalInput, out int totalMarks);

        // Validate inputs
        if (!isMarksValid || !isTotalValid || total == 0)
        {
            Console.WriteLine("Invalid input! Please enter valid integers and total > 0.");
            return;
        }

        // ---------------- Breakpoint 1 ----------------
        // Before calculation
        double percentage = marks / total * 100; // This is the source of error

        // ---------------- Breakpoint 2 ----------------
        // After calculation
        Console.WriteLine("Percentage: " + percentage + "%");
        
        //---------------- 
        //Corrected program 
        Console.Write("Enter marks obtained: ");
        int.TryParse(Console.ReadLine(), out int mark);

        Console.Write("Enter total marks: ");
        int.TryParse(Console.ReadLine(), out int MarksObtained);

        if (total == 0)
        {
            Console.WriteLine("Total marks cannot be zero.");
            return;
        }

        // Corrected calculation
        double percent = (double)marks / total * 100;

        Console.WriteLine("Percentage: " + percentage + "%");
    }
}