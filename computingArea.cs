using System;

namespace  computingArea
{
    class computingArea
    {
        static void Main(string[] args)
        {
            double radius,height,area; //volume;

            // prompt the user to enter  the  radius and height
            Console.WriteLine("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());

            // computing the area volume and the volume of the circle
            area  = radius * radius * Math.PI;

            // Display the output
            Console.WriteLine("The area is " + area);
        }
    }
}