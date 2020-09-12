using System;

namespace Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,2));
        }
        static int Add(int tal1, int tal2) 
        {
            int sum = 0;

            sum = tal1 + tal2;

            return sum;
        
        }
    }
}
