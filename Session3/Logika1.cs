using System;

public class Logika1
{
    public static void Main(string[] args)
    {
        // int a = 92;
        // int b = 53;
        Console.Write("enter number for 'a': ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("enter number for 'b': ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("a lebih besar dari b");
        }
        else if (a >= b)
        {
            Console.WriteLine("a lebih besar dari sama dengan b");
        }
        else if (a < b)
        {
            Console.WriteLine("a lebih kecil dari b");
        }
        else if (a <= b)
        {
            Console.WriteLine("a lebih kecil dari sama dengan b");
        }
        else if (a == b)
        {
            Console.WriteLine("a sama dengan b");
        }
        else if (a != b)
        {
            Console.WriteLine("a tidak sama dengan b");
        }
    }
}