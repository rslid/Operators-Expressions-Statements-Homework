using System;

namespace ThirdDigitSeven
{
    class ThirdDigitSeven
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter at least 3 digit number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = number / 100;
            int result = sum % 10;
            if (result == 7)
            {
                Console.WriteLine("Third digit is 7");
            }
            else
            {
                Console.WriteLine("Third digit is not 7");
            }
        }
    }
}
