using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class Wolf : Animal
    {
        // Unique property for Wolf
        public int PackSize { get; set; }
        public Wolf(string name, double weight, int age, int packSize) : base(name, weight, age)
        {
            PackSize = packSize;
        }
        public override void DoSound()
        {
            Console.WriteLine("Howl howl");
        }

        public override string Stats()
        {
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}, Pack Size: {PackSize}";
        }
    }
}
