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
          //  Program to Compute Quotient and Remainder

            Console.WriteLine("Enter the Number that you want to devide(dividend). :- ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number (Divisor). :- ");
            int N2 = Convert.ToInt32(Console.ReadLine());
            int Quotient = (N1 / N2);
            int REMAINDER = (N1 % N2);
            Console.WriteLine("The Quotient is :-  " + Quotient);
            Console.WriteLine("The Remainder is :-  " + REMAINDER);
        }

    }

}

