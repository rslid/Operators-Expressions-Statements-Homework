using System;


namespace Point_in_a_Circle
{
    class Point_in_a_Circle
    {
        static void Main()
        {
            double x, y;
            bool inside;
            int r = 2;
            Console.Write("Please enter point x = ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Please enter point y = ");
            y = Double.Parse(Console.ReadLine());
            inside = ((x * x) + (y * y) <= r * r);
            Console.WriteLine(inside);
        }
    }
}
