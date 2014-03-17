using System;
using System.Collections.Generic;


namespace Point_Inside_Circle_Outside_Rectangle
{
    class Point_Inside_Circle_Outside_Rectangle
    {
        static void Main()
        {

            double x, y;
            double r = 1.5;
            double circleX = 1;
            double circleY = 1;
            Console.Write("Please enter point x = ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("Please enter point y = ");
            y = Double.Parse(Console.ReadLine());
            bool inside = ((x - circleX) * (x - circleX)) + ((y - circleY) * (y - circleY)) <= (r * r); 
            bool rectXout = (x >= 5) && (x <= -1);
            bool rectYout = (y >= -1) && (y <= 1);
            if ((rectXout == false && rectYout == false) && inside == true)
            {
                Console.WriteLine("Point is inside Circle and Outside Rectangle");
            }
            else
            {
                Console.WriteLine("Point doesn't match condition inside Circle and Outside Rectangle");
            }
        }
    }
}