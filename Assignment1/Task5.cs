using System;

namespace Assignment1
{
    public class Task5
    {
        public void start()
        {
            Console.Write("Enter the Number: ");
            string number = Console.ReadLine().Trim();
            string result = convertNumberToWord(number);
            Console.WriteLine(result);
        }

        private string convertNumberToWord(string strNumber)
        {
            string result = "";
            for (int i = 0; i < strNumber.Length; i++)
            {
                string temp;
                switch (strNumber[i])
                {
                    case '0':
                        temp = "zero";
                        break;
                    case '1':
                        temp = "one";
                        break;
                    case '2':
                        temp = "two";
                        break;
                    case '3':
                        temp = "three";
                        break;
                    case '4':
                        temp = "four";
                        break;
                    case '5':
                        temp = "five";
                        break;
                    case '6':
                        temp = "six";
                        break;
                    case '7':
                        temp = "seven";
                        break;
                    case '8':
                        temp = "eight";
                        break;
                    case '9':
                        temp = "nine";
                        break;
                    default:
                        temp = "NOT_NUMBER";
                        break;
                }
                result += $"{temp} ";
            }
            return result.Trim();
        }
    }
}
