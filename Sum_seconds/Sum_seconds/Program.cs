using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int player_1 = int.Parse(Console.ReadLine());
            int player_2 = int.Parse(Console.ReadLine());
            int player_3 = int.Parse(Console.ReadLine());

            int result = player_1 + player_2 + player_3;

            int seconds = result % 60;
            int minutes = result / 60;

            Console.WriteLine("{0}:{1:00}",minutes,seconds);
        }
    }
}
