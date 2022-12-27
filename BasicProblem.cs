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
            //  Program to Swap Two Numbers

            Console.WriteLine("Enter the First Number  :- ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number :- ");
            int N2 = Convert.ToInt32(Console.ReadLine());
            int a = N1;
            N1 = N2;
            N2 = a;

            Console.WriteLine("...After Swapping...");
            Console.WriteLine("The First Number  is :-  " +N1 );
            Console.WriteLine("The Second Number is :-  " + N2);
        }

    }

}

