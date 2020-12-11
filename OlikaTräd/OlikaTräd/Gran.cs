using System;
using System.Collections.Generic;
using System.Text;

namespace OlikaTräd
{
    class Gran : Träd
    {

        public Gran()
        {

        }
        public override void lifsklimat()
        {
            Console.WriteLine("Fins i kalla klimat.");
        }

        public override void lövenfaller()
        {
            Console.WriteLine("granen barrar.");
        }

        public override void trädhöjd()
        {
            Console.WriteLine("Granen kan bli 60m");
        }
    }
}
