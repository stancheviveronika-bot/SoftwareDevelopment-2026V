using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopmentHw
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //пример от ChatGPT който ще бъде заменен
            Students student = new Students(1, "Ivan");

            student.Age = 16;
            student.Grade = 10;
            student.AverageGrade = 5.50;
            student.Fee = 100m;
            student.HasScholarship = true;
            student.ClassLetter = 'A';
            student.BirthDate = new DateTime(2010, 5, 15);

            Console.WriteLine("ID: " + student.Id);
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Age: " + student.Age);
            Console.WriteLine("Grade: " + student.Grade);
            Console.WriteLine("Average Grade: " + student.AverageGrade);
            Console.WriteLine("Fee: " + student.Fee);
            Console.WriteLine("Has Scholarship: " + student.HasScholarship);
            Console.WriteLine("Class Letter: " + student.ClassLetter);
            Console.WriteLine("Birth Date: " + student.BirthDate.ToShortDateString());
        }
    }
}
