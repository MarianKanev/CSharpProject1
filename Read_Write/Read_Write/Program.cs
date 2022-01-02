using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Read_Write
{
    class Program
    {
        static void Main(string[] args)

        {
            double leva;
            double euro;
            //DateTime CurrentDate = DateTime.Now;
            //int numb;
            //String text1;
            //Console.Beep();  // parameters beep function
            //Console.Beep(439, 500);

            try
            {
                leva = double.Parse(Console.ReadLine());
                euro = leva / 1.9885;

                Console.WriteLine(euro);
                Console.ReadLine();
            }
            catch (Exception)
            {

                Console.WriteLine("Please enter digits only !");
                Console.ReadLine();
            }


            

            //StreamWriter sw = new StreamWriter("C:\\tmp\\test11.txt");
            ////===========================================================
            ////Console.WriteLine(CurrentDate);
            ////Console.WriteLine("Press any key ...");
            ////Console.ReadKey();

            ////===========================================================

            ////numb = (Console.Read());

            //// for (int i = 0; i < numb; i++)
            //// {
            ////     Console.WriteLine(i);
            //// }

            //// Console.ReadKey();

            ////===========================================================
            //text1 = Console.ReadLine();
            //numb = Int32.Parse(text1);

            //for (int i = 0; i < numb; i++)
            //{
            //    CurrentDate = DateTime.Now;
            //    Console.WriteLine(CurrentDate + "      " + i);
            //    sw.WriteLine(CurrentDate + "      " + i);
     
            //}

            //sw.Close();
            //Console.WriteLine("Press any key ...");
            //Console.ReadKey();


        }
    }
}
