using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktpolemorfi
{
    class hund : Animal
    {
        public hund()
        {
            nuberoflims = 4;
        }
        public override void breathe()
        {
            Console.WriteLine("hunden andas med tungan utt");
        }

        public override void eting()
        {
            Console.WriteLine("Hunden glufsar i sig mat");
        }

        public override void sleeping()
        {
            Console.WriteLine("hunden snakar");
        }
    }
}
