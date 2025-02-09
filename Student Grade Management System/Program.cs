using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        
        Dictionary<string, int> students = new Dictionary<string, int>();

        while (true)
        {
            // Display menu
            Console.WriteLine("\nStudent Grade Management System");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search for a Student");
            Console.WriteLine("4. Calculate Average Grade");
            Console.WriteLine("5. Find Highest and Lowest Grades");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1") 
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();
                Console.Write("Enter student grade (0-100): ");
                try
                {
                    int grade = int.Parse(Console.ReadLine());
                    if (grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Grade must be between 0 and 100. Try again.");
                    }
                    else
                    {
                        students[name] = grade;
                        Console.WriteLine("Student added successfully!");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number for the grade.");
                }
            }
            else if (choice == "2") 
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No students found.");
                }
                else
                {
                    Console.WriteLine("\nList of Students:");
                    foreach (var student in students)
                    {
                        Console.WriteLine($"{student.Key}: {student.Value}");
                    }
                }
            }
            else if (choice == "3") 
            {
                Console.Write("Enter student name to search: ");
                string name = Console.ReadLine();
                if (students.ContainsKey(name))
                {
                    Console.WriteLine($"{name}'s grade is {students[name]}");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else if (choice == "4") 
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No students found.");
                }
                else
                {
                    double average = students.Values.Average();
                    Console.WriteLine($"Average grade is {average:F2}");
                }
            }
            else if (choice == "5") 
            {
                if (students.Count == 0)
                {
                    Console.WriteLine("No students found.");
                }
                else
                {
                    int highest = students.Values.Max();
                    int lowest = students.Values.Min();
                    Console.WriteLine($"Highest grade is {highest}, Lowest grade is {lowest}");
                }
            }
            else if (choice == "6") 
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                break;
            }
            else 
            {
                Console.WriteLine("Invalid option. Please choose a number from 1 to 6.");
            }
        }
    }
}