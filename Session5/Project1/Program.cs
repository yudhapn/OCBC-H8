using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();

            laptop1.merk = "lenovo";
            laptop1.ram = 4;
            laptop1.memory = 128;

            Console.WriteLine("\nMerk Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("Kapasitas Ram ada {0}", laptop1.ram);
            Console.WriteLine("Kapasitas Memory ada {0}", laptop1.memory);

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();
        }
    }
}
