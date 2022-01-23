using System;

namespace computing_area
{
    class circle_area
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            double pi = 3.1452;

            // prompt the user to enter the radius
            Console.WriteLine("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            // Computing the area with givenradius
            area  = radius * pi;

            Console.WriteLine("The area is {0} * {1} = {2}",radius, pi, area);
        }
    }
}