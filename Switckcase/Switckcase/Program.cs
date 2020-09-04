using System;

namespace Switckcase
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int rock = 1;

            Console.WriteLine("vilken rock gillar du mest");
            Console.WriteLine("Metal 1");
            Console.WriteLine("Punk 2");
            Console.WriteLine("Ska 3");



            rock = Convert.ToInt32(Console.ReadLine());


            switch (rock)
            {
                case 1:
                    Console.WriteLine("du gillar Metal");
                    break;
                case 2:
                    Console.WriteLine("du gillar Punk");
                    break;
                case 3:
                    Console.WriteLine("du gillar Ska");
                    break;
                default:
                    Console.WriteLine("Du är fel");
                    break;

                    



            }
            Console.WriteLine("hur gamal är du?");



            var ålder = Convert.ToInt32(Console.ReadLine());

            if (ålder >= 18)
            {

                Console.WriteLine("Du får drika");

            }
            else if (ålder <= 17)
            {
                Console.WriteLine("Du får inte drika");
            }
            else
            {
                Console.WriteLine("Vem är du?");
            }


            Console.WriteLine("var är dit favorit numer");



            var num = Convert.ToInt32(Console.ReadLine());
            int p = 0;

            while (0 == num)
            {
                num--;
                Console.WriteLine(num);
            }
            
            for (var i = 0; i == num; i++)
            {
                num++;
                Console.WriteLine(num);

            }

            
        }
    }
}
