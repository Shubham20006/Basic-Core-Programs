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
            //  Program to Check Whether a Number is Even or Odd

            Console.WriteLine("Enter the First Number  :- ");
            int N1 = Convert.ToInt32(Console.ReadLine());

            int a = (N1 % 2);
            if (a == 0)
            { 
                Console.WriteLine("...Even Number...");
            }
            else
            {
                Console.WriteLine( "...Odd Number...");
            }
            
        }

    }

}

