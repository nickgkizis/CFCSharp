using System;
using System.IO;

namespace Notes
{
    internal class Program
    {
        static string filePath = Path.Combine(".", "notes.txt");


        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Simple Note Saver ===");
                Console.WriteLine("1. Add a Note");
                Console.WriteLine("2. View Notes");
                Console.WriteLine("3. Delete All Notes");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNote();
                        break;
                    case "2":
                        ViewNotes();
                        break;
                    case "3":
                        DeleteNotes();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye! 👋");
                        return;
                    default:
                        Console.WriteLine("⚠ Invalid choice! Try again.");
                        break;
                }
                Pause();
            }
        }

        /// <summary>
        /// Adds a new note to the file.
        /// </summary>
        static void AddNote()
        {
            Console.Write("\nWrite your note: ");
            string note = Console.ReadLine();
            File.AppendAllText(filePath, note + Environment.NewLine);
            Console.WriteLine("✅ Note saved!");
        }

        /// <summary>
        /// Reads and displays all notes.
        /// </summary>
        static void ViewNotes()
        {
            Console.WriteLine("\n📜 Saved Notes:");
            if (File.Exists(filePath))
            {
                string[] notes = File.ReadAllLines(filePath);
                if (notes.Length == 0)
                {
                    Console.WriteLine("⚠ No notes found.");
                }
                else
                {
                    for (int i = 0; i < notes.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {notes[i]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("⚠ No notes found.");
            }
        }

        /// <summary>
        /// Deletes all notes from the file.
        /// </summary>
        static void DeleteNotes()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("🗑 All notes deleted.");
            }
            else
            {
                Console.WriteLine("⚠ No notes to delete.");
            }
        }

        /// <summary>
        /// Pauses the console until the user presses a key.
        /// </summary>
        static void Pause()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
