using System;

namespace Name
{
    class summing_numbers
    {
        static void Main(String[] args)
        {   
            // declare the variables
            int number1,number2,result;
            Console.WriteLine("Enter number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            // computing the summation
            result = number1 + number2;

            Console.WriteLine("{0} + {1} = {2}",number1,number2,result);

            Console.WriteLine("press any key to exit");
        //    Console.Readkey();

        }
    }
}