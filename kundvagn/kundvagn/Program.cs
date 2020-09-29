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

            Console.WriteLine("hej"+ kund._name);

            List<string> kunder = new List<string>();

            Console.WriteLine("Om du vill logga in som en annan kund tryck 1");
            Console.WriteLine("Om du vill köppa våra varor tryck 2");
            Console.WriteLine("Om du vill kolla din kuundvagn tryck 3");
            Console.WriteLine("Om du vill avsluta din köp tryck 4");

            bool loop = false;

            while (!loop)
            {
                int meny = 1;

                meny = Convert.ToInt32(Console.ReadLine());

                switch (meny)
                {
                    case 1:
                        
                        kunder.Add(kund._name);

                        skapakunder(kunder);
                        //skapa ny kund
                        
                        for (int i = 0; i < kunder.Count; i++)
                        {
                            Console.WriteLine(kunder[i]);

                        }

                        break;
                    case 2:

                        Console.WriteLine(köpvaror(kund._snabmat));

                        

                        // köp vara till kund

                        break;
                    case 3:

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
            snabmat._snabmatnamn = "burjare";
            
            produkter.Add(snabmat);

            return produkter;

        }
        

    }
}
