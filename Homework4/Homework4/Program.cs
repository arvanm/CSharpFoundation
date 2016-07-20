using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter at Number you wish to see the factorial n!");

            string str = Console.ReadLine();

            int number = int.Parse(str);
            int[] arraynumber = new int[number];
            int multiply = number;

            for (int i = 1; i < arraynumber.Length; i++)
            {
                multiply = multiply * i;
            }

            Console.WriteLine(" The factorial number for " + number + " is: {0}", multiply);
            Console.ReadLine();


        }
    }
}
