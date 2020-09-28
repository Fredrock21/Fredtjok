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


            kund._name = Console.ReadLine(); // nager din kund

            Console.WriteLine("hej"+ kund._name);

            List<string> kunder = new List<string>();

            Console.WriteLine("Om du vill logga in som en annan kund tryck 1");
            Console.WriteLine("Om du vill köppa våra varor tryck 2");
            Console.WriteLine("Om du vill kolla din kuundvagn tryck 3");
            Console.WriteLine("Om du vill avsluta din köp tryck 4");

            bool loop = false;

            List<Produkt> _snabmat = new List<Produkt>();

            while (!loop)
            {
                int meny = 1;

                meny = Convert.ToInt32(Console.ReadLine());

                switch (meny)
                {
                    case 1:
                        kunder.Add(kund._name);

                        Console.WriteLine(kunder);

                        Console.WriteLine(skapakunder());
                        //skapa ny kund


                        break;
                    case 2:

                        Console.WriteLine(köpvaror();

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
        
        public static List<kund> skapakunder(List<kund> kunder)
        {
            kund kund = new kund();

            kund._name = Console.ReadLine();

            return kunder;
        }
        public static List<Produkt> köpvaror()
        {


        }
        

    }
}
