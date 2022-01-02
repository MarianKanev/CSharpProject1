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

            int a = 5;
            int b = 10;
            int a_temp;

            a_temp = a;

            a = b;
            b = a_temp;

            Console.WriteLine("Before:");
            Console.WriteLine("a = "+ a_temp);
            Console.WriteLine("b = "+ a);


            Console.WriteLine("After:");
            Console.WriteLine("a = "+ a);
            Console.WriteLine("b = "+ b);


        }
    }
}
