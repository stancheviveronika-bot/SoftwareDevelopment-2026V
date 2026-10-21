using SoftwareDevelopmentHW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopmentHw
{
    using System;
    using System.Runtime.Remoting.Services;
    using System.Security.Cryptography.X509Certificates;
    using System.Xml.Linq;

    internal class Program
    {
        private static int nextId = 1;

        static void Main()
        {
            Console.WriteLine("Student Registration");

            string name = ReadName();

            Student student = new Student(nextId++, name);

            student.Age = ReadInt("Enter age: ",6, 20);
            student.Grade = ReadInt("Enter grade (1-12): ", 1, 12);
            student.AverageScore = ReadDouble("Enter average score (2-6): ");
            student.Fee = ReadDecimal("Enter fee: ");
            student.HasScholarship = ReadBool("Has scholarship? (true/false): ");
            student.ClassLetter = ReadChar("Enter class letter: ");
            student.BirthDate = ReadDate("Enter birth date (dd.MM.yyyy): ");

            Console.WriteLine("\n--- Student Information ---");
            Console.WriteLine($"ID: {student.Id}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"Grade: {student.Grade}");
            Console.WriteLine($"Average score: {student.AverageScore}");
            Console.WriteLine($"Fee: {student.Fee}");
            Console.WriteLine($"Has scholarship: {student.HasScholarship}");
            Console.WriteLine($"Class letter: {student.ClassLetter}");
            Console.WriteLine($"Birth date: {student.BirthDate:dd.MM.yyyy}");
        }

        static string ReadName()
        {
            while (true)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine() ?? "";

                try
                {
                    // Student проверява дали името е валидно.
                    Student test = new Student(999, name);
                    return test.Name;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        
       static int ReadInt(string message, int min, int max)//a lot of mistakes i use help from AI
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine() ?? "";

                if (!int.TryParse(input, out int value))
                {
                    Console.WriteLine("Please enter a valid integer.");
                    continue;
                }

                if (value < min || value > max)
                {
                    Console.WriteLine($"Please enter a number between {min} and {max}.");
                    continue;
                }

                try
                {
                    Student test = new Student(999, "Test");

                    if (min == 1 && max == 120)
                    {
                        test.Age = value;
                    }
                    else
                    {
                        test.Grade = value;
                    }

                    return value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static double ReadDouble(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine() ?? "";

                if (!double.TryParse(input, out double value))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                try
                {
                    Student test = new Student(999, "Test");
                    test.AverageScore = value;
                    return value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static decimal ReadDecimal(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine() ?? "";

                if (!decimal.TryParse(input, out decimal value))
                {
                    Console.WriteLine("Please enter a valid decimal number.");
                    continue;
                }

                try
                {
                    Student test = new Student(999, "Test");
                    test.Fee = value;
                    return value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static bool ReadBool(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine() ?? "";

                if (bool.TryParse(input, out bool value))
                    return value;

                Console.WriteLine("Please enter true or false.");
            }
        }

        static char ReadChar(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine() ?? "";

                if (input.Length != 1)
                {
                    Console.WriteLine("Please enter one letter.");
                    continue;
                }

                try
                {
                    Student test = new Student(999, "Test");
                    test.ClassLetter = input[0];
                    return input[0];
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static DateTime ReadDate(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine() ?? "";

                if (!DateTime.TryParseExact(
                    input,
                    "dd.MM.yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None,
                    out DateTime value))
                {
                    Console.WriteLine("Use format dd.MM.yyyy.");
                    continue;
                }

                try
                {
                    Student test = new Student(999, "Test");
                    test.BirthDate = value;
                    return value;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}










