using System;

class HitungNilai4
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Password: ");
        string password = Console.ReadLine();

        bool isAdult = age > 18;
        bool isPasswordValid = password == "OCBC";

        if (isAdult && isPasswordValid)
        {
            Console.WriteLine("Welcome To The OCBC");
        }
        else
        {
            Console.WriteLine("Sorry, try again!");
        }
    }
}