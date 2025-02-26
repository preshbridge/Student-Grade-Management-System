using System;
using System.Collections.Generic;
using System.Linq;

class StudentGradeManagementSystem
{
    // Dictionary to store student names (keys) and their grades (values)
    static Dictionary<string, int> students = new Dictionary<string, int>();

    static void Main(string[] args)
    {
        // Main menu loop
        while (true)
        {
            DisplayMenu();
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    DisplayAllStudents();
                    break;
                case "3":
                    SearchStudent();
                    break;
                case "4":
                    CalculateAverageGrade();
                    break;
                case "5":
                    FindHighestAndLowestGrades();
                    break;
                case "6":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Display the main menu
    static void DisplayMenu()
    {
        Console.WriteLine("\n1. Add Student");
        Console.WriteLine("2. Display All Students");
        Console.WriteLine("3. Search for a Student");
        Console.WriteLine("4. Calculate Average Grade");
        Console.WriteLine("5. Find Highest and Lowest Grades");
        Console.WriteLine("6. Exit");
    }

    // Add a student to the dictionary
    static void AddStudent()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();

        Console.Write("Enter student grade: ");
        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            students[name] = grade; // Add or update the student's grade
            Console.WriteLine("Student added successfully!");
        }
        else
        {
            Console.WriteLine("Invalid grade input. Please enter a valid integer.");
        }
    }

    // Display all students and their grades
    static void DisplayAllStudents()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        Console.WriteLine("\nStudents and their grades:");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Key}: {student.Value}");
        }
    }

    // Search for a student by name
    static void SearchStudent()
    {
        Console.Write("Enter student name to search: ");
        string name = Console.ReadLine();

        if (students.ContainsKey(name))
        {
            Console.WriteLine($"{name}'s grade is {students[name]}.");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
    }

    // Calculate the average grade of all students
    static void CalculateAverageGrade()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found to calculate average.");
            return;
        }

        double average = students.Values.Average();
        Console.WriteLine($"The average grade is: {average:F2}");
    }

    // Find the highest and lowest grades
    static void FindHighestAndLowestGrades()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        int highestGrade = students.Values.Max();
        int lowestGrade = students.Values.Min();

        Console.WriteLine($"Highest grade: {highestGrade}");
        Console.WriteLine($"Lowest grade: {lowestGrade}");
    }
}
