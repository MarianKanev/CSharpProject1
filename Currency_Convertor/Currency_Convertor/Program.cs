using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            string curr_input = Console.ReadLine();
            string curr_out = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            double bgn_usd = Math.Round(value * 1.79549,2);
            double bgn_eur = Math.Round(value * 1.95583,2);
            double bgn_gbp = Math.Round(value * 2.53405,2);

            switch (curr_out)
            {
                case "BGN":
                    {

                    }

                case: 


            }


            bgn = Math.Round(bgn, 2);

            Console.WriteLine(bgn);

        }
    }
}
