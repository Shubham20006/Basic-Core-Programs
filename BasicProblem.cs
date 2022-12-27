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
            int tailcount = 0;
            int headcount = 0;
            int tailPercentage;
            int headPercentage;
            Console.WriteLine("Enter no. of flips :- ");
            int flip = Convert.ToInt32(Console.ReadLine());
            if (flip > 0)
            {
                for (int i = 0; i < flip; i++)
                {
                    Random random = new Random();
                    int num = random.Next(2);
                    Console.WriteLine(num);
                    if (num == 0)
                    {
                        tailcount++;
                    }
                    else
                    {
                        headcount++;
                    }
                }
                Console.WriteLine("The tailcount is :- " + tailcount);
                Console.WriteLine("The headcount is :- " + headcount);

                headPercentage = (headcount * 100) / flip;
                tailPercentage = (tailcount * 100) / flip;

                Console.WriteLine("The tailPercentage is :- " + tailPercentage + "%");
                Console.WriteLine("The headPercentage is :- " + headPercentage + "%");
            }
            else
            {
                Console.WriteLine("Please Enter the positive intiger.");
            }

        }

    }

}

