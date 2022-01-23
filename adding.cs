using System;

namespace adding {

public class adding
{
    public static void Main(String[] args) {


        // prompt the user to enter the numbers
        int number1, number2, number3;
        Console.WriteLine("Enter number: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number: ");
        number3 = Convert.ToInt32(Console.ReadLine());

        int sam = number1 + number2 + number3;
        
        Console.WriteLine("The sum of number is " + sam);
    }
}
}