using System;

namespace Computing_culinder_volumetric
{
    class Cylinder_volume
    {
        static void Main(string[] args)
        {
            // declare the variables
            double volume,radius,height;
            double pi = 3.1463;

            // promp the iuser to enter the variables
            Console.WriteLine("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());

            // Computing the volume
            volume = radius * radius * pi * height;

            // Display the results
            Console.WriteLine("The volume is: ");
            Console.WriteLine(volume); 
        }
    }
}