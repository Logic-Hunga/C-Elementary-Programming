using System;

namespace divisions
{
    class division
    {
        static void Main(String[] args)
        {
            // Declare the numbers" data type
            int number1; 
            int number2;
            int qutient;

            // prompt the user to enter the numbers
            Console.WriteLine("Enter the number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number: ");
            number2 = Convert.ToInt32(Console.ReadLine()); 

            // Cumputing
            qutient = number1 / number2;

            // Display the result
            Console.WriteLine("The qutient is  of: {0} / {1} = {2}", number1, number2,qutient);
        }
    }
}