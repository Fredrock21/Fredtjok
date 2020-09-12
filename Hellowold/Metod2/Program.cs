using System;
using System.Diagnostics.CodeAnalysis;

namespace Metod2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] heltal = new int[5]
            { 1,2,3,4,5};

            Console.WriteLine(add(heltal));

            string[] namn = new string[5] { "Fiskmås ", "Fredrik ", "är ", "namn ", "mitt " };

            Console.WriteLine(ord(namn));

            int[] storlitten = new int[5]
            { 7,5,3,10,2};

            Console.WriteLine(sort(storlitten));

        }
        static int add(int[] heltal)
        {
            int sum = 0;

            for (int i = 0; i < heltal.Length; i++)
            {
                sum += heltal[i];
            }

            return sum;

        }
        static string ord(string[] namn)
        {
        String sum = "";

            Array.Reverse(namn);

            for (int i = 0; i < namn.Length; i++)
            {
                sum += namn[i];
            }

            
            return sum;
                
        }
        static (int, int) sort(int[] storlitten)
        {

            int stor = 0;

            int minst = 100;

            for (int i = 0; i < storlitten.Length; i++)
            {

                if(stor < storlitten[i])
                {
                    stor = storlitten[i];
                }

            }
            for (int i = 0; i < storlitten.Length; i++)
            {

                if (minst > storlitten[i])
                {
                    minst = storlitten[i];
                }

            }

            Console.WriteLine("störst tal och minst tal");
            return (stor, minst);
           
        }





    }
}
