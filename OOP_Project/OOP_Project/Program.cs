using System;

namespace OOP_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Eat();
            mammal.Move();
            mammal.Sleep();
            mammal.Talk();

            Horse horse = new Horse();
            horse.Eat();
            horse.Run();
        }
    }
}
