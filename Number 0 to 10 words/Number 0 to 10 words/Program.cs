using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0_to_10_words
{
        class Program
        {
            static void Main(string[] args)
            {

                int number = int.Parse(Console.ReadLine());


                string number_words;

                number_words = "";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

                if (number >= 0 && number < 10)

                {
                    number_words = unitsMap[number];
                    Console.WriteLine(unitsMap[number]);

                }

                else

                {
                    Console.WriteLine("number too big");
                }


            }
        }
    }

