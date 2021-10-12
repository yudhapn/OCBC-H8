using System;

public class Length
{
    public static void Main(string[] args)
    {
        int[] angka = new int[10];
        Console.WriteLine("Panjang array angka adalah {0}", angka.Length);

        for (int i = 0; i < angka.Length; i++)
        {
            angka[i] = i * i;
            Console.Write(angka[i] + " ");
        }
        Console.WriteLine();
    }
}
