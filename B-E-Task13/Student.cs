using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task13
{
    class Student:Human
    {
        public Student(string name, double grade) : base(name) => Grade = grade;
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname} : age {Age} : Grade {Grade};";
        }
    }
}
