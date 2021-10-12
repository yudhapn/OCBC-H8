using System;

class StringProject
{
    public static void Main(string[] args)
    {
        string nama;
        int age;

        Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
        Console.Write("Masukkan nama: ");
        nama = Console.ReadLine();
        Console.Write("Masukkan alamat: ");
        var alamat = Console.ReadLine();
        Console.Write("Masukkan umur: ");
        age = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Terima Kasih!");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Alamat: {alamat}");
        Console.WriteLine($"Umur: {age} tahun");
        Console.WriteLine("SUDAH DISIMPAN!");

    }
}