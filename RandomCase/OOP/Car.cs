using System;

namespace OOP
{
    public class Car
    {
        public string name = "Old Car";

        public Car(string name)
        {
            this.name = name;
            Console.WriteLine($"An car instance has created with name: {name}");
        }
        public Car()
        {
            Console.WriteLine($"An car instance has created with name: {name}");
        }
    }
}