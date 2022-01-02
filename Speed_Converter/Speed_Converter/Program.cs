using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Converter
{
    class Program
    {
        static void Main(string[] args)
            {

            float distance_meters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float total_time_hours = hours + minutes / 60 + seconds / 3600;
            float total_time_seconds = hours * 3600 + minutes * 60 + seconds;

            float kilometers_hours = (distance_meters/1000) / total_time_hours;
            float meters_seconds = distance_meters / total_time_seconds;
            float mile_hours = ( distance_meters/1609) / total_time_hours;

            //Console.WriteLine("Speed m/s = " + meters_seconds);
            //Console.WriteLine("Speed km/h = " + kilometers_hours);
            //Console.WriteLine("Speed mph = " + mile_hours);

            Console.WriteLine( meters_seconds);
            Console.WriteLine(kilometers_hours);
            Console.WriteLine(mile_hours);

        }
    }
}
