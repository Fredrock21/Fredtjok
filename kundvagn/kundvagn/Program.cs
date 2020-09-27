using System;
using System.ComponentModel;

namespace kundvagn
{
    class Program
    {
        static void Main(string[] args)
        {
            
            kund kund  = new kund(); // skapar kud.


            kund._name = Console.ReadLine(); // nager din kund

            Console.WriteLine(kund._name);

            bool loop = false;

            while (!loop)
            {
                int meny = 1;

                meny = Convert.ToInt32(Console.ReadLine());

                switch (meny)
                {
                    case 1:

                        Console.WriteLine(skapakunder()._name);
                        //skapa ny kund


                        break;
                    case 2:

                        // köp vara till kund

                        break;
                    case 3:

                        //kola ina varoe

                        break;
                    case 4:
                        Console.WriteLine("hej");

                        loop = true;
                        //sluta shopp

                        break;
                    default:

                        break;
                }
            }


        }
        
        public static kund skapakunder()
        {
            kund kund = new kund();

            kund._name = Console.ReadLine();

            return kund;
        }
        

    }
}
