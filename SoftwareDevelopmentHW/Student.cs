using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopmentHW
{
   
        internal class Student
        {
            private int id;
            private string name;
            private int age;
            private int grade;
            private double averageScore;
            private decimal fee;
            private bool hasScholarship;
            private char classLetter;
            private DateTime birthDate;


            public int Id { get; private set; }

            public string Name
            { 
             get { return name; }
             set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Name cannot be null or empty.");
                    }
                    name = value;

                }
            }

            public int Age
            {
                get { return age; }
                set
                {
                    if(value < 6 || value > 20)
                    {
                        throw new ArgumentOutOfRangeException("Error! Pleas enter age.");
                    }
                    age = value;
                }
            }

            public int Grade
            {
                get { return grade; }
                set
                {
                    if (value < 1 || value > 12)
                    {
                        throw new ArgumentOutOfRangeException("Error! Please enter grade.");
                    }
                    grade = value;

            }
            }

            public double AverageScore
            {
                get { return averageScore; }
                set  
                {
                    if (value < 2 || value > 6)
                    {
                        throw new ArgumentOutOfRangeException("Grate have to be between 2 and 6.");
                    }
                    averageScore = value;
            }
            }

            public decimal Fee
            {
                get { return fee; }
                set
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Fee cannot be negative.");
                    }
                    fee = value;
            }
            }

            public bool HasScholarship { get; set; }

            public char ClassLetter
            {
                get { return classLetter; }
                set
                {
                   if(!char.IsLetter(value))
                    {
                        throw new ArgumentException("Class leter must be letter");
                    }
                    classLetter = value;
            }
            }

            public DateTime BirthDate
            {
                get { return birthDate; }
                set
                {
                    if (value > DateTime.Now )
                    {
                        throw new ArgumentOutOfRangeException("Birth date cannot be in the future.");
                    }  
                      birthDate = value;
            }
            }

            public Student(int id,string name)
            {
                if (id <= 0 )
                {
                    throw new ArgumentOutOfRangeException("Id must be positive.");
                }

                Id = id;
                Name = name;
            }
        }
    
}
