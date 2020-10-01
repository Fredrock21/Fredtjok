using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace kundvagn
{
    class Program
    {
        static void Main(string[] args)
        {
            
            kund kund  = new kund(); // skapar kud.

            Console.WriteLine("Hej du är vår nya kunnd");
            Console.WriteLine("Vad heter ni?");

            kund._name = Console.ReadLine(); // nager din kund

            Console.WriteLine("hej "+ kund._name);

            List<string> kunder = new List<string>();

           

            bool loop = false;

            while (!loop)
            {
                int meny = 1;
                
                Console.WriteLine("Om du vill logga in som en annan kund tryck 1");
                Console.WriteLine("Om du vill köppa våra varor tryck 2");
                Console.WriteLine("Om du vill kolla din kuundvagn tryck 3");
                Console.WriteLine("Om du vill avsluta din köp tryck 4");

                meny = Convert.ToInt32(Console.ReadLine());

                switch (meny)
                {
                    case 1:
                        
                        kunder.Add(kund._name);

                        skapakunder(kunder);

                        
                        //skapa ny kund

                        
                        break;
                    case 2:

                        köpvaror(kund._snabmat);

                        // köp vara till kund

                        break;
                    case 3:

                        for (int i = 0; i < kunder.Count; i++)
                        {
                            Console.WriteLine(kunder[i] + " Har köpt");

                            for (int j = 0; j < kund._snabmat.Count; j++)
                            {
                                Console.WriteLine(kund._snabmat[j]._snabmatnamn);

                            }

                        }


                        //kola ina varoe

                        break;
                    case 4:
                        Console.WriteLine("Tack för dit köp");

                        loop = true;
                        //sluta shopp

                        break;
                    default:

                        break;
                }
            }


        }
        
        public static List<string> skapakunder(List<string> kunder)
        {
            Console.WriteLine("vad heter ni?");

            kund kund = new kund();

            kund._name = Console.ReadLine();

            kunder.Add(kund._name);

            return kunder;
        }
        public static List<Produkt> köpvaror(List<Produkt> produkter)
        {
            Produkt snabmat = new Produkt();

            int meny = 1;

            Console.WriteLine("vill du köpa haburgare tryck 1");
            Console.WriteLine("vill du köpa korv med bröd tryck 2");
            Console.WriteLine("vill du köpa coca cola tryck 3");

            meny = Convert.ToInt32(Console.ReadLine());

            switch (meny)
            {

                case 1:
                    Console.WriteLine("hur många vill du ha?");

                    int S = 0;
                    S = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < S; i++)
                    {
                    snabmat._snabmatnamn = "burgare";

                        produkter.Add(snabmat);
                    }

                    for (int i = 0; i < produkter.Count; i++)
                    {
                        Console.WriteLine(produkter[i]._snabmatnamn);

                    }


                    break;
                case 2:
                    Console.WriteLine("hur många vill du ha?");

                    int K = 0;
                    K = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < K; i++)
                    {
                        snabmat._snabmatnamn = "korv med bröd";

                        produkter.Add(snabmat);
                    }


                    break;
                case 3:
                    Console.WriteLine("hur många vill du ha?");

                    int C = 0;
                    C = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < C; i++)
                    {
                        snabmat._snabmatnamn = "coca cola";

                        produkter.Add(snabmat);
                    }

                    

                    break;

                default:

                    break;
            }
            

            return produkter;

        }
        

    }
}
