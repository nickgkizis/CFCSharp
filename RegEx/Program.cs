using System;
using System.Text.RegularExpressions;

namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email = "test@example.com";
            Console.WriteLine($"Is valid email? {IsValidEmail(email)}");

            string number = "12345";
            Console.WriteLine($"Is numeric? {IsNumeric(number)}");

            string text = "Hello, my name is Nick and I love C#!";
            Console.WriteLine("Words found: " + string.Join(", ", FindWords(text)));

            string maskedText = MaskDigits("My credit card number is 1234-5678-9876");
            Console.WriteLine("Masked Digits: " + maskedText);

            string multiEmailText = "Contact us at support@mail.com or admin@example.org";
            Console.WriteLine("Extracted Emails: " + string.Join(", ", ExtractEmails(multiEmailText)));

            // Exact Match Examples
            Console.WriteLine($"Exact match 'Hello'? {IsExactHello("Hello")}");
            Console.WriteLine($"Exact 5-digit ZIP code? {IsExactZipCode("12345")}");
            Console.WriteLine($"Exact Full Name? {IsExactFullName("John Doe")}");
            Console.WriteLine($"Exact Date (YYYY-MM-DD)? {IsExactDate("2024-03-17")}");

            // Additional Examples
            string phoneNumber = "+1-800-555-1234";
            Console.WriteLine($"Is valid phone number? {IsValidPhoneNumber(phoneNumber)}");

            string url = "https://www.example.com";
            Console.WriteLine($"Is valid URL? {IsValidUrl(url)}");

            string ipAddress = "192.168.1.1";
            Console.WriteLine($"Is valid IP address? {IsValidIpAddress(ipAddress)}");

            string hexColor = "#FF5733";
            Console.WriteLine($"Is valid hex color? {IsValidHexColor(hexColor)}");

            string time = "12:30 PM";
            Console.WriteLine($"Is valid time format (HH:mm AM/PM)? {IsValidTime(time)}");
        }

        // Validate Email
        static bool IsValidEmail(string input)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(input, pattern);
        }

        // Check if String Contains Only Numbers
        static bool IsNumeric(string input)
        {
            string pattern = @"^\d+$";
            return Regex.IsMatch(input, pattern);
        }

        // Find All Words in a Sentence
        static string[] FindWords(string input)
        {
            string pattern = @"\b\w+\b";
            MatchCollection matches = Regex.Matches(input, pattern);
            return Array.ConvertAll(matches.ToArray(), m => m.Value);
        }

        // Replace All Digits with '*'
        static string MaskDigits(string input)
        {
            string pattern = @"\d";
            return Regex.Replace(input, pattern, "*");
        }

        // Extract All Email Addresses from Text
        static string[] ExtractEmails(string input)
        {
            string pattern = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";
            MatchCollection matches = Regex.Matches(input, pattern);
            return Array.ConvertAll(matches.ToArray(), m => m.Value);
        }

        // Exact Match: "Hello"
        static bool IsExactHello(string input)
        {
            string pattern = @"^Hello$";
            return Regex.IsMatch(input, pattern);
        }

        // Exact Match: 5-digit ZIP Code
        static bool IsExactZipCode(string input)
        {
            string pattern = @"^\d{5}$";
            return Regex.IsMatch(input, pattern);
        }

        // Exact Match: Full Name (First Last)
        static bool IsExactFullName(string input)
        {
            string pattern = @"^[A-Z][a-z]+\s[A-Z][a-z]+$";
            return Regex.IsMatch(input, pattern);
        }

        // Exact Match: Date (YYYY-MM-DD)
        static bool IsExactDate(string input)
        {
            string pattern = @"^\d{4}-\d{2}-\d{2}$";
            return Regex.IsMatch(input, pattern);
        }

        // Validate Phone Number
        static bool IsValidPhoneNumber(string input)
        {
            string pattern = @"^\+?\d{1,4}[-\s]?\(?\d{1,4}\)?[-\s]?\d{1,4}[-\s]?\d{1,4}$";
            return Regex.IsMatch(input, pattern);
        }

        // Validate URL
        static bool IsValidUrl(string input)
        {
            string pattern = @"^(https?|ftp)://[^\s/$.?#].[^\s]*$";
            return Regex.IsMatch(input, pattern);
        }

        // Validate IP Address
        static bool IsValidIpAddress(string input)
        {
            string pattern = @"^(\d{1,3}\.){3}\d{1,3}$";
            return Regex.IsMatch(input, pattern);
        }

        // Validate Hexadecimal Color Code
        static bool IsValidHexColor(string input)
        {
            string pattern = @"^#[0-9A-Fa-f]{6}$";
            return Regex.IsMatch(input, pattern);
        }

        // Validate Time (HH:mm AM/PM)
        static bool IsValidTime(string input)
        {
            string pattern = @"^(0[1-9]|1[0-2]):([0-5][0-9])\s([APap][Mm])$";
            return Regex.IsMatch(input, pattern);
        }
    }
}
