using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraktpolemorfi
{
   
        abstract class Animal
        {
            public int nuberoflims { get; set; }

            public string coler { get; set; }

            public abstract void breathe();

            public abstract void eting();

            public abstract void sleeping();

        }
    
}
