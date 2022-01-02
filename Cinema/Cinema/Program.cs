using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            string movie_type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            double price = 0.00;

            switch(movie_type)
            {

                case "Premiere":

                    {
                        int total_seats = rows * cols;
                        price = total_seats * 12;
                        break;
                    }

                case "Normal":

                    {
                        int total_seats = rows * cols;
                        price = total_seats * 7.50;
                        break;
                    }


                case "Discount":

                    {
                        int total_seats = rows * cols;
                        price = total_seats * 5;
                        break;
                    }

            }

            Console.WriteLine("{0:f2} leva", price);

        }
    }
}
