using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class Wolf : Animal
    {
        public Wolf(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("Howl howl");
        }
    }
}
