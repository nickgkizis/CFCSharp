using System;
using System.Globalization;
using System.Threading;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Advanced Console Printing & String Functions ===\n");

            // Basic printing
            PrintBasic();

            // Printing with colors
            PrintWithColors();

            // Formatted printing (and get user input)
            string name = PrintFormatted();

            // Printing with typing effect
            PrintTypingEffect($"Welcome {name}...\n", 50);

            // ASCII Art Example
            PrintAsciiArt();

            // Exploring string functions
            ExploreStringFunctions("Hello, Coding Factory!");

            // Enhanced printing
            PrintBanner("Enhanced Printing Methods");
            PrintCentered("This is a centered message.");
            PrintBoxedText("This is boxed text!");
            PrintTable();
            PrintBulletPoints(new string[] { "Item 1", "Item 2", "Item 3" });
            PrintNumberedList(new string[] { "First", "Second", "Third" });

            // Numeric formatting examples
            PrintBanner("Numeric Formatting");
            PrintFormattedNumbers();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // === YOUR ORIGINAL FUNCTIONS ===

        static void PrintBasic()
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Hello, Coding Factory\n");
            Console.WriteLine();
        }

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

        static string PrintFormatted()
        {
            Console.Write("What's your name? ");
            string name = Console.ReadLine();

            int age = 25;
            double height = 1.75;

            Console.WriteLine("\nFormatted Output:");
            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height:F2} meters");
            Console.WriteLine("Name: {0}, Age: {1}, Height: {2:F2} meters", name, age, height);

            return name;
        }

        static void PrintTypingEffect(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }

        static void PrintAsciiArt()
        {
            Console.WriteLine(@"
              /\_/\  
             ( o.o )  
              > ^ <  
            ");
        }

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
            Console.WriteLine($"Concatenation: {string.Concat(input, " - Enjoy coding!")} ");
            Console.WriteLine($"Contains 'Factory': {input.Contains("Factory")}");
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // === NEW FUNCTIONS ===

        static void PrintFormattedNumbers()
        {
            double number = 1234567.89123;
            double percentage = 0.9876;
            double money = 1234.56;

            Console.WriteLine("\n=== Number Formatting ===");
            Console.WriteLine($"Default: {number}");
            Console.WriteLine($"Rounded to 2 decimals: {number:F2}");
            Console.WriteLine($"With thousands separator: {number:N}");
            Console.WriteLine($"Currency (US): {money.ToString("C", new CultureInfo("en-US"))}");
            Console.WriteLine($"Currency (French): {money.ToString("C", new CultureInfo("fr-FR"))}");
            Console.WriteLine($"Currency (Japanese): {money.ToString("C", new CultureInfo("ja-JP"))}");
            Console.WriteLine($"Percentage: {percentage:P}");
        }

        static void PrintBanner(string title)
        {
            Console.WriteLine("\n" + new string('=', title.Length + 6));
            Console.WriteLine($"== {title} ==");
            Console.WriteLine(new string('=', title.Length + 6));
        }

        static void PrintCentered(string message)
        {
            int width = Console.WindowWidth;
            int leftPadding = (width - message.Length) / 2;
            Console.SetCursorPosition(Math.Max(leftPadding, 0), Console.CursorTop);
            Console.WriteLine(message);
        }

        static void PrintBoxedText(string text)
        {
            string border = new string('*', text.Length + 4);
            Console.WriteLine(border);
            Console.WriteLine($"* {text} *");
            Console.WriteLine(border);
        }

        static void PrintTable()
        {
            Console.WriteLine("\n=== Table Example ===");
            Console.WriteLine("{0,-10} | {1,10} | {2,10}", "Item", "Quantity", "Price");
            Console.WriteLine(new string('-', 35));
            Console.WriteLine("{0,-10} | {1,10} | {2,10:C}", "Apples", 5, 1.99);
            Console.WriteLine("{0,-10} | {1,10} | {2,10:C}", "Oranges", 10, 0.99);
            Console.WriteLine("{0,-10} | {1,10} | {2,10:C}", "Bananas", 7, 1.29);
        }

        static void PrintBulletPoints(string[] items)
        {
            Console.WriteLine("\n=== Bullet Points ===");
            foreach (var item in items)
            {
                Console.WriteLine($"• {item}");
            }
        }

        static void PrintNumberedList(string[] items)
        {
            Console.WriteLine("\n=== Numbered List ===");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i]}");
            }
        }
    }
}
