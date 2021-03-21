using System;
using System.Collections.Generic;
using System.Text;

namespace Newspaper
{
    class Newspaper : IPaper
    {
        List<Reader> subscribers = new List<Reader>();

        private int _articles;

        public int Articles
        {
            get { return _articles; }
            set 
            {
                if (value > _articles)
                {
                    Notify();
                }
                _articles = value; 
            }
        }

        public void Add(Reader reader)
        {
            subscribers.Add(reader);
        }

        public void Remove(Reader reader)
        {
            subscribers.Remove(reader);
        } 
        
        public void Notify()
        {
            foreach(var reader in subscribers)
            {
                reader.NewA();
            }
        }
    }
}
