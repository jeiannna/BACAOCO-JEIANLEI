using System;
using System.Collections.Generic;

struct Operation
{
    public string Action, StudentNumber, StudentName;
}

class Program
{
    static void Main()
    {
        Stack<Operation> history = new Stack<Operation>();
        int choice;

        do
        {
            Console.WriteLine("\n===========================");
            Console.WriteLine("OPERATION HISTORY");
            Console.WriteLine("===========================");
            Console.WriteLine("1. Record Operation");
            Console.WriteLine("2. View Operation History");
            Console.WriteLine("3. View Last Operation");
            Console.WriteLine("4. Remove Last Operation");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Operation op = new Operation();
                Console.Write("Enter Action (Added/Updated/Deleted): ");
                op.Action = Console.ReadLine();
                Console.Write("Enter Student Number: ");
                op.StudentNumber = Console.ReadLine();
                Console.Write("Enter Student Name: ");
                op.StudentName = Console.ReadLine();
                history.Push(op);
                Console.WriteLine("Operation recorded.");
            }
            else if (choice == 2)
            {
                if (history.Count == 0)
                {
                    Console.WriteLine("No operations recorded.");
                }
                else
                {
                    Console.WriteLine("\nOPERATION HISTORY");
                    int num = 1;
                    foreach (var op in history)
                    {
                        Console.WriteLine(num + ". " + op.Action + " " + op.StudentName);
                        num++;
                    }
                }
            }
            else if (choice == 3)
            {
                if (history.Count == 0)
                {
                    Console.WriteLine("No operations recorded.");
                }
                else
                {
                    Operation last = history.Peek();
                    Console.WriteLine("Last Operation: " + last.Action + " " + last.StudentName);
                }
            }
            else if (choice == 4)
            {
                if (history.Count == 0)
                {
                    Console.WriteLine("No operations to remove.");
                }
                else
                {
                    history.Pop();
                    Console.WriteLine("Last operation removed successfully!");
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("Program exited.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

        } while (choice != 5);
    }
}
