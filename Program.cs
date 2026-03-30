using System;

class Program
{
    static void Main(string[] args)
    {
        string? name;
        double grade;
        string letterGrade;

        Console.Write("Enter student name: ");
        name = Console.ReadLine();

        Console.Write("Enter grade: ");
        grade = Convert.ToDouble(Console.ReadLine());

        if (grade >= 90)
            letterGrade = "A";
        else if (grade >= 85)
            letterGrade = "B";
        else if (grade >= 80)
            letterGrade = "C";
        else if (grade >= 75)
            letterGrade = "D";
        else
            letterGrade = "F";

        Console.WriteLine("\n--- Result ---");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Grade: " + grade);
        Console.WriteLine("Letter Grade: " + letterGrade);

        if (grade >= 75)
            Console.WriteLine("Remarks: Passed");
        else
            Console.WriteLine("Remarks: Failed");
    }
}