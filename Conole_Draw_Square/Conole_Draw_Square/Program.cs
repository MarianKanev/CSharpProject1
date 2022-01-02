using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conole_Draw_Square
{
    class Program
    {
        static void Main(string[] args)
        {

            int numb = int.Parse(Console.ReadLine());



                for (int i = 1; i <= numb; i++)
                {
                    if ( i  == 1 ) { Console.WriteLine("+" + new string('-', numb - 2) + "+"); }
                    else if ( i == numb) { Console.WriteLine("+" + new string('-', numb - 2) + "+"); }
                    else { Console.WriteLine("|" + new string('-', numb - 2) + "|"); }
            }
                         




        }
    }
}
