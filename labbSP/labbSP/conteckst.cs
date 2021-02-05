using System;
using System.Collections.Generic;
using System.Text;

namespace labbSP
{
    class conteckst
    {

        private Igivename namestrat;

        public conteckst(Igivename strat)
        {
            namestrat = strat;
        }

        public void dostrat(string name)
        {
            namestrat.gname(name);
        }
    
    }
}
