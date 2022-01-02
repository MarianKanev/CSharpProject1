using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_to_F
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp_C = double.Parse(Console.ReadLine());

            double temp_F = temp_C * 1.8 + 32;
            temp_F = Math.Round(temp_F, 2);

            Console.WriteLine(temp_F);

        }
    }
}
