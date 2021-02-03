using System;

namespace labbSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the pet stor");
            

            bool P = false;

            Console.WriteLine("You kan by a katt or a dog");
            
            String chose = Console.ReadLine();

            if (chose = "katt" && "dog")
            {
                P = true;
            }
            else
            {
                Console.WriteLine("You didet chos a katt or a dog");
            }



            bool reset = false;


            Console.WriteLine("what du you wont to do with the" + chose);

            var operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    
                    break;
                case "-":
                    
                    break;
                case "*":
                    
                    break;
                case "/":
                   
                    break;
                default:
                    Console.WriteLine("Please select a valid operation");
                    reset = true;
                    
                    break;
            }




        }
    }
}
