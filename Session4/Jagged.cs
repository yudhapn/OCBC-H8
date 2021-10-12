using System;

public class Jagged
{
    public static void Main(string[] args)
    {
        int[][] jagged = new int[3][];
        jagged[0] = new int[4];
        jagged[1] = new int[3];
        jagged[2] = new int[5];
        int i;

        for (i = 0; i < jagged[0].Length; i++)
        {
            jagged[0][i] = i;
            Console.Write(jagged[0][i] + " ");
        }
        Console.WriteLine();

        for (i = 0; i < jagged[1].Length; i++)
        {
            jagged[1][i] = i;
            Console.Write(jagged[1][i] + " ");
        }
        Console.WriteLine();

        for (i = 0; i < jagged[2].Length; i++)
        {
            jagged[2][i] = i;
            Console.Write(jagged[2][i] + " ");
        }
        Console.WriteLine();
    }
}
