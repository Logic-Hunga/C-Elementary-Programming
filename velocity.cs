using System;

namespace velocity
{
    class velocity
    {
        static void Main(String[] args)
        {
            // prompt the user to enter the time and distace
            // double time, distance;
            Console.WriteLine("Enter time: ");
            double time = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the distance: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            // computing the velocity of the car
            double velocity = distance / time;

            // Display t he velocity of the car
            Console.WriteLine("The velocity is " + velocity + "m/s");
        }
    }
}