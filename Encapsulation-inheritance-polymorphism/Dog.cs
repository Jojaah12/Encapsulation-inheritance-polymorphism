using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class Dog : Animal
    {
        // unique prop for horse
        public string Color { get; set; }

        // Construtor
        public Dog(string name, double weghit, int age, string color) : base(name, weghit, age)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("woff woff");
        }
    }
}
