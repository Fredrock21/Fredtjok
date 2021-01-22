using System;

namespace DPE
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner _owner = new Owner();

            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")
            };

            Console.WriteLine("###############");
            Console.WriteLine();

            foreach (var animal in animals)
            {
                 animal.Eat();
                
                if (animal is Dog dog)
                {
                    _owner.TransferOwnership("Niklas"); // fufens 
                }

                
                animal.Sleep();
                animal.Speak();
                animal._color = "Grey";
                Console.WriteLine(animal.GetType().Name + " is " + animal._color);
                Console.WriteLine();

                Console.WriteLine("###############");
                Console.WriteLine();
            }
        }
    }
}

