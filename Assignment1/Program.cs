using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();
            Task4 task4 = new Task4();
            Task5 task5 = new Task5();
            Task6 task6 = new Task6();

            while (true)
            {
                Console.WriteLine("=========== Welcome To Assignment 1 ===========");
                Console.WriteLine("==== Choose Number Task From Assignment 1 ====");
                Console.WriteLine("1. Task 1 (Triangle With Constant Height)");
                Console.WriteLine("2. Task 2 (Triangle With Height Input By User)");
                Console.WriteLine("3. Task 3 (Factorial)");
                Console.WriteLine("4. Task 4 (Reverse Number)");
                Console.WriteLine("5. Task 5 (Convert Number To Alphabet Number)");
                Console.WriteLine("6. Task 6 (Is It A Palidrome?)");
                Console.WriteLine("7. About Me (Coder Profile)");
                Console.Write("\nChoose number: ");
                string currentTaskNumber = Console.ReadLine();
                switch (currentTaskNumber)
                {
                    case "1":
                        task1.start();
                        break;
                    case "2":
                        task2.start();
                        break;
                    case "3":
                        task3.start();
                        break;
                    case "4":
                        task4.start();
                        break;
                    case "5":
                        task5.start();
                        break;
                    case "6":
                        task6.start();
                        break;
                    case "7":
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

        private static void printCoderProfile() {
            Console.WriteLine("\n====== Coder Profile ======");
            Console.WriteLine("Name\t\t\t: Yudha Pratama Nursam");
            Console.WriteLine("Participant Number\t: Yudha Pratama Nursam");
            Console.WriteLine("Address\t\t\t: Kota Malang");
        }
    }
}
