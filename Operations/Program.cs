using System;
using System.Linq;

namespace Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, -3, 7, -1, 9, 0, -6, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+ " ");
            }
            Console.WriteLine();
            Console.WriteLine("Positive Numbers: " + string.Join(", ", FindPositives(numbers)));
            Console.WriteLine("Negative Numbers: " + string.Join(", ", FindNegatives(numbers)));
            Console.WriteLine("Maximum: " + FindMax(numbers));
            Console.WriteLine("Minimum: " + FindMin(numbers));
            Console.WriteLine("Sum: " + CalculateSum(numbers));
            Console.WriteLine("Average: " + CalculateAverage(numbers));
        }

        static int[] FindPositives(int[] nums)
        {
            return nums.Where(n => n > 0).ToArray();
        }

        static int[] FindNegatives(int[] nums)
        {
            return nums.Where(n => n < 0).ToArray();
        }

        static int FindMax(int[] nums)
        {
            return nums.Max();
        }

        static int FindMin(int[] nums)
        {
            return nums.Min();
        }

        static int CalculateSum(int[] nums)
        {
            return nums.Sum();
        }

        static double CalculateAverage(int[] nums)
        {
            return nums.Average();
        }
    }
}