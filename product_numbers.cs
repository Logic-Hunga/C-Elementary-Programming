using System;

namespace product
{
    class product_numbers
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, product;
            Console.WriteLine("Enter number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            product = number1 * number2 * number3;

            Console.WriteLine("{0} * {1} * {2} = {3}", number1, number2, number3, product);
        }
    }
}