using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class BasicProblem
    {

        public static void Calculate()
        {
            Console.WriteLine("Enter the year between 1000 to 9999. :- ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 1000 && year < 9999)
            {
                int A = (year % 4);
                if (A == 0)
                {
                    Console.WriteLine("This year is a Leap year.");
                }
                else
                {
                    Console.WriteLine("This year is Not a Leap year.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

    }

}

