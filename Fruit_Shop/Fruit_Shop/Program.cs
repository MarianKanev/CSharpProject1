using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            string fruit_type = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            char err_flag = ' ';

            if (day == "Saturday" || day == "Sunday")
            { 
                if (fruit_type == "banana") { quantity = quantity * 2.70; }
                else if (fruit_type == "apple") { quantity = quantity * 1.25; }
                else if (fruit_type == "orange") { quantity = quantity * 0.90; }
                else if (fruit_type == "grapefruit") { quantity = quantity * 1.60; }
                else if (fruit_type == "kiwi") { quantity = quantity * 3.00; }
                else if (fruit_type == "pineapple") { quantity = quantity * 5.60; }
                else if (fruit_type == "grapes") { quantity = quantity * 4.20; }
                else { err_flag = 'X'; }  // wrong fruit type

            }

            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit_type == "banana") { quantity = quantity * 2.50; }
                else if (fruit_type == "apple") { quantity = quantity * 1.20; }
                else if (fruit_type == "orange") { quantity = quantity * 0.85; }
                else if (fruit_type == "grapefruit") { quantity = quantity * 1.45; }
                else if (fruit_type == "kiwi") { quantity = quantity * 2.70; }
                else if (fruit_type == "pineapple") { quantity = quantity * 5.50; }
                else if (fruit_type == "grapes") { quantity = quantity * 3.85; }
                else { err_flag = 'X'; } // wrong fruit type

            }

            else { err_flag = 'X'; }   // wrong day
//==============================================================================================
            if (err_flag == 'X')
            {
                Console.WriteLine("error");
               
            }
            else
            {
                Console.WriteLine("{0:f2}", quantity);
            }

        }
    }
}
