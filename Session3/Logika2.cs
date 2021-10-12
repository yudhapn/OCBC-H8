using System;

public class Logika2
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter a number: ");
        // int nilai = 75;
        int nilai = int.Parse(Console.ReadLine());

        Console.WriteLine($"Nama Kamu: {name}");
        if (nilai < 60)
        {
            Console.WriteLine("Nilai Kamu C");
        }
        else if (nilai < 80)
        {
            Console.WriteLine("Nilai Kamu B");
        }
        else
        {
            Console.WriteLine("Nilai Kamu A");
        }
    }
}