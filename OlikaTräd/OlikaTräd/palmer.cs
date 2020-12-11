using System;
using System.Collections.Generic;
using System.Text;

namespace OlikaTräd
{
    class palmer : Träd
    {
        public override void lövenfaller()
        {
            Console.WriteLine("Löven torkar i hop.");
        }

        public override void trädhöjd()
        {
            Console.WriteLine("Plamen är 3m");
        }

        public override void lifsklimat()
        {
            Console.WriteLine("I tropik värme");
        }
    }
}
