using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {

            double width = double.Parse(Console.ReadLine());
            double heigh = double.Parse(Console.ReadLine());

            double perimeter = ( 2 * width ) + ( 2 * heigh);
            double diagonal = Math.Sqrt((width * width) + (heigh * heigh));
            double area = width * heigh;


            //Console.WriteLine("Perimeter is: {0}", perimeter);
            //Console.WriteLine("Diagonal is : {0}", diagonal);
            //Console.WriteLine("Area is : {0}", area);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(diagonal);


        }
    }
}
