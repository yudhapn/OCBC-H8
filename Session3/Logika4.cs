using System;

public class Logika4
{
    private const int MIN_A_SCORE = 85;
    private const int MIN_B_SCORE = 65;
    private const int MIN_C_SCORE = 45;
    private const int MIN_D_SCORE = 25;
    public static void Main(string[] args)
    {
        double nilai;
        Console.Write("Nilai: ");
        nilai = Convert.ToDouble(Console.ReadLine());
        printScore(nilai);
    }

    private static void printScore(double nilai)
    {
        if (nilai >= MIN_A_SCORE)
        {
            Console.WriteLine("Kamu mendapat grade A");
        }
        else if (nilai >= MIN_B_SCORE)
        {
            Console.WriteLine("Kamu mendapat grade B");
        }
        else if (nilai >= MIN_C_SCORE)
        {
            Console.WriteLine("Kamu mendapat grade C");
        }
        else if (nilai <= MIN_D_SCORE)
        {
            Console.WriteLine("Kamu mendapat grade D");
        }
    }
}
