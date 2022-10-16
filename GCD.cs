using System;
class Program
{
    static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        int GCD  = 0;

        Console.Write("Enter the 1st Number : ");
        num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the 2nd Number : ");
        num2 = Convert.ToInt32(Console.ReadLine());

        GCD = GetGcd(num1,num2);
        Console.WriteLine("\nThe Greatest Common Divisor is: "+GCD);
    }

    static int GetGcd(int number1, int number2)
    {
        int rem = 0;

        while (number2 > 0)
        {
            rem = number1 % number2;
            number1 = number2;
            number2 = rem;
        }
        return number1;
    }
}
