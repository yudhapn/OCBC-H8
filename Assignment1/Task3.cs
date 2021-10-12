using System;

namespace Assignment1
{
    public class Task3
    {
        public void start()
        {
            Console.Write("Enter any Number: ");
            int number = int.Parse(Console.ReadLine());
            int result = findFactorial(number);
            Console.WriteLine($"Factorial of {number} is: {result}");
        }

        private int findFactorial(int number)
        {
            int result = 1;
            for (int i = number; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
