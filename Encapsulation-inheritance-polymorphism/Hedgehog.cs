using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class Hedgehog : Animal
    {
        // Unique property for Hedgehog
        public int NumberOfSpikes { get; set; }

        public Hedgehog(string name, double weight, int age, int numberOfSpikes) : base(name, weight, age)
        {
            NumberOfSpikes = numberOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Snuffle snuffle");
        }
    }
}