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

            string var1 = "Hello";
            string var2 = "World";

            object obj_var = var1 + " " + var2;

            string var3 = obj_var.ToString();

            Console.WriteLine(var3);


        }
    }
}
