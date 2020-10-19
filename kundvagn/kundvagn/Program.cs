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

            List<kund> kunder = new List<kund>();

            kunder.Add(kund);

            int p = 0;

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

                        skapakunder(kunder);

                        p++;

                        //skapa ny kund


                        break;
                    case 2:

                        köpvaror(kunder[p]._snabmat);

                        // köp vara till kund

                        break;
                    case 3:

                        for (int i = 0; i < kunder.Count; i++)
                        {
                            Console.WriteLine(kunder[i]._name + " Har köpt");

                            for (int j = 0; j < kunder[i]._snabmat.Count; j++)
                            {
                                Console.WriteLine(kunder[i]._snabmat[j]._snabmatnamn);

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
        
        public static List<kund> skapakunder(List<kund> kunder)
        {
            Console.WriteLine("vad heter ni?");

            kund kund = new kund();

            kund._name = Console.ReadLine();

            kunder.Add(kund);

            return kunder;
        }
        public static List<Produkt> köpvaror(List<Produkt> produkter)
        {

            int meny = 1;

            Console.WriteLine("vill du köpa haburgare tryck 1");
            Console.WriteLine("vill du köpa korv med bröd tryck 2");
            Console.WriteLine("vill du köpa coca cola tryck 3");

            meny = Convert.ToInt32(Console.ReadLine());

            switch (meny)
            {

                case 1:
                    
                    hamburgar(produkter);

                    break;
                case 2:
                    Console.WriteLine("hur många vill du ha?");

                    int K = 0;
                    K = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < K; i++)
                    {
                        var korvmbröd = new korvmedbröd();
                        
                        korvmbröd._snabmatnamn = "korv med bröd";

                        produkter.Add(korvmbröd);
                    }


                    break;
                case 3:
                    Console.WriteLine("hur många vill du ha?");

                    int C = 0;
                    C = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < C; i++)
                    {
                        var cocacola = new cocacola();

                        cocacola._snabmatnamn = "coca cola";

                        produkter.Add(cocacola);
                    }

                    

                    break;

                default:

                    break;
            }
            

            return produkter;

        }
        public static List<Produkt> hamburgar(List<Produkt> produkter)
        {
            int meny = 0;
            Console.WriteLine("viken grill vil du ha?");

            Console.WriteLine("rare 1");
            Console.WriteLine("medium rare 2");
            Console.WriteLine("Well done 3");

            meny = Convert.ToInt32(Console.ReadLine());

            switch (meny)
            {

                case 1:
                    Console.WriteLine("hur många vill du ha?");

                    int S = 0;
                    S = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < S; i++)
                    {
                        var hamburgare = new Hamburgare();

                        hamburgare._snabmatnamn = "burger";

                        hamburgare._meatkvalite = "rare";

                        produkter.Add(hamburgare);
                    }

                    break;
                case 2:
                    Console.WriteLine("hur många vill du ha?");

                    int P = 0;
                    P = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < P; i++)
                    {
                        var hamburgare = new Hamburgare();

                        hamburgare._snabmatnamn = "burger";

                        hamburgare._meatkvalite = "medium rare";

                        produkter.Add(hamburgare);
                    }


                    break;
                case 3:
                    Console.WriteLine("hur många vill du ha?");

                    int B = 0;
                    B = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < B; i++)
                    {
                        var hamburgare = new Hamburgare();

                        hamburgare._snabmatnamn = "burger";

                        hamburgare._meatkvalite = "Well done";

                        produkter.Add(hamburgare);
                    }



                    break;

                default:

                    break;
            }

            

            return produkter;
        }

    }
}
