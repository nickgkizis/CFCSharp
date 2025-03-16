using System;
using System.Collections.Generic;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tasks = new List<string>();

            Console.WriteLine("=== To-Do List Simulator ===");
            while (true)
            {
                Console.WriteLine("\n1. Add Task  2. View Tasks  3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Enter new task: ");
                    tasks.Add(Console.ReadLine());
                }
                else if (choice == "2")
                {
                    Console.WriteLine("\nTasks:");
                    int i = 1;
                    foreach (var task in tasks)
                    {
                        Console.WriteLine($"({i}) - {task}");
                        i++; 
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option, try again.");
                }
            }
        }
    }
}
