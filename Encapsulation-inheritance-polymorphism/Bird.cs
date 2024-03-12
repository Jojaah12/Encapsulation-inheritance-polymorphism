using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class Bird : Animal
    {
        // Unique property for Bird
        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Tweet tweet");
        }
    }
}
