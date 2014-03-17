using System;


namespace Check_Bit_at_Given_Position
{
    class Check_Bit_at_Given_Position
    {
        static void Main()
        {
            int p;
            uint n;
            Console.Write("Please enter number for bit extraction: ");
            n = uint.Parse(Console.ReadLine());
            Console.Write("Please enter position for bit extraction: ");
            p = int.Parse(Console.ReadLine());
            uint change = n >> p;
            bool bit = change == 1;
            Console.WriteLine("Bit at position {1} has value: {0} ", bit, p);


        }
    }
}
