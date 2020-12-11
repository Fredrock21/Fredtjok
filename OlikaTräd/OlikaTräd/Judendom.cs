using System;
using System.Collections.Generic;
using System.Text;

namespace OlikaTräd
{
    class Judendom : Religon
    {
        public override void bock()
        {
            Console.WriteLine("torarularna");
        }

        public override void hus()
        {
            Console.WriteLine("synagoga");
        }

        public override void profet()
        {
            Console.WriteLine("Abraham");
        }
    }
}
