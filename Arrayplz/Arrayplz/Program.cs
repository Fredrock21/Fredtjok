using System;

namespace Arrayplz
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Name = new String[5];

            Console.WriteLine("Skriv in 5 nama");

            for (int i = 0; i < 5; i++)
            {
                Name[i] = Console.ReadLine();
            }
            Console.WriteLine("Du skrev in namnen");


            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(Name[j]);

            }
        }
    }
}
