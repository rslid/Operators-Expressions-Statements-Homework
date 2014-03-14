using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravity
{
    class GravityMoon
    {
        static void Main(string[] args)
        {
            //The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates 
            //the weight of a man on the moon by a given weight on the Earth. 

            Console.WriteLine("This program calculates how much will be your weight on the Moon");
            Console.Write("Please enter your weight on Earth in kg (81,2) : ");
            double weight, moonWeight;
            weight = Double.Parse(Console.ReadLine());

            moonWeight = weight * 0.17;
            Console.WriteLine("Your weight on the moon will be: {0}", moonWeight);

        }
    }
}
