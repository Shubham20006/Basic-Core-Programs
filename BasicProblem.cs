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
            // Program to Find the Largest Among Three Numbers

            Console.WriteLine("Enter the Starting Number :- ");
            int N1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Ending Number :- ");
            int N2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Starting Number :- ");
            int N3 = Convert.ToInt32(Console.ReadLine());
            
            if(N1>N2 && N1>N3)
            {
                Console.WriteLine("Greater Number is " + N1);
            }
            else if (N2 > N3 )
            {
                Console.WriteLine("Greater Number is " + N2);
            }
            else
            {
                Console.WriteLine("Greater Number is " + N3);
            }

        }

    }

}

