using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {

        static void Main(string[] args)
        {
            char letter_1;
            char letter_2;
            char letter_3;

            var var1 = Console.ReadLine();
            var var2 = Console.ReadLine();
            var var3 = Console.ReadLine();

            //letter_1 = Convert.ToChar(var1);
            //letter_2 = Convert.ToChar(var2);
            //letter_3 = Convert.ToChar(var3);

            Console.WriteLine(var3 + var2 + var1);
           
        }
    }
}
