using System;
using System.Numerics;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 10;
            double x = 5.7;
            double y = -3.2;

            Console.WriteLine("Hello, maths!");

            // Basic Arithmetic Operations
            Console.WriteLine($"Addition: {a} + {b} = {AddTwo(a, b)}");
            Console.WriteLine($"Subtraction: {a} - {b} = {SubtractTwo(a, b)}");
            Console.WriteLine($"Multiplication: {a} * {b} = {MultiplyTwo(a, b)}");
            Console.WriteLine($"Division: {b} / {a} = {DivideTwo(b, a)}");
            Console.WriteLine($"Modulus: {b} % {a} = {b % a}");

            // Power, Square Root, Logarithm
            Console.WriteLine($"Power: {a}^2 = {Math.Pow(a, 2)}");
            Console.WriteLine($"Square Root: sqrt({b}) = {Math.Sqrt(b)}");
            Console.WriteLine($"Natural Log (ln): ln({b}) = {Math.Log(b)}");
            Console.WriteLine($"Base-10 Log: log10({b}) = {Math.Log10(b)}");
            Console.WriteLine($"Exponential: e^{a} = {Math.Exp(a)}");

            // Trigonometric Functions (Radians)
            Console.WriteLine($"Sin({x}) = {Math.Sin(x)}");
            Console.WriteLine($"Cos({x}) = {Math.Cos(x)}");
            Console.WriteLine($"Tan({x}) = {Math.Tan(x)}");
            Console.WriteLine($"Arcsin(0.5) = {Math.Asin(0.5)}");
            Console.WriteLine($"Arccos(0.5) = {Math.Acos(0.5)}");
            Console.WriteLine($"Arctan(1) = {Math.Atan(1)}");

            // Absolute Values & Rounding
            Console.WriteLine($"Absolute Value of {y}: {Math.Abs(y)}");
            Console.WriteLine($"Ceiling of {x}: {Math.Ceiling(x)}");
            Console.WriteLine($"Floor of {x}: {Math.Floor(x)}");
            Console.WriteLine($"Round {x}: {Math.Round(x)}");
            Console.WriteLine($"Truncate {x}: {Math.Truncate(x)}");

            // Min and Max
            Console.WriteLine($"Max({a}, {b}) = {Math.Max(a, b)}");
            Console.WriteLine($"Min({a}, {b}) = {Math.Min(a, b)}");

            // Handling Large Numbers with BigInteger
            BigInteger bigNum1 = BigInteger.Pow(10, 30);
            BigInteger bigNum2 = BigInteger.Pow(10, 20);
            Console.WriteLine($"BigInteger Addition: {bigNum1} + {bigNum2} = {BigInteger.Add(bigNum1, bigNum2)}");
            Console.WriteLine($"BigInteger Multiplication: {bigNum1} * {bigNum2} = {BigInteger.Multiply(bigNum1, bigNum2)}");

            // Random Number Generation
            Random rand = new Random();
            Console.WriteLine($"Random number between 1 and 100: {rand.Next(1, 101)}");
        }

        public static int AddTwo(int a, int b) => a + b;
        public static int SubtractTwo(int a, int b) => a - b;
        public static int MultiplyTwo(int a, int b) => a * b;
        public static double DivideTwo(double a, double b) => a / b;
    }
}
