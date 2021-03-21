using System;

namespace Newspaper
{
    class Program
    {
        static void Main(string[] args)
        {
            var gp = new Newspaper();

            

            var Fredrik = new Reader("fredrik");
            gp.Add(Fredrik);
            
            gp.Articles++;

                      
            var niklas = new Reader("niklas");
            gp.Add(niklas);
            
            gp.Articles = gp.Articles + 8;

            var filip = new Reader("filip");

            gp.Add(filip);

            gp.Remove(niklas);
            
            gp.Articles++;

        }
    }
}
