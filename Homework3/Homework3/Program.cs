using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int days;
            int hours;
            int minutes;
            
            Console.Write("Enter Any Amount of Seconds: ");
            string seconds = Console.ReadLine();

            days = int.Parse(seconds) / (60 * 60 * 12);
            Console.WriteLine("Number of day in " + seconds + " seconds is " + days);

            hours = int.Parse(seconds) / (60 * 60);
            Console.WriteLine("Number of hours in " + seconds + " seconds is " + hours);

            minutes = int.Parse(seconds) / 60;
            Console.WriteLine("Number of minutes in " + seconds + " seconds is " + minutes);
            Console.ReadLine();

        }
    }
}
