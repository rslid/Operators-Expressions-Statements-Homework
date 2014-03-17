using System;


namespace Modify_a_Bit_at_Given_Position
{
    class Bit_at_Given_Position
    {
        static void Main()
        {
            int number,position;
            int value;
            Console.Write("Please enter number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("Please enter position: ");
            position = int.Parse(Console.ReadLine());
            Console.Write("Please enter 1 or 0 for value: ");
            value = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number in binary format is "+(Convert.ToString(number, 2).PadLeft(16,'0')));
            

        }
    }
}
