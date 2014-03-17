using System;


namespace Four_Digit_Number
{
    class Program
    {
        static void Main()
        {
//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0. Examples:

            Console.Write("Please enter four digit number: ");
            string number;
            number = Console.ReadLine();
            char[] array = number.ToCharArray();
            int sum;
            int first = int.Parse(number[0].ToString());
            int second = int.Parse(number[1].ToString());
            int third = int.Parse(number[2].ToString());
            int fourth = int.Parse(number[3].ToString());
            sum = first + second + third + fourth;
            Console.WriteLine("The sum ofthe digits is: {0}", sum);
            Console.WriteLine("The digits in reversed order: {3}{2}{1}{0}", first,second,third,fourth);
            Console.WriteLine("Last digit in first position: {3}{0}{1}{2}", first, second, third, fourth);
            Console.WriteLine("The second and third digits exchanged: {0}{2}{1}{3}", first, second, third, fourth);

        }
    }
}
