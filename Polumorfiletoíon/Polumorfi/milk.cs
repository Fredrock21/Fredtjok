using System;
using System.Collections.Generic;
using System.Text;

namespace Polumorfi
{
    class milk : Prudukt
    {
        private int _fat;

        public int fat
        {
            get { return _fat; }
            set { _fat = value; }
        }
    }
}
