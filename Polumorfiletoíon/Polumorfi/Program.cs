using System;
using System.Collections.Generic;

namespace Polumorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Prudukt> cart = new List<Prudukt>();

            milk milk = new milk();
            milk.fat = 1;
            milk.pruduktnuber = 100;
            milk.stockstatus = 11;

            cart.Add(milk);

            nooco nocco = new nooco();
            nocco.Flavour = "god";
            nocco.pruduktnuber = 101;
            nocco.stockstatus = 20;

            cart.Add(nocco);

            

        }
    }
}
