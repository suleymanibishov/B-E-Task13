using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task13
{
    class Employ:Human
    {
        public Employ(string name, Position position) : base(name) => Position = position;
        public Position Position { get; set; }
        public override string ToString()
        {
            return $"{Name} {Surname} : age {Age} : Position {Position};";
        }
    }
    enum Position
    {
        Junior,
        Middle,
        Senior
    }

}
