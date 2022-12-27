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
            // Program to Check Whether an Alphabet is Vowel or Consonant
           
            Console.WriteLine("Enter the Single character  :- ");
            char ch = Convert.ToChar(Console.ReadLine());
           

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U') 
            { 
                Console.WriteLine("...VOWEL...");
            }
            else
            {
                Console.WriteLine( "...CONSONANT...");
            }
            
        }

    }

}

