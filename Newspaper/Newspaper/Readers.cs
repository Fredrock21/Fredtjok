using System;
using System.Collections.Generic;
using System.Text;

namespace Newspaper
{
    class Reader : IReader
    {
        public string Name { get; private set; }

        public Reader(string name)
        {
            this.Name = name;
        }

        public void NewA()
        {
            Console.WriteLine("A new artical has bin relist " + this.Name);
        }
    }
}
