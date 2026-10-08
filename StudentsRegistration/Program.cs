using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace StudentsRegistration
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("===РЕГИСТАРЦИЯ НА УЧЕНИК===");

            //Име
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Име: {name}");

            //Години
            Console.WriteLine("Enter age: ");
            int age;
            while (!(int.TryParse(Console.ReadLine(), out age) && (age >= 6 && age <= 19 )))
            {
                Console.WriteLine("Невалидна възраст.Oпитай пак.");

            }
            Console.WriteLine($"Възраст: {age}");


            //Клас
            Console.WriteLine("Enter grade: ");
            int grade;
            while(!(int.TryParse(Console.ReadLine(),out grade) && (grade <= 6 && grade >= 2)))
            {
                Console.WriteLine("Невалидна оценка.Опитай пак.");
            }
            Console.WriteLine($"Клас: {grade}");


            //average grade
            Console.WriteLine("Средна оценка: ");
            double avrgrade;

            while (!double.TryParse(Console.ReadLine() ,out avrgrade) && (grade <= 6 && grade >= 2))
                {

                Console.WriteLine("Невалидна оценка.Опитай пак.");
                }
            Console.WriteLine($"Средна аритметична оценка: {avrgrade}");



            //Такса
            Console.WriteLine("Fee: ");
            decimal fee;

            while (!decimal.TryParse(Console.ReadLine(), out fee) && (fee >= 6 ))
            {
                 Console.WriteLine(".Опитай пак.");
            }
            Console.WriteLine($"Въведена такса: {fee}");

        }

    }
}
