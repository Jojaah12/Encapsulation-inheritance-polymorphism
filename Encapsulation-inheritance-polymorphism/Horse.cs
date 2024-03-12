using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class Horse : Animal
    {
        // unique prop for horse
        public string Color { get; set; }

        // Construtor
        public Horse(string name, double weghit, int age, string color) : base(name, weghit, age)
        {
            Color = color;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Clip clop");
        }
    }
}
