using System;

namespace Project2
{
    class Overload
    {
        public string name;
        public double phoneNumber;

        public void print(string name)
        {
            this.name = name;
            Console.WriteLine("Namanya adalah: {0}", this.name);
        }

        public void print(double phoneNumber)
        {
            this.phoneNumber = phoneNumber;
            Console.WriteLine("Nomor HP: {0}", this.phoneNumber);
        }
    }
}
