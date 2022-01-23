using System;

namespace factotial
{
    class finding_factorial
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, number4,result;

            // Inputs
            Console.WriteLine("Enter number: ");
            number1 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number4 = Convert.ToInt32(Console.ReadLine());

            // finding_factorial
            result = number1 * number2 * number3 * number4;

            // display result
            Console.WriteLine("{0} * {1} * {2} * {3} = {4}",number1, number2, number3, number4,result); 
        }
    }
}