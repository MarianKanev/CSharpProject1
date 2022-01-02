using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mwtric_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {

            double number_out = 0;

            var number_in = double.Parse(Console.ReadLine());
            var unit_in = Console.ReadLine();
            string unit_out = Console.ReadLine();

            var unitsMap = new[] { "m", "mm", "cm", "mi", "in", "km", "ft", "yd" };


            // allign to metters
            double const_m = 1;
            double const_mm = 1000;
            double const_cm = 100;
            double const_mi = 0.000621371192;
            double const_in = 39.3700787;
            double const_km = 0.001;
            double const_ft = 3.2808399;
            double const_yd = 1.0936133;



                if (unit_in == "m")
                {
                    number_in = number_in / const_m;
                }

                if (unit_in == "mm")
                {
                    number_in = number_in / const_mm;
                }

                if (unit_in == "cm")
                {
                    number_in = number_in / const_cm;
                }

                if (unit_in == "mi")
                {
                    number_in = number_in / const_mi;
                }

                if (unit_in == "in")
                {
                    number_in = number_in / const_in;
                }

                if (unit_in == "km")
                {
                    number_in = number_in / const_km;
                }

                if (unit_in == "ft")
                {
                    number_in = number_in / const_ft;
                }

                if (unit_in == "yd")
                {
                    number_in = number_in / const_yd;
                }





            if (unit_out == "m")
            {
                number_out = number_in * const_m;
            }

            if (unit_out == "mm")
            {
                number_out = number_in * const_mm;
            }

            if (unit_out == "cm")
            {
                number_out = number_in * const_cm;
            }

            if (unit_out == "mi")
            {
                number_out = number_in * const_mi;
            }

            if (unit_out == "in")
            {
                number_out = number_in * const_in;
            }

            if (unit_out == "km")
            {
                number_out = number_in * const_km;
            }

            if (unit_out == "ft")
            {
                number_out = number_in * const_ft;
            }

            if (unit_out == "yd")
            {
                number_out = number_in * const_yd;
            }


            Console.WriteLine("{0} {1}", number_out , unit_out);



        }
    }
}
