using System;

namespace labbSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the pet stor");

            List<pet> djur = new List<pet>();
            bool P = true;

            Console.WriteLine("You kan by a katt or a dog");
            
            String chose = Console.ReadLine();
            while (P = false)
            {

                switch (chose)
                {
                    case "katt":
                        var cat = new katt();

                        P = true;
                        break;

                    case "dog":

                        var hund = new dog();

                        P = true;
                        break;
                    
                    default:
                        Console.WriteLine("You nead to writ katt or dog");


                        break;
                }

            }



            bool reset = false;


            Console.WriteLine("what du you wont to do with the" + chose);
            Console.WriteLine("(1) give the" + chose + "a name" );
            Console.WriteLine("(2) giv the");

            var operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    
                    break;
                case "2":
                    
                    break;
                case "3":
                                     
                   
                    break;
                default:
                    Console.WriteLine("");
                    reset = true;
                    
                    break;
            }




        }
    }
}
