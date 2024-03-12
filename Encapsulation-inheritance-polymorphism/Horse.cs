using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class Horse : Animal
    {
        // Unique property for Horse
        public double HeightAtWithers { get; set; }

        public Horse(string name, double weight, int age, double heightAtWithers) : base(name, weight, age)
        {
            HeightAtWithers = heightAtWithers;
        }

        public override void DoSound()
        {
            Console.WriteLine("Clip clop");
        }
    }
}
