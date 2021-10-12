using System;

public class Data2
{
    public static void Main(string[] args)
    {
        string[] contoh = new string[4] {
            "Motherborad", "Processor", "Power Supply", "Video Card"
        };

        Console.WriteLine("Menampilkan semua data dalam array");
        Console.WriteLine("");

        foreach (string component in contoh)
        {
            Console.WriteLine(component);
        }

        Console.Write("Press any key to continue . . .");
    }
}
