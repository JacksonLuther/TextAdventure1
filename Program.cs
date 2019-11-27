using System;
using System.Threading;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voice over headset: WAKE UP!! You puked all over yourself and passed out!");
            Thread.Sleep(2000);
            Console.WriteLine("Voice over headset: You still need to defuse the bomb!");
            Thread.Sleep(2000);
            Console.WriteLine("Voice over headset: If you don't cut that wire in time we all die!");
            Thread.Sleep(2000);
            Console.WriteLine("Voice over headset: I'm not sure which one you need to cut, choose wisely!");
            Console.WriteLine("Cut the red, green, yellow, or blue wire");
            string response = Console.ReadLine().ToLower();
           
            string red = "red"; //detonate
            string green = "green"; //detonate
            string yellow = "yellow"; //detonate
            string blue = "blue"; // defuse

            if (response == red)
            {
                Console.WriteLine("You died!");
                Environment.Exit(1);
            }
            else if (response == green)
            {
                Console.WriteLine("You died!");
                Environment.Exit(1);
            }
            else if (response == yellow)
            {
                Console.WriteLine("You died!");
                Environment.Exit(1);
            }
            else if (response == blue)
            {
                Console.WriteLine("You successfully defused the bomb!");
            }
        }
    }
}
