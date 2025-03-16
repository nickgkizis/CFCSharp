using System;
using System.Threading;

namespace Strings
{
    /// <summary>
    /// My first program with extended console printing and string functions.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Advanced Console Printing & String Functions ===\n");

            // Basic printing
            PrintBasic();

            // Printing with colors
            PrintWithColors();

            // Formatted printing
            PrintFormatted();

            // Printing with typing effect
            PrintTypingEffect("This is a slow typing effect example...\n", 50);

            // ASCII Art Example
            PrintAsciiArt();

            // Exploring string functions
            ExploreStringFunctions("Hello, Coding Factory!");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Basic console printing methods.
        /// </summary>
        static void PrintBasic()
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Hello, Coding Factory\n");
            Console.WriteLine();
        }

        /// <summary>
        /// Prints text with different foreground colors.
        /// </summary>
        static void PrintWithColors()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("This text is in Cyan.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This text is in Green.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This text is in Red.");
            Console.ResetColor();
            Console.WriteLine("Back to normal color.");
        }

        /// <summary>
        /// Demonstrates formatted printing.
        /// </summary>
        static void PrintFormatted()
        {
            string name = "John";
            int age = 25;
            double height = 1.75;
            Console.WriteLine("\nFormatted Output:");
            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height:F2} meters");
            Console.WriteLine("Name: {0}, Age: {1}, Height: {2:F2} meters", name, age, height);
        }

        /// <summary>
        /// Prints text with a slow typing effect.
        /// </summary>
        static void PrintTypingEffect(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Prints a simple ASCII art.
        /// </summary>
        static void PrintAsciiArt()
        {
            Console.WriteLine(@"
              /\_/\
             ( o.o ) 
              > ^ <
            ");
        }

        /// <summary>
        /// Demonstrates various string operations.
        /// </summary>
        static void ExploreStringFunctions(string input)
        {
            Console.WriteLine("\n=== String Functions ===");
            Console.WriteLine($"Original: {input}");
            Console.WriteLine($"Uppercase: {input.ToUpper()}");
            Console.WriteLine($"Lowercase: {input.ToLower()}");
            Console.WriteLine($"Reversed: {ReverseString(input)}");
            Console.WriteLine($"Substring (7,6): {input.Substring(7, 6)}");
            Console.WriteLine($"Trimmed: '{input.Trim()}'");
            Console.WriteLine($"Replace 'Coding' with 'Programming': {input.Replace("Coding", "Programming")}");
            Console.WriteLine($"Concatenation: {string.Concat(input, " - Enjoy coding!")}");
            Console.WriteLine($"Contains 'Factory': {input.Contains("Factory")}");
        }

        /// <summary>
        /// Reverses a given string.
        /// </summary>
        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
