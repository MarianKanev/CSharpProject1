using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var f0 = 1;
            var f1 = 1;

            var n = int.Parse(Console.ReadLine());

            for (var i = 0; i < n - 1; i++)
            {
                var fNext = f0 + f1;
                f0 = f1;
                f1 = fNext;
            }
            Console.WriteLine(f1);


        }
    }
}
