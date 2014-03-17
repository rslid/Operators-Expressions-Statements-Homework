using System;


namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.Write("Please enter rectangle width: ");
            double width,height,perimeter,area;
            width = Double.Parse(Console.ReadLine());
            Console.Write("Please enter rectangle height: ");
            height = Double.Parse(Console.ReadLine());
            perimeter = (2 * width) + (2 * height);
            area = height * width;
            Console.WriteLine("The Perimeter of rectangle is {0}", perimeter);
            Console.WriteLine("The Area of rectangle is {0}",area);
        }
    }
}
