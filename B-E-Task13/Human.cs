using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task13
{
    class Human
    {
        public Human(string name) => Name = name;
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname} : age {Age};";
        }
    }
}
