using System;
using System.Collections.Generic;

namespace Abstraktpolemorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> djur = new List<Animal>();

            var hund = new hund();
            hund.coler = "brun";

            var haj = new haj();
            haj.coler = "grå";

            djur.Add(hund);
            djur.Add(haj);

            foreach(var Animal in djur)
            {
                Animal.breathe();
                Animal.eting();
                Animal.sleeping();

                if(Animal == haj)
                {
                    haj.sima();
                }

            }



        }
    }
}
