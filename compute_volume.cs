using System;

namespace compute_volume
{
    class compute_volume
    {
        static void Main(String[] args)
        {
            double radius, height, volume, pi;

            // prompt theuser to enter the radius and pi
            Console.WriteLine("Enter radius: ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter pi: ");
            pi = Convert.ToDouble(Console.ReadLine());

            // computing the volume
            volume = radius * pi * radius;

            // Display the result
            Console.WriteLine("The volume is {0} * {1} * {2} = {3}",radius, radius, pi, volume);
        }
    } 
}