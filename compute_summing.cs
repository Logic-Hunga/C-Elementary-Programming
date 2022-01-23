using System;

namespace computing
{
    class compute_summing
    {
        static void Main(string[] args)
        {
            double number1, number2;

            // prompt the user to enter the number the number the the  system
            Console.WriteLine("Enter the number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            double sam = number1 + number2;

            Console.WriteLine("The sum is " + sam);
        }
    }
}
