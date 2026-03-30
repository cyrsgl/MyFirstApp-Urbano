using System;

class Program
{
    static void Main(string[] args)
    {
        string? name;
        double grade;

        Console.Write("Enter student name: ");
        name = Console.ReadLine();

        Console.Write("Enter grade: ");
        grade = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Grade: " + grade);

        if (grade >= 75)
        {
            Console.WriteLine("Remarks: Passed");
        }
        else
        {
            Console.WriteLine("Remarks: Failed");
        }
    }
}