using System;
using System.Collections.Generic;
using System.Text;

namespace OlikaTräd
{
    class kristendom : Religon
    {
        public override void bock()
        {
            Console.WriteLine("Biben");
        }

        public override void hus()
        {
            Console.WriteLine("kyrka");
        }

        public override void profet()
        {
            Console.WriteLine("Jessus");
        }
    }
}
