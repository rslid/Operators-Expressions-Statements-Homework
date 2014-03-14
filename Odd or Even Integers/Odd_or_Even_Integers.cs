using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even_Integers
{
    class Odd_or_Even_Integers
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number for verification, result will be False for Even and True for Odd number: ");
            int num;
            num = Int32.Parse(Console.ReadLine());
            Math.Abs(num);
            if (Math.Abs(num) % 2 == 1)
            {
                Console.WriteLine("Number: " + num);
                Console.WriteLine("Result: True");
            }
            else
            {
                Console.WriteLine("Number: " + num);
                Console.WriteLine("Result: False");
            }
        }
    }
}
