using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {

            var line = double.Parse(Console.ReadLine());
            var high = double.Parse(Console.ReadLine());

            var area = (line * high) / 2;
            area = Math.Round(area,2);

            Console.WriteLine("Triangle area = " + area);

        }
    }
}
