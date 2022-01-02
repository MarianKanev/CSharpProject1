using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {

            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (product == "coffee") { quantity = quantity * 0.50; }
                else if (product == "water") { quantity = quantity * 0.80; }
                else if (product == "beer") { quantity = quantity * 1.20; }
                else if (product == "sweets") { quantity = quantity * 1.45; }
                else if (product == "peanuts") { quantity = quantity * 1.60; }
            }

            if (town == "Plovdiv")
            {
                if (product == "coffee") { quantity = quantity * 0.40; }
                else if (product == "water") { quantity = quantity * 0.70; }
                else if (product == "beer") { quantity = quantity * 1.15; }
                else if (product == "sweets") { quantity = quantity * 1.30; }
                else if (product == "peanuts") { quantity = quantity * 1.50; }
            }


            if (town == "Varna")
            {
                if (product == "coffee") { quantity = quantity * 0.45; }
                else if (product == "water") { quantity = quantity * 0.70; }
                else if (product == "beer") { quantity = quantity * 1.10; }
                else if (product == "sweets") { quantity = quantity * 1.35; }
                else if (product == "peanuts") { quantity = quantity * 1.55; }
            }

            Console.WriteLine(quantity);


        }
    }
}
