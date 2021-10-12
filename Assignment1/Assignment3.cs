using System;

public class Assignment3
{
    public static void Main(string[] args)
    {
        Console.Write("Enter any Number: ");
        int number = int.Parse(Console.ReadLine());
        int result = findFactorial(number);
        Console.WriteLine($"Factorial of {number} is: {result}");
    }

    private static int findFactorial(int number)
    {
        int result = 1;
        for (int i = number; i >= 1; i--)
        {
            result *= i;
        }
        return result;
    }
}
