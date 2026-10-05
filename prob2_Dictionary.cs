using System;
using System.Collections.Generic;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Dictionary<string, Student> studentDictionary =
            new Dictionary<string, Student>();

        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("       STUDENT LOOKUP CENTER");
            Console.WriteLine("======================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.WriteLine("======================================");

            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("\nEnter Student Number: ");
                    string studentNumber = Console.ReadLine();

                    if (studentDictionary.ContainsKey(studentNumber))
                    {
                        Console.WriteLine("Student number already exists.");
                    }
                    else
                    {
                        Student student = new Student();

                        student.StudentNumber = studentNumber;

                        Console.Write("Enter Name: ");
                        student.Name = Console.ReadLine();

                        Console.Write("Enter Program: ");
                        student.Program = Console.ReadLine();

                        Console.Write("Enter Year Level: ");
                        student.YearLevel =
                            Convert.ToInt32(Console.ReadLine());

                        studentDictionary.Add(studentNumber, student);

                        Console.WriteLine("\nStudent added successfully!");
                    }

                    break;

                case 2:
                    Console.Write("\nEnter Student Number to search: ");
                    string searchNumber = Console.ReadLine();

                    if (studentDictionary.ContainsKey(searchNumber))
                    {
                        Student foundStudent =
                            studentDictionary[searchNumber];

                        Console.WriteLine("\nStudent Found!");
                        Console.WriteLine("Student Number: " +
                            foundStudent.StudentNumber);
                        Console.WriteLine("Name: " +
                            foundStudent.Name);
                        Console.WriteLine("Program: " +
                            foundStudent.Program);
                        Console.WriteLine("Year Level: " +
                            foundStudent.YearLevel);
                    }
                    else
                    {
                        Console.WriteLine("Student number does not exist.");
                    }

                    break;

                case 3:
                    Console.WriteLine("\n======================================");
                    Console.WriteLine("           ALL STUDENTS");
                

                    if (studentDictionary.Count == 0)
                    {
                        Console.WriteLine("No student records found.");
                    }
                    else
                    {
                        foreach (KeyValuePair<string, Student> item
                            in studentDictionary)
                        {
                            Student student = item.Value;

                            Console.WriteLine("\nStudent Number: " +
                                student.StudentNumber);
                            Console.WriteLine("Name: " +
                                student.Name);
                            Console.WriteLine("Program: " +
                                student.Program);
                            Console.WriteLine("Year Level: " +
                                student.YearLevel);
                        
                        }
                    }

                    break;

                case 4:
                    Console.WriteLine("\nProgram exited.");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice.");
                    break;
            }

            if (choice != 4)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

        } while (choice != 4);
    }
}
}
