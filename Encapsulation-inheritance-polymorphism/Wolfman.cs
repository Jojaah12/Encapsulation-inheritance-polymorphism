using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age) : base(name, weight, age, 0)
        {
        }

        public void Talk()
        {
            Console.WriteLine("I am a Wolfman, and I can talk!");
        }
    }
}

