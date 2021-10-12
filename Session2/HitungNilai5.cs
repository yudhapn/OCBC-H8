using System;

class HitungNilai4
{
    private const string VALID_PASSWORD = "OCBC";
    private const string VALID_USERNAME = "ypran";
    private const int MIN_AGE = 18;
    private static int age, pertama, kedua, ketiga, total;
    private static double rata;
    private static bool isMarried;
    private static string username, password, gender;
    public static void Main(string[] args)
    {

        inputUserCredential();
        if (verifUserCredential(username, password, age))
        {
            inputUserBiodata();
            inputData();
            printUserBiodata();
            calculateData();
            printDataResult();
        }
        else
        {
            Console.WriteLine("Sorry, try again!");
        }
    }

    static bool verifUserCredential(string username, string password, int age)
    {
        return username == VALID_USERNAME && password == VALID_PASSWORD && age > MIN_AGE;
    }

    static void inputUserCredential()
    {
        Console.Write("Enter your age: ");
        age = int.Parse(Console.ReadLine());
        Console.Write("Username: ");
        username = Console.ReadLine();
        Console.Write("Password: ");
        password = Console.ReadLine();
    }
    static void inputUserBiodata()
    {
        Console.WriteLine("Welcome To The OCBC");
        Console.WriteLine("\n===Masukkan Biodata===");
        Console.Write("Gender (l/f): ");
        gender = Console.ReadLine() == "l" ? "Laki-laki" : "Perempuan";
        Console.Write("Married Status (y/n): ");
        isMarried = Console.ReadLine() == "y";
    }

    static void inputData()
    {
        Console.WriteLine("\n===Menghitung Nilai===");
        Console.Write("Masukkan nilai PERTAMA: ");
        pertama = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai KEDUA: ");
        kedua = int.Parse(Console.ReadLine());
        Console.Write("Masukkan nilai KETIGA: ");
        ketiga = int.Parse(Console.ReadLine());
    }

    static void printUserBiodata()
    {
        Console.WriteLine("\n===Biodata===");
        Console.WriteLine($"Username: {username}");
        Console.WriteLine($"Password: {password}");
        Console.WriteLine($"Gender: {gender}");
        Console.WriteLine($"Married Status: {isMarried}");
    }
    static void calculateData()
    {
        total = pertama + kedua + ketiga;
        rata = total / 3.0;
    }

    static void printDataResult()
    {
        Console.WriteLine("Total Nilai adalah: " + total);
        Console.WriteLine("Rata-Rata Nilai adalah: " + rata);
        Console.ReadLine();
    }
}
