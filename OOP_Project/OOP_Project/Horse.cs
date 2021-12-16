using System;

namespace OOP_Project
{

    public class Horse : Mammal
    {
        public void Run()
        {
            Console.WriteLine( "Horse - i run");
        }

        //redefine somnthing in the 
        public new void Talk()
        {
            Console.WriteLine("i am Horse i Talk");
        }
    }
}
