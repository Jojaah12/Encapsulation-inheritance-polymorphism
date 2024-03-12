namespace Encapsulation_inheritance_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Dog("Buddy", 20.5, 3, "Golden Retriever"));
            animals.Add(new Horse("Jack", 140.5, 10, 5.5));
            animals.Add(new Hedgehog("Sonic", 1.2, 2, 100));
            animals.Add(new Worm("Slinky", 0.1, 1, true));
            animals.Add(new Bird("Chirpy", 0.5, 1, 0.2));

            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Buddy", 20.5, 3, "Golden Retriever"),
                new Dog("Max", 15.3, 4, "Labrador"),
                new Dog("Charlie", 18.7, 2, "German Shepherd"),
                new Dog("Bella", 12.1, 5, "Poodle")
            };

            // dogs.Add(new Horse("Jack", 140.5, 10, 5.5)); Horse is not in the type of dog

            Console.WriteLine("Stats for all animals:");
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"- {animal.Name}: {animal.Stats()}");
                animal.DoSound();

                if (animal is IPerson)
                {
                    IPerson person = (IPerson)animal;
                    person.Talk();
                }
            }

            Console.WriteLine("Stats for dogs only:");
            foreach (Animal animal in animals)
            {
                if (animal is Dog)
                {
                    Dog dog = (Dog)animal;
                    Console.WriteLine($"- {dog.Name}: {dog.Stats()}");
                }
            }

            Console.WriteLine("Random strings for dogs:");
            foreach (Dog dog in dogs)
            {
                Console.WriteLine($"- {dog.Name}: {dog.GenerateRandomString()}");
            }
        }
    }
}

//13.F:  we should add it to the Bird class because all bird subclasses inherit from the Bird class
//14.F:  we should add it to the Animal class because all animal classes inherit from the Animal class

//9.F: You cannot add a horse to a list of dogs because they are of different types. The dogs list is specifically defined to hold instances of the Dog class, and a horse is not a dog

//10. F: To store all classes together, the list type should be a common base class or interface that all classes inherit from or implement. In this case, since all classes inherit from the Animal class, you can use a list of Animal objects.
//13. F: We're printing out the stats of each animal in the Animals list by calling their Stats() method in a foreach loop
