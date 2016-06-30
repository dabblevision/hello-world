using System;

namespace Hello
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Hello, " + name + "!");
            }
            else
            {
                Console.WriteLine("Hello, " + args[1] + "!");
            }
            Console.WriteLine("Today is a " + DateTime.Now.DayOfWeek + ".");
            Console.WriteLine("How many hours of sleep did you get last night?");
            int hoursOfSleep;
            if (int.TryParse(Console.ReadLine(), out hoursOfSleep))
            {
                if (hoursOfSleep >= 8)
                {
                    Console.WriteLine("Your are well rested."); 
                }
                else
                {
                    Console.WriteLine("You are not well rested");
                }
            }
            else
            {
                Console.WriteLine("Couldn't parse your input as an integer.");
                Console.WriteLine("hoursOfSleep variable holds the value: " + hoursOfSleep);
            }
            Console.ReadLine();
        }
    }
}