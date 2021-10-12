using System;

namespace Assignment1
{
    public class Task4
    {
        public void start()
        {
            Console.Write("Enter a Number: ");
            string number = Console.ReadLine();
            string result = reverseNumber(number);
            Console.WriteLine($"Reverse Number: {result}");
        }

        private string reverseNumber(string strNumber)
        {
            string result = "";
            for (int i = strNumber.Length - 1; i >= 0; i--)
            {
                result += strNumber[i];
            }
            return result;
        }
    }
}
