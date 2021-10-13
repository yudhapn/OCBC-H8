using System;

namespace Project2
{
    class Program : Override
    {
        public override void penjumlahanPerkalianDll()
        {
            Console.WriteLine("Overriding 2..... ====>>>>>");
            Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}", bilangan1, bilangan2, (bilangan1 / bilangan2));
            Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2}", bilangan1, bilangan2, (bilangan1 - bilangan2));
        }
        static void Main(string[] args)
        {
            Pesawat pesawatTempur = new PesawatTempur();
            pesawatTempur.name = "Sukhoi Su-30";
            pesawatTempur.wheelAmount = 4;
            pesawatTempur.passengerAmount = 2;
            pesawatTempur.height = "1500 kaki";
            Console.WriteLine();

            Overload overload = new Overload();
            Override ovrd = new Override();

            while (true)
            {
                Console.WriteLine("=========== Welcome To Sesion 5 ===========");
                Console.WriteLine("==== Choose Number Task From Sesion 5 ====");
                Console.WriteLine("1. Task 1 (Pesawat Tempur)");
                Console.WriteLine("2. Task 2 (Overload)");
                Console.WriteLine("3. Task 3 (Override)");
                Console.WriteLine("4. About Me (Coder Profile)");
                Console.Write("\nChoose number: ");
                string currentTaskNumber = Console.ReadLine();
                switch (currentTaskNumber)
                {
                    case "1":
                        Console.WriteLine("=== Output Inheritance & Polymorphism ===");
                        pesawatTempur.terbang();
                        pesawatTempur.sudahTerbang();
                        break;
                    case "2":
                        Console.WriteLine("=== Output overload method with params string ===");
                        overload.print("Foxy");
                        Console.WriteLine();
                        Console.WriteLine("=== Output overload method with params double ===");
                        overload.print(081122334455);
                        break;
                    case "3":
                        Console.WriteLine();
                        ovrd.bilangan(10, 5);
                        ovrd.penjumlahanPerkalianDll();
                        ovrd = new Program();
                        ovrd.bilangan(20, 5);
                        Console.WriteLine();
                        ovrd.penjumlahanPerkalianDll();
                        break;
                    case "4":
                        printCoderProfile();
                        break;
                    default:
                        Console.Write("\nThere is no any option you choose, kindly choose an option . . .");
                        break;
                }
                Console.WriteLine("\nPress [Ctrl + C] to stop the program or Press [Enter] to contine the program . . . .");
                Console.ReadLine();
            }
        }
        private static void printCoderProfile()
        {
            Console.WriteLine("\n====== Coder Profile ======");
            Console.WriteLine("Pengalaman saya mempelajari bahasa c# ini menyenangkan\nkarena sudah familiar dengan sintaknya,\nkesulitannya adalah sering lupa dengan semicolon");
        }
    }
}
