using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        string fname, lname, address, birthdate, isMale;
        int umur;
        Console.Write("Enter your first name: ");
        fname = Console.ReadLine();
        Console.Write("Enter your first name: ");
        lname = Console.ReadLine();
        Console.Write("Enter your age: ");
        umur = int.Parse(Console.ReadLine());
        Console.Write("Enter your address: ");
        address = Console.ReadLine();
        Console.Write("Enter your birthdate: ");
        birthdate = Console.ReadLine();
        Console.Write("Are you a male? (y or n):  ");
        isMale = Console.ReadLine();
        isMale = isMale == "y" ? "male" : "female";

        Console.WriteLine("\nUr full name is " + fname + " " + lname);
        Console.WriteLine("Your age is " + umur);
        Console.WriteLine("Your address is " + address);
        Console.WriteLine("Your birthdate is " + birthdate);
        Console.WriteLine("You are a " + isMale);
    }
}