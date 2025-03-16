using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== C# Operators Demonstration ===\n");

            ArithmeticOperators();
            AssignmentOperators();
            ComparisonOperators();
            LogicalOperators();
            BitwiseOperators();
            IncrementDecrementOperators();
            TernaryOperator();
            NullCoalescingOperator();


            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        /// <summary>
        /// Demonstrates Arithmetic Operators
        /// </summary>
        static void ArithmeticOperators()
        {
            Console.WriteLine("\n--- Arithmetic Operators ---");
            int a = 10, b = 3;
            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} * {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {a / b} (Integer Division)");
            Console.WriteLine($"{a} % {b} = {a % b} (Modulus)");
            Console.WriteLine($"10.0 / 3.0 = {10.0 / 3.0} (Floating-point Division)");
        }

        /// <summary>
        /// Demonstrates Assignment Operators
        /// </summary>
        static void AssignmentOperators()
        {
            Console.WriteLine("\n--- Assignment Operators ---");
            int x = 5;
            Console.WriteLine($"Initial x = {x}");
            x += 3; Console.WriteLine($"x += 3 -> x = {x}");
            x -= 2; Console.WriteLine($"x -= 2 -> x = {x}");
            x *= 4; Console.WriteLine($"x *= 4 -> x = {x}");
            x /= 2; Console.WriteLine($"x /= 2 -> x = {x}");
            x %= 3; Console.WriteLine($"x %= 3 -> x = {x}");
        }

        /// <summary>
        /// Demonstrates Comparison Operators
        /// </summary>
        static void ComparisonOperators()
        {
            Console.WriteLine("\n--- Comparison Operators ---");
            int a = 7, b = 5;
            Console.WriteLine($"{a} == {b} : {a == b}");
            Console.WriteLine($"{a} != {b} : {a != b}");
            Console.WriteLine($"{a} > {b} : {a > b}");
            Console.WriteLine($"{a} < {b} : {a < b}");
            Console.WriteLine($"{a} >= {b} : {a >= b}");
            Console.WriteLine($"{a} <= {b} : {a <= b}");
        }

        /// <summary>
        /// Demonstrates Logical Operators
        /// </summary>
        static void LogicalOperators()
        {
            Console.WriteLine("\n--- Logical Operators ---");
            bool p = true, q = false;
            Console.WriteLine($"p = {p}, q = {q}");
            Console.WriteLine($"p && q : {p && q} (AND)");
            Console.WriteLine($"p || q : {p || q} (OR)");
            Console.WriteLine($"!p : {!p} (NOT)");
        }

        /// <summary>
        /// Demonstrates Bitwise Operators
        /// </summary>
        static void BitwiseOperators()
        {
            Console.WriteLine("\n--- Bitwise Operators ---");
            int x = 5, y = 3; // 5 = 0101, 3 = 0011
            Console.WriteLine($"{x} & {y} = {x & y} (Bitwise AND)");
            Console.WriteLine($"{x} | {y} = {x | y} (Bitwise OR)");
            Console.WriteLine($"{x} ^ {y} = {x ^ y} (Bitwise XOR)");
            Console.WriteLine($"~{x} = {~x} (Bitwise NOT)");
            Console.WriteLine($"{x} << 1 = {x << 1} (Left Shift)");
            Console.WriteLine($"{x} >> 1 = {x >> 1} (Right Shift)");
        }

        /// <summary>
        /// Demonstrates Increment and Decrement Operators
        /// </summary>
        static void IncrementDecrementOperators()
        {
            Console.WriteLine("\n--- Increment & Decrement Operators ---");
            int a = 5;
            Console.WriteLine($"Initial a = {a}");
            Console.WriteLine($"a++ (Post-increment): {a++}, Now a = {a}");
            Console.WriteLine($"++a (Pre-increment): {++a}, Now a = {a}");
            Console.WriteLine($"a-- (Post-decrement): {a--}, Now a = {a}");
            Console.WriteLine($"--a (Pre-decrement): {--a}, Now a = {a}");
        }

        /// <summary>
        /// Demonstrates the Ternary Operator (?:)
        /// </summary>
        static void TernaryOperator()
        {
            Console.WriteLine("\n--- Ternary Operator (?:) ---");
            int number = -5;
            string result = (number > 0) ? "Positive" : "Negative or Zero";
            Console.WriteLine($"Number: {number}, Result: {result}");

            int a = 10, b = 20;
            int max = (a > b) ? a : b;
            Console.WriteLine($"Max of {a} and {b} is {max}");
        }

        /// <summary>
        /// Demonstrates the Null-Coalescing Operator (??)
        /// </summary>
        static void NullCoalescingOperator()
        {
            Console.WriteLine("\n--- Null-Coalescing Operator (??) ---");
            string name = null;
            string displayName = name ?? "Guest";
            Console.WriteLine($"Name: {name ?? "NULL"} -> Display Name: {displayName}");

            int? nullableValue = null;
            int defaultValue = nullableValue ?? 100; // If nullableValue is null, use 100
            Console.WriteLine($"Nullable Value: {nullableValue ?? 0}, Default: {defaultValue}");
        }
    }
}
