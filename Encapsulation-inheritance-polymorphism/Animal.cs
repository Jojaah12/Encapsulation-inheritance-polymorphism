using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public abstract class Animal
    {
        // Properties
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        // Constructor
        public Animal(string name, double weghit, int age)
        {
            Name = name;
            Weight = weghit;
            Age = age;
        }

        // Abstract method making sound
        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Name: {Name}, Weight: {Weight} kg, Age: {Age} years";
        }

    }
}
