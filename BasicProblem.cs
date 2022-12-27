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
            double sum = 0;
            Console.WriteLine("Enter the  value :- ");
            double N = Convert.ToDouble(Console.ReadLine());

            if (N > 0)
            {

                for (int i = 1; i <= N; i++)
                {
                    Console.Write("1/" + i + " + ");
                    sum = sum + (1 / (double)i);
                }
                Console.WriteLine("\n\nThe Nth harmonic number is :- " + sum);
            }
            else
            {
                Console.WriteLine("Enter number greater than 0.");
            }
        }

    }

}

