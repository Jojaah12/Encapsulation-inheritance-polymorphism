using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_inheritance_polymorphism
{
    internal class PersonHandler
    {
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            Person person = new Person();
            try
            {
                person.Age = age;
                person.FName = fName;
                person.LName = lName;
                person.Height = height;
                person.Weight = weight;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error creating person: {ex.Message}");
            }
            return person;
        }

        public void UpdatePerson(Person person, int newAge, string newFName, string newLName, double newHeight, double newWeight)
        {
            try
            {
                person.Age = newAge;
                person.FName = newFName;
                person.LName = newLName;
                person.Height = newHeight;
                person.Weight = newWeight;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error updating person: {ex.Message}");
            }
        }
    }
}