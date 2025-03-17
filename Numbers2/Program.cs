using System;
using System.Numerics;

namespace Numbers2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Fibonacci sequence
            Console.WriteLine("Fibonacci Sequence:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

            // Factorial sequence
            Console.WriteLine("\nFactorial Sequence:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{i,3}! = {Factorial(i):N0}");
            }

            // Arithmetic Progression (with start=1, diff=3)
            Console.WriteLine("\nArithmetic Progression (Start = 1, Difference = 3):");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(ArithmeticProgression(i, 1, 3));
            }

            // Geometric Progression (with start=1, ratio=2)
            Console.WriteLine("\nGeometric Progression (Start = 1, Ratio = 2):");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(GeometricProgression(i, 1, 2)); 
            }

            // Custom Progression (e.g., n^2)
            Console.WriteLine("\nCustom Progression (n^2):");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(CustomProgression(i)); // n^2
            }

            // Triangular Numbers
            Console.WriteLine("\nTriangular Numbers:");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(TriangularNumber(i));
            }

            // Perfect Squares
            Console.WriteLine("\nPerfect Squares:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(PerfectSquare(i));
            }

            // Prime Numbers
            Console.WriteLine("\nPrime Numbers:");
            int count = 0;
            int num = 2;
            while (count < 20)
            {
                if (IsPrime(num))
                {
                    Console.WriteLine(num);
                    count++;
                }
                num++;
            }

            // Lucas Sequence
            Console.WriteLine("\nLucas Sequence:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(LucasSequence(i));
            }

            // Harmonic Sequence (first 10 numbers)
            Console.WriteLine("\nHarmonic Sequence:");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(HarmonicSequence(i));
            }

            // Catalan Numbers
            Console.WriteLine("\nCatalan Numbers:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(CatalanNumber(i));
            }

            // Tetranacci Sequence
            Console.WriteLine("\nTetranacci Sequence:");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(Tetranacci(i));
            }

            // Displaying Pi (π)
            Console.WriteLine("\nValue of Pi:");
            Console.WriteLine($"Pi to 20 decimal places: {Math.PI:F20}");
        }

        // Fibonacci sequence: F(n) = F(n-1) + F(n-2)
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        // Factorial: n! = n * (n-1) * (n-2) * ... * 1
        public static BigInteger Factorial(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Arithmetic Progression: a_n = a_1 + (n-1) * d
        public static int ArithmeticProgression(int n, int start, int difference)
        {
            return start + n * difference;
        }

        // Geometric Progression: a_n = a_1 * r^(n-1)
        public static int GeometricProgression(int n, int start, int ratio)
        {
            return start * (int)Math.Pow(ratio, n);
        }

        // Custom Progression: n^2 
        public static int CustomProgression(int n)
        {
            return n * n; // Squared values
        }

        // Triangular Numbers: T_n = n * (n + 1) / 2
        public static int TriangularNumber(int n)
        {
            return n * (n + 1) / 2;
        }

        // Perfect Squares: n^2
        public static int PerfectSquare(int n)
        {
            return n * n;
        }

        // Prime Numbers
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        // Lucas Sequence: L(n) = L(n-1) + L(n-2), L(0) = 2, L(1) = 1
        public static int LucasSequence(int n)
        {
            if (n == 0) return 2;
            if (n == 1) return 1;
            int a = 2, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        // Harmonic Sequence: H(n) = 1 + 1/2 + 1/3 + ... + 1/n
        public static double HarmonicSequence(int n)
        {
            double harmonicSum = 0;
            for (int i = 1; i <= n; i++)
            {
                harmonicSum += 1.0 / i;
            }
            return harmonicSum;
        }

        // Catalan Numbers: C(n) = (2n)! / ((n+1)!n!)
        public static BigInteger CatalanNumber(int n)
        {
            return Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
        }

        // Tetranacci Sequence: T(n) = T(n-1) + T(n-2) + T(n-3) + T(n-4), with T(0)=0, T(1)=1, T(2)=1, T(3)=2
        public static int Tetranacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;
            if (n == 3) return 2;

            int a = 0, b = 1, c = 1, d = 2, result = 0;
            for (int i = 4; i <= n; i++)
            {
                result = a + b + c + d;
                a = b;
                b = c;
                c = d;
                d = result;
            }
            return result;
        }
    }
}
