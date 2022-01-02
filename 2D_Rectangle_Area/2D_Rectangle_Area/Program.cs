using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double x_temp;
            double y_temp;

            if ( x1 > x2 ) 
                {
                  x_temp = x1 - x2;
                }

            else
            {
                  x_temp = x2 - x1;
            }

            if (y1 > y2)
            {
                y_temp = y1 - y2;
            }

            else
            {
                y_temp = y2 - y1;
            }


            double perimeter = 2 * (x_temp) + 2 * (y_temp);
            double area =  (x_temp) * (y_temp);

            Console.WriteLine(area);
            Console.WriteLine(perimeter);


        }
    }
}
