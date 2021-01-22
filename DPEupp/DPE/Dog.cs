using System;
using System.Collections.Generic;
using System.Text;

namespace DPE
{
    class Dog : Animal
    {
        
        public Dog(string color) : base(color)
        {

        }

        public override void Speak()
        {
            Console.WriteLine("Dog is barking!");
        }

        public override void Sleep()
        {
            Console.WriteLine("Dog is sleeping!");
        }

        public override void Eat()
        {
            Console.Write("Dog is eating. ");
        }

        
    }
}
