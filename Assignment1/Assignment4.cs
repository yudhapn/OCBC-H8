using System;

public class Assignment4
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number: ");
        string number = Console.ReadLine();
        string result = reverseNumber(number);
        Console.WriteLine($"Reverse Number: {result}");
    }

    private static string reverseNumber(string strNumber)
    {
        string result = "";
        for (int i = strNumber.Length - 1; i >= 0; i--)
        {
            result += strNumber[i];
        }
        return result;
    }
}
