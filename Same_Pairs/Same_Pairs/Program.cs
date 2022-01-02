using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Same_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {


            int index = 0;
            int sumPair = 0;
            int sumPairTemp = 0;
            int sumPairDifference;
            int sumPairMaxDifference = 0;
            int valueDiff = 0;
            string flag ="";
            int numb = int.Parse(Console.ReadLine());
            numb = numb * 2;
            for (int i = 1; i <= numb; i++)
            {
                int value = int.Parse(Console.ReadLine());
                index = index + 1;
                sumPair = sumPair + value;
                if (index % 2 == 0)
                    {
                    sumPairTemp = sumPair;
                    sumPairDifference = sumPairTemp - sumPair;
                        if (sumPairDifference > sumPairMaxDifference)

                        {
                            sumPairMaxDifference = sumPairDifference;
                            flag = "No";
                        }

                    if (sumPairDifference == sumPairMaxDifference)

                    {
                        valueDiff = sumPair;
                        flag = "Yes";
                    }


                }

                index = 0;
                sumPair = 0;
            }

            if ( flag == "Yes" ) { Console.WriteLine("{0}, value={1}", flag, valueDiff); }
            else { Console.WriteLine("{0}, maxdiff={1}", flag, sumPairTemp); }
        }
    }
}
