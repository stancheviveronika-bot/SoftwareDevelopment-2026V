using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace TodoManager
{
    internal class Program
    {
        static List<Task> tasks = new List<Task>();

        static void Main(string[] args)
        {

            {
                while (true)
                {
                    Console.WriteLine("== TodoManager ==");
                    Console.WriteLine("1) Добави задача:");
                    Console.WriteLine("2) Покажи всички задачи:");
                    Console.WriteLine("3) Маркирай задача като изпълнена:");
                    Console.WriteLine("4) Изтрий задача:");
                    Console.WriteLine("5) Изход:");

                    Console.Write("Избери: ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        AddTask();
                    }
                    else if (choice == "2")
                    {
                        ShowTasks();
                    }
                    else if (choice == "3")
                    {
                        CompleteTask();
                    }
                    else if (choice == "4")
                    {
                        DeleteTask();
                    }
                    else if (choice == "5")
                    {
                        Console.WriteLine("Край на програмата.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Невалиден избор!");
                    }
                }
            }
        }

            static void AddTask()
            {
                Console.Write("Заглавие: ");
                string title = Console.ReadLine();

                Console.Write("Описание: ");
                string description = Console.ReadLine();

                Console.Write("Краен срок: ");
                string deadline = Console.ReadLine();

                Task task = new Task(title, description, deadline);

                tasks.Add(task);

                Console.WriteLine("Задачата е добавена!");
            }
        
            static void ShowTasks()
            {
                if (tasks.Count == 0)
                {
                    Console.WriteLine("Няма въведени задачи.");
                    return;
                }

                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine("\nЗадача №" + (i + 1));
                    Console.WriteLine("Заглавие: " + tasks[i].Title);
                    Console.WriteLine("Описание: " + tasks[i].Description);
                    Console.WriteLine("Краен срок: " + tasks[i].Deadline);
                    Console.WriteLine("Статус: " +
                        (tasks[i].IsCompleted ? "Изпълнена" : "Неизпълнена"));
                }
            }

            static void CompleteTask()
            {
                ShowTasks();

                Console.Write("\nВъведи номер на задачата: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 1 && number <= tasks.Count)
                {
                    tasks[number - 1].IsCompleted = true;
                    Console.WriteLine("Задачата е маркирана като изпълнена!");
                }
                else
                {
                    Console.WriteLine("Невалиден номер!");
                }
            }

            static void DeleteTask()
            {
                ShowTasks();

                Console.Write("\nВъведи номер на задачата за изтриване: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 1 && number <= tasks.Count)
                {
                    tasks.RemoveAt(number - 1);
                    Console.WriteLine("Задачата е изтрита!");
                }
                else
                {
                    Console.WriteLine("Невалиден номер!");
                }
            }


        
    }
}
