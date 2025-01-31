using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFullCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your number:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number to divide by:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            int remainder = number1 % number2;
            Console.WriteLine("The remainder is: " + remainder);
            Console.ReadLine();
        }
    }
}
