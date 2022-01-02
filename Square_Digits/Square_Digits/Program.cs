using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Digits
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
      
            for (var row = 1; row <= n; row++)
            {
                for (var col= row; col < row + n; col++)
                {


                    if (col <= n)

                        Console.Write(col + " ");

                    else
                    {
                        Console.Write((n-(col-n)) + " ");
                    }
                           

                }
                Console.WriteLine();

            }




        }
    }
}
