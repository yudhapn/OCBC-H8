using System;

public class String4
{
    public static void Main(string[] args)
    {
        string stringAwal = "C# membuat string mudah.";

        string substr = stringAwal.Substring(5, 12);
        Console.WriteLine("stringAwal: " + stringAwal);
        Console.WriteLine("subString: " + substr);
    }
}
