using System;
using System.Collections.Generic;
using System.Text;

namespace OlikaTräd
{
    class Islam : Religon
    {
        public override void bock()
        {
            Console.WriteLine("koranden");
        }

        public override void hus()
        {
            Console.WriteLine("Moske");
        }

        public override void profet()
        {
            Console.WriteLine("Mohammed");
        }
    }
}
