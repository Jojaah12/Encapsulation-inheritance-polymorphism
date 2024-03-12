namespace Encapsulation_inheritance_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>();

            Animals.Add(new Dog("Buddy", 20.5, 3, "Golden Retriever"));
            Animals.Add(new Horse("Jack", 140.5, 10, 5.5));
            Animals.Add(new Hedgehog("Sonic", 1.2, 2, 100));
            Animals.Add(new Worm("Slinky", 0.1, 1, true));
            Animals.Add(new Bird("Chirpy", 0.5, 1, 0.2));
            Animals.Add(new Wolf("Alpha", 35.7, 5, 8));
            Animals.Add(new Pelican("Peli", 5.0, 4, 2.0, 3.0));
            Animals.Add(new Flamingo("Flami", 4.0, 3, 1.5, "Pink"));
            Animals.Add(new Swan("Swani", 6.0, 5, 3.0, 2.5));

            Console.WriteLine("List of animals:");
            foreach (Animal animal in Animals)
            {
                Console.WriteLine($"- {animal.Name} ({animal.GetType().Name}):");
                animal.DoSound();

                if (animal is IPerson)
                {
                    ((IPerson)animal).Talk();
                }
            }
        }
    }
}