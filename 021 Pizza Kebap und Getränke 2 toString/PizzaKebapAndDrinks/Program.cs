﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKebapAndDrinks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Pizza pizza = new Pizza("Venezia", 6.5m, true);
            Kebap kebap = new Kebap("Ardana Kebap", 4.55m);
            Drink drink = new Drink("Cola", 3.5m, Volume._025l);

            Console.WriteLine(pizza);
            Console.WriteLine(kebap);
            Console.WriteLine(drink);

            Console.ReadKey();
        }
    }
}
