using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFullCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              
              --This is a Times Table function--
             
                Console.WriteLine("Please enter a number for the times table:");
                int timesTableNum = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, timesTableNum, i * timesTableNum);
                }
                Console.ReadLine();
            -------------------------------------------------------------------------------------

            --This is the FizzBuzz game--

            string fizzBuzzSentence = "";
            for (int i = 1; i <= 15; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    fizzBuzzSentence += "FizzBuzz "; // for numbers divisible by both 3 and 5
                }
                else if (i % 3 == 0)
                {
                    fizzBuzzSentence += "Fizz "; // for numbers divisible by 3
                }
                else if (i % 5 == 0)
                {
                    fizzBuzzSentence += "Buzz "; // for numbers divisible by 5
                }
                else
                {
                    fizzBuzzSentence += i + " "; // for numbers divisible by neither 3 nor 5
                }
            }

            Console.WriteLine(fizzBuzzSentence);
            Console.ReadLine();
            -------------------------------------------------------------------------------------
            */

            //ask user for input, print in order and reverse
            Console.WriteLine("Please input your string: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {
                Console.Write(userInput[i]);
            }
            Console.WriteLine();
            for (int i = userInput.Length-1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }

            Console.ReadLine();
        }
    }
}
