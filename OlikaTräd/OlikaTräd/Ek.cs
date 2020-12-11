using System;
using System.Collections.Generic;
using System.Text;

namespace OlikaTräd
{
    class Ek : Träd
    {

        public Ek()
        {
            höjd = 40;
        }
        public override void lifsklimat()
        {
            Console.WriteLine("kan leva i många klimat");
        }

        public override void lövenfaller()
        {
            Console.WriteLine("löven faller på hösten");
        }

        public override void trädhöjd()
        {
            Console.WriteLine("Eken är 40m");
        }
    }
}
