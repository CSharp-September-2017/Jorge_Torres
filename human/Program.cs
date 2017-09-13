using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            humanatt person1 = new humanatt("super pizza", 20, 8, 16, 50);
            humanatt person2 = new humanatt("PC", 0,0,0, 100);
            person1.attack(person2);
            Console.WriteLine($"After being attacked player1{person1.name}, the {person2.name}'s, health is now {person2.health}");
        }
    }
}
