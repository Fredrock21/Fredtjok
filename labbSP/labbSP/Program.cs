using System;
using System.Collections.Generic;

namespace labbSP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<pet> djur = new List<pet>();

            Igivename giva; 
            
            Console.WriteLine("Welcome to the pet stor");


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
                        djur.Add(cat);
                        break;

                    case "dog":

                        var hund = new dog();
                        djur.Add(hund);

                        P = true;
                        break;
                    
                    default:
                        Console.WriteLine("You nead to writ katt or dog");


                        break;
                }

            }

            



            

            Console.WriteLine("what du you wont to cal your new " + chose);

            String name = Console.ReadLine();

            Console.WriteLine("(1) give the" + chose + "a name by collaring it");
            Console.WriteLine("(2) give the" + chose + "a name by sipping it");


            var operation = Console.ReadLine();


            

            switch (operation)
            {
                case "1":
                    giva = new collar();
                    
                    
                    break;
                case "2":
                    giva = new chip();

                    break;
                
                default:
                    Console.WriteLine("The " + chose + " dide of sadnes wen you didet giv name him propely");
                    

                    giva = new collar();
                    
                    break;
            }

            
            var conteckst = new conteckst(giva);
            conteckst.dostrat(name);


        }
    }
}
