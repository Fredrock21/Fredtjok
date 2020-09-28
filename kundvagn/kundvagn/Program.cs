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

            Console.WriteLine(kund._name);

            List<kund> kunder = new List<kund>();

            bool loop = false;

            while (!loop)
            {
                int meny = 1;

                meny = Convert.ToInt32(Console.ReadLine());

                switch (meny)
                {
                    case 1:
                        kunder.Add(kund);

                        Console.WriteLine(kunder);

                        Console.WriteLine(skapakunder());
                        //skapa ny kund


                        break;
                    case 2:

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
        

    }
}
