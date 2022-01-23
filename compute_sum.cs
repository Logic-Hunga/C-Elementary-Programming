using System;

namespace factotial
{
    class compute_sum
    {
        static void Main(string[] args)
        {
            int number1, number2, number3,result;

            // promp the user to enter numbers 
            Console.WriteLine("Enter number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            // compute the sum of the numbers
            result = number1 + number2 + number3;

            // Display the sum of the
            Console.WriteLine("The sum of numbers:  {0} + {1} + {2} = {3}", number1, number2, number3,result);
            
        }
    }
}