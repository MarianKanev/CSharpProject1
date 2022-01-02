using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_Days_after_Birth
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime birth_date = DateTime.ParseExact((Console.ReadLine()),"dd-MM-yyyy", CultureInfo.InvariantCulture);

            birth_date = birth_date.AddDays(999);
            birth_date= birth_date.Date;
            Console.WriteLine(birth_date.ToString("dd-MM-yyyy"));

        }
    }
}
