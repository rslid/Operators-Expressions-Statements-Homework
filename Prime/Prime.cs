using System;

namespace Prime
{
    class Prime
    {
        static void Main()
        {
            Console.Write("Please enter a positive number: ");
            int number = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(number);
            bool isPrime = true;
            while (isPrime && (divider <= maxDivider))
            {
                if (number % divider == 0)
            {
                isPrime = false;
            }
            divider++;
            }
            Console.WriteLine("Prime? " + isPrime);
        }
    }
}
