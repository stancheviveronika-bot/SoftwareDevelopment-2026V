using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopmentHw
{
    internal class Students
    {

        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public double AverageGrade { get; set; }
        public decimal Fee { get; set; }
        public bool HasScholarship { get; set; }
        public char ClassLetter { get; set; }
        public DateTime BirthDate { get; set; }

        public Students(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
