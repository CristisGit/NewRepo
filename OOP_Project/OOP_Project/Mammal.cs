using System;
namespace OOP_Project
{

    public class Mammal
    {
        //		private string size;  TO DO // ADD emnum
        private string name;
        private decimal weight;

        public void Eat()
        {
            Console.WriteLine("i am a mammal, and i eat");
        }

        public void Move()
        {
            Console.WriteLine("i am a mammal, and i Move");
        }

        public void Talk()
        {
            Console.WriteLine("i am a mammal, and i Talk");
        }

        public void Sleep()
        {
            Console.WriteLine("i am a mammal, and i Sleep");
        }
    }
}
