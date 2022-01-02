using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonuses
{
    class Program
    {
        static void Main(string[] args)
        {

            string town = Console.ReadLine();
            double sales_volume = double.Parse(Console.ReadLine());
            double bonus = 0;
            char error_flag = ' ';

            if ((sales_volume >= 0) && (sales_volume <= 500))
            {
                switch (town)
                {
                    case "Sofia" : bonus = (sales_volume * 5) / 100; break;
                    case "Varna": bonus = (sales_volume * 4.5) / 100; break;
                    case "Plovdiv": bonus = (sales_volume * 5.5) / 100; break;
                    default: error_flag = 'X';break;
                }
            }


            if ((sales_volume > 500) && (sales_volume <= 1000))
            {
                switch (town)
                {
                    case "Sofia": bonus = (sales_volume * 7) / 100; break;
                    case "Varna": bonus = (sales_volume * 7.5) / 100; break;
                    case "Plovdiv": bonus = (sales_volume * 8) / 100; break;
                    default: error_flag = 'X'; break;

                }
            }

            if ((sales_volume > 1000) && (sales_volume <= 10000))
            {
                switch (town)
                {
                    case "Sofia": bonus = (sales_volume * 8) / 100; break;
                    case "Varna": bonus = (sales_volume * 10) / 100; break;
                    case "Plovdiv": bonus = (sales_volume * 12) / 100; break;
                    default: error_flag = 'X'; break;

                }
            }

            if (sales_volume > 10000)
            {
                switch (town)
                {
                    case "Sofia": bonus = (sales_volume * 12) / 100; break;
                    case "Varna": bonus = (sales_volume * 13) / 100; break;
                    case "Plovdiv": bonus = (sales_volume * 14.5) / 100; break;
                    default: error_flag = 'X'; break;

                }
            }

            if (sales_volume < 0) { error_flag = 'X'; }

            if (error_flag == 'X')
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2}",bonus);
            }
        }
    }
}
