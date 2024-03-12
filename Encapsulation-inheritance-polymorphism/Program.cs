namespace Encapsulation_inheritance_polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy", 20.5, 3, "Brown");
            Horse horse = new Horse("Jack", 140.5, 10, 5.5);
            Hedgehog hedgehog = new Hedgehog("Sonic", 1.2, 2, 100);
            Worm worm = new Worm("Slinky", 0.1, 1, true);
            Bird bird = new Bird("Chirpy", 0.5, 1, 0.2);
            Wolf wolf = new Wolf("Alpha", 35.7, 5, 8);

            dog.DoSound();
            horse.DoSound();
            hedgehog.DoSound();
            worm.DoSound();
            bird.DoSound();
            wolf.DoSound();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
