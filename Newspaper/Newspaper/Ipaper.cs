using System;
using System.Collections.Generic;
using System.Text;

namespace Newspaper
{
    interface IPaper
    {
        void Add(Reader reader);
        void Remove(Reader reader);

        void Notify();
    }
}
