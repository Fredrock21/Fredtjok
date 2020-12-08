using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktpolemorfi
{
    class haj : Animal
    {
        public haj()
        {
            nuberoflims = 5;
        }
        public override void breathe()
        {
            Console.WriteLine("Hajen andas med hjälarna");
        }

        public override void eting()
        {
            Console.WriteLine("hajen jagar fisk");
        }

        public override void sleeping()
        {
            Console.WriteLine("hajen såver med en järnhalava.");
        }

        public void sima()
        {
            Console.WriteLine("hajen simar");
        } 
    }
}
