using System;

namespace comutingproduction
{
    class product
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, number4, number5,number6, result;

            // prompt the user to enter the number
            Console.WriteLine("Enter number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number6 = Convert.ToInt32(Console.ReadLine());

            // computing the product of the
            result = number1 * number2 * number3 * number4 * number5 * number6;

            // Diplay the result
            Console.WriteLine("The product is {0} * {1} * {2} * {3} * {4} * {5} = {6}",number1,number2,number3,number4,number5,number6,result);
        }
    }
}