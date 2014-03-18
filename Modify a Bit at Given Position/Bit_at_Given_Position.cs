using System;


namespace Modify_a_Bit_at_Given_Position
{
    class Bit_at_Given_Position
    {
        static void Main()
        {
            int number;
            int position;
            int value;
            int mask;
            int result;
            Console.Write("Please enter number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number in binary format is " + (Convert.ToString(number, 2).PadLeft(16, '0')));
            Console.Write("Please enter position: ");
            position = int.Parse(Console.ReadLine());
            Console.Write("Please enter v (1 or 0): ");
            value = int.Parse(Console.ReadLine());
            mask = value << position;
            result = number | mask;
            if (value == 0)
                {
                    mask = ~(1 << position);
                    result = number & mask;
                }
            Console.WriteLine("Your new number in binary format is " + (Convert.ToString(result, 2).PadLeft(16, '0')));
            Console.WriteLine("Your new number is {0}",result);
        }
    }
}
