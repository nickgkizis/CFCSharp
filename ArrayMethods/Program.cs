using System;
using System.Linq;

namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 2, 8, 1, 9, 2, 5, 8, -3, -7, 4 };

            // Basic Methods
            Array.Sort(numbers);
            Console.WriteLine("Sorted: " + string.Join(", ", numbers));

            Array.Reverse(numbers);
            Console.WriteLine("Reversed: " + string.Join(", ", numbers));

            int search = 8;
            int index = Array.IndexOf(numbers, search);
            Console.WriteLine($"Index of {search}: {index}");

            int lastIndex = Array.LastIndexOf(numbers, search);
            Console.WriteLine($"Last index of {search}: {lastIndex}");

            bool exists = Array.Exists(numbers, n => n == 4);
            Console.WriteLine("Does 4 exist? " + exists);

            int firstEven = Array.Find(numbers, n => n % 2 == 0);
            Console.WriteLine("First even number: " + firstEven);

            int[] allEven = Array.FindAll(numbers, n => n % 2 == 0);
            Console.WriteLine("All even numbers: " + string.Join(", ", allEven));

            Array.Resize(ref numbers, numbers.Length + 2);
            numbers[numbers.Length - 2] = 99;
            numbers[numbers.Length - 1] = 100;
            Console.WriteLine("Resized Array: " + string.Join(", ", numbers));

            // LINQ Methods
            var positiveNumbers = numbers.Where(n => n > 0);
            Console.WriteLine("Positive Numbers: " + string.Join(", ", positiveNumbers));

            var doubledNumbers = numbers.Select(n => n * 2);
            Console.WriteLine("Doubled Numbers: " + string.Join(", ", doubledNumbers));

            var ascendingOrder = numbers.OrderBy(n => n);
            Console.WriteLine("Ascending Order: " + string.Join(", ", ascendingOrder));

            var descendingOrder = numbers.OrderByDescending(n => n);
            Console.WriteLine("Descending Order: " + string.Join(", ", descendingOrder));

            var uniqueNumbers = numbers.Distinct();
            Console.WriteLine("Unique Numbers: " + string.Join(", ", uniqueNumbers));

            var skippedTaken = numbers.Skip(2).Take(3);
            Console.WriteLine("Skip 2, Take 3: " + string.Join(", ", skippedTaken));
        }
    }
}
