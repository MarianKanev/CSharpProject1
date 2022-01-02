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

            string str1 = Console.ReadLine();

            bool yes_no = Convert.ToBoolean(str1);

            if (yes_no == true)
            {
                Console.WriteLine("Yes");
            }

            if (yes_no == false)
            {
                Console.WriteLine("No");
            }

        }
    }
}
