using System;

namespace Assignment1
{
    public class Task6
    {
        public void start()
        {
            Console.Write("Enter the Word: ");
            string str = Console.ReadLine().Trim();
            string result = isPalindrome(str) ? "Palindrome" : "Not Palindrome";
            Console.WriteLine($"{str} is {result}");
        }

        private bool isPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - i - 1]) {
                    return false;
                }
            }
            return true;
        }
    }
}
