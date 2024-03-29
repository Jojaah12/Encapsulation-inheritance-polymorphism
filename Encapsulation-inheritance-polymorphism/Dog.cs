﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    public class Dog : Animal
    {
        // Unique property for Dog
        public string Breed { get; set; }
        public Dog(string name, double weight, int age, string breed) : base(name, weight, age)
        {
            Breed = breed;
        }
        public override string Stats()
        {
            return $"Name: {Name}, Weight: {Weight} kg, Age: {Age} years, Breed: {Breed}";
        }
        public override void DoSound()
        {
            Console.WriteLine("woff woff");
        }

        public string GenerateRandomString()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
