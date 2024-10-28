using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter student names separated by commas (e.g., Ali, Zahra, Kamran):");
        string input = Console.ReadLine();


        string[] students = input.Split(',').Select(name => name.Trim()).ToArray();

        Console.WriteLine("\nLength of each student's name:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student}: {student.Length}");
        }

        var repeatedNames = students.Where(name => students.Count(n => n == name) > 1).Distinct();

        Console.WriteLine("\nRepeated names:");
        foreach (var name in repeatedNames)
        {
            Console.WriteLine(name);
        }


        var uniqueNames = students.Distinct().Select(name => name.ToUpper());

        Console.WriteLine("\nUnique names in uppercase:");
        foreach (var name in uniqueNames)
        {
            Console.WriteLine(name);
        }
    }
}
