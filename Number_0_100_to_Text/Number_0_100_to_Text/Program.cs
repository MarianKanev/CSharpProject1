using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());



            string dec;
            string dig;

            string number_words;

            number_words = "";

            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number >= 0 && number < 20)

            {
                number_words = unitsMap[number];
                
            }
            
            if (number > 19 && number < 100)

            {

                int numb_dec = number / 10;
                int numb_dig = number % 10;

                dec = tensMap[numb_dec];
                dig = unitsMap[numb_dig];

                if (numb_dig == 0)
                {
                    number_words = dec;
                }
                else 
                {
                    number_words = dec + " " + dig;
                }

            }

            if (number == 100)
            {
                number_words = "one hundred";
            }

            if (number < 0 || number > 100)
            {
                number_words = "invalid number";
            }

            Console.WriteLine(number_words);

            
        }
    }
}
