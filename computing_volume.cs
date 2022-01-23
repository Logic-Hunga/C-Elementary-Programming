using System;

namespace computing
{
    class computing_volume
    {
        static void Main(string[] args)
        {
            double length, height;
            // prompt the user to enter the height nad the length of the volume
            Console.WriteLine("Enter height: ");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter lenght: ");
            length = Convert.ToDouble(Console.ReadLine());

            // Compute the area of the square
            double  area = length * height;
           
           // Display the out put
           Console.WriteLine("The area is : " + area);
           Console.WriteLine("The area is {0} * {1} = {2}",length,height,area);  
        }
    }
}