using System;
using System.Collections.Generic;
using System.Text;

namespace labbSP
{
    class dog : pet
    {
        public override void name()
        {
            throw new NotImplementedException();
        }

        public override void Speak()
        {
            Console.WriteLine("dog is baking");
        }
    }
}
