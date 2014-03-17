using System;

namespace Divide
{
    class Divide
    {
        static void Main()
        {
            //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:

            Console.WriteLine("This program check is it possible number to be diviveded by 5 and 7 in same time without remainder");
            Console.Write("Please enter number: ");
            int num;
            num = Int32.Parse(Console.ReadLine());
            bool result = (num % 5 == 0 && num % 7 == 0);
            Console.WriteLine("Number can be divided by 5 and 7 in the same time: {0}", result );
        }
    }
}
