using System;

public class Logika8
{
    public static void Main(string[] args)
    {
        bool isRepeat = true;
        do
        {
            Console.Write("Input nilai: ");
            int nilai = int.Parse(Console.ReadLine());
            Console.Write("Input start loop: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Input end loop: ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("Input operasi: (+,-,*,/) ");
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "-":
                    break;
                default:
                Console.WriteLine("There is no such operation!");
                    break;
            }


            Console.Write("Ulang kembali? (y/n) ");
            string repeat = int.Parse(Console.ReadLine());
            isRepeat = repeat.ToLower == "y";
        } while (isRepeat);
    }

    private static int plus() {
        return -1;
    }
    private static int minus() {
        return -1;
    }
    private static int multiply() {
        return -1;
    }
    private static int () {
        return -1;
    }
}
