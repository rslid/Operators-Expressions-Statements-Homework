using System;


namespace Bitwise_Extract_Bit
{
    class Bitwise_Extract_Bit
    {
        static void Main()
        {
            int p = 3;
            uint n ;              
            Console.Write("Please enter number for bit extraction: ");
            n = uint.Parse(Console.ReadLine());
            uint nRightP = n >> p;      
            uint bit = nRightP & 1;    
            Console.WriteLine("Third bit of the number has value: " + bit);    

      
        }
     
    }
}
