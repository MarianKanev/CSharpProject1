namespace Check_Hours_Minutes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            bool hours_check = false;
            bool minutes_check = false;

            if ((hours <= 23) && (hours >= 0))
            {
                hours_check = true;
            }
            else
            {
                Console.WriteLine("Incorrect hour");
            }


            if ((minutes <= 59) && (minutes >= 0))
            {
                minutes_check = true;
            }
            else
            {
                Console.WriteLine("Incorrect minutes");
            }

            if (hours_check == true && minutes_check == true)

            {
                Console.WriteLine("The time is " + hours + ":" + minutes);
            }

            Console.ReadLine();

        }
    }

}
