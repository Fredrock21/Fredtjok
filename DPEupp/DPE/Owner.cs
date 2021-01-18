using System;
using System.Collections.Generic;
using System.Text;

namespace DPE
{
    class Owner 
    {
        string _owner;

        public void TransferOwnership(string owner)
        {
            _owner = owner;
        }
    }
}
