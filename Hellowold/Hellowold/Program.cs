using System;
using System.Net.NetworkInformation;

namespace Hellowold
{
    class Program
    {
        static void Main(string[] args)
        {
            int ålder;

            Console.WriteLine("vad heter du ?");

            string namn = Console.ReadLine();

            Console.WriteLine("hur gammal är du ?");
                
            ålder = Convert.ToInt32(Console.ReadLine());

            String svar;
            String tilstond = "finns";
            bool lup = false;
            
            Console.WriteLine("Lever du ? (ja/nej) ");
            

                svar = Console.ReadLine().ToLower();
                svar.Trim();
                if (svar == "ja")
                {
                    lup = true;
                    tilstond = "Lever";
                }
                else
                {
                    Console.WriteLine("svara ja eller nej");
                }
            


            Console.WriteLine("du heter " + namn);
            Console.WriteLine("du är " + ålder + " år gamal");
            Console.WriteLine("du " + tilstond);
        }
    }
}
