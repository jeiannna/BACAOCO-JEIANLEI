using System;
using System.Collections.Generic;

struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Program
{
    static void Main()
    {
        Queue<StudentRequest> requestQueue = new Queue<StudentRequest>();
        int choice;

        do
        {
            Console.WriteLine("\n========================");
            Console.WriteLine("STUDENT REQUEST QUEUE");
            Console.WriteLine("========================");
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Pending Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                StudentRequest req = new StudentRequest();
                Console.Write("Enter Student Number: ");
                req.StudentNumber = Console.ReadLine();
                Console.Write("Enter Student Name: ");
                req.StudentName = Console.ReadLine();
                Console.Write("Enter Request Type: ");
                req.RequestType = Console.ReadLine();
                requestQueue.Enqueue(req);
                Console.WriteLine("Request successfully added");
            }
            else if (choice == 2)
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No pending requests.");
                }
                else
                {
                    Console.WriteLine("\nREQUEST QUEUE");
                    int pos = 1;
                    foreach (StudentRequest r in requestQueue)
                    {
                        Console.WriteLine(pos + ". " + r.StudentName + " - " + r.RequestType);
                        pos++;
                    }
                }
            }
            else if (choice == 3)
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("No pending request");
                }
                else
                {
                    StudentRequest next = requestQueue.Dequeue();
                    Console.WriteLine("Processing Request: " + next.StudentName + " - " + next.RequestType);
                    Console.WriteLine("Request processed successfully!");
                }
            }
            else if (choice == 4)
            {
                Console.WriteLine("Program exited.");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

        } while (choice != 4);
    }
}
