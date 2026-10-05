using System;

struct Student
{
    public string StudentNumber, Name, Program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[10];
        int count = 0, choice;

        do
        {
            Console.Clear();
            Console.WriteLine("================================");
            Console.WriteLine("       STUDENT RECORD CENTER");
            Console.WriteLine("================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.WriteLine("================================");
            Console.Write("Enter choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (count == 10)
                    {
                        Console.WriteLine("Student limit reached.");
                        break;
                    }

                    Console.Write("\nEnter Student Number: ");
                    string number = Console.ReadLine();

                    if (Find(students, count, number) != -1)
                    {
                        Console.WriteLine("Student number already exists.");
                        break;
                    }

                    students[count].StudentNumber = number;
                    Console.Write("Enter Name: ");
                    students[count].Name = Console.ReadLine();
                    Console.Write("Enter Program: ");
                    students[count].Program = Console.ReadLine();
                    Console.Write("Enter Year Level: ");
                    students[count].YearLevel = Convert.ToInt32(Console.ReadLine());

                    count++;
                    Console.WriteLine("Student added successfully!");
                    break;

                case 2:
                    Console.WriteLine("\n STUDENT RECORDS ");

                    if (count == 0)
                        Console.WriteLine("No student records found.");
                    else
                        for (int i = 0; i < count; i++)
                            Show(students[i], i + 1);
                    break;

                case 3:
                    Console.Write("\nEnter Student Number to search: ");
                    int search = Find(students, count, Console.ReadLine());

                    if (search == -1)
                        Console.WriteLine("Student not found.");
                    else
                    {
                        Console.WriteLine("\nStudent Found!");
                        Show(students[search], search + 1);
                    }
                    break;

                case 4:
                    Console.Write("\nEnter Student Number to update: ");
                    int update = Find(students, count, Console.ReadLine());

                    if (update == -1)
                        Console.WriteLine("Student not found.");
                    else
                    {
                        Console.Write("Enter new Name: ");
                        students[update].Name = Console.ReadLine();
                        Console.Write("Enter new Program: ");
                        students[update].Program = Console.ReadLine();
                        Console.Write("Enter new Year Level: ");
                        students[update].YearLevel = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Student updated successfully!");
                    }
                    break;

                case 5:
                    Console.Write("\nEnter Student Number to delete: ");
                    int delete = Find(students, count, Console.ReadLine());

                    if (delete == -1)
                        Console.WriteLine("Student not found.");
                    else
                    {
                        for (int i = delete; i < count - 1; i++)
                            students[i] = students[i + 1];

                        count--;
                        Console.WriteLine("Student deleted successfully!");
                    }
                    break;

                case 6:
                    Console.WriteLine("\nProgram exited.");
                    break;

                default:
                    Console.WriteLine("\nInvalid choice.");
                    break;
            }

            if (choice != 6)
            {
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }

        } while (choice != 6);
    }

    static int Find(Student[] students, int count, string number)
    {
        for (int i = 0; i < count; i++)
            if (students[i].StudentNumber == number)
                return i;

        return -1;
    }

    static void Show(Student s, int number)
    {
        Console.WriteLine("\nStudent " + number);
        Console.WriteLine("Student Number: " + s.StudentNumber);
        Console.WriteLine("Name: " + s.Name);
        Console.WriteLine("Program: " + s.Program);
        Console.WriteLine("Year Level: " + s.YearLevel);
    }
}
