using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangleof55Stars
{
    class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            
                for (int i = 1; i <= size; i++)

                
                {
                    for (int j = 1; j <= size; j++)
                    {
//                        if (j == 1) Console.Write("*");
                 
                        if ((i == 1) || (i == size))
                            {
                                 Console.Write("*");
                            } 
                        
                        else
                        {

                        Console.Write("");

                        }  
                           Console.Write(" ");
                        if (j == size) Console.Write("*");  
                    }

                    Console.WriteLine();
                }

        }
    }
}
