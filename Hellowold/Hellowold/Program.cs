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

            string namn = Console.ReadLine(); // lärger in namn

            Console.WriteLine("hur gammal är du ?");
                
            ålder = Convert.ToInt32(Console.ReadLine()); // skriver ålder i sifror

            String svar;
            String tilstond = "är död";
            bool lup = false;
            
            Console.WriteLine("Lever du ? (ja/nej) ");
            

                svar = Console.ReadLine().ToLower();
                svar.Trim();
                if (svar == "ja") // svara ja
                {
                    lup = true;
                    tilstond = "Lever"; // edrar till död till levade 
                }
                
            


            Console.WriteLine("du heter " + namn); // skriver ut svar
            Console.WriteLine("du är " + ålder + " år gamal");
            Console.WriteLine("du " + tilstond);
        }
    }
}
