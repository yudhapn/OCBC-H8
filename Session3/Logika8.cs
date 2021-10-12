using System;

public class Logika8
{
    public static void Main(string[] args)
    {
        do
        {
            Console.Write("Input nilai: ");
            int nilai = int.Parse(Console.ReadLine());
            Console.Write("Input start loop: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Input end loop: ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("Input operasi: (+,-,*,/): ");
            string operation = Console.ReadLine();

            for (int i = start; i < end; i++) {
                int currentResult = 0;
                switch (operation)
                {
                    case "+":
                        currentResult = plus(i, nilai);
                        break;
                    case "-":
                        currentResult = minus(i, nilai);
                        break;
                    case "*":
                        currentResult = multiply(i, nilai);
                        break;
                    case "/":
                        currentResult = divide(i, nilai);
                        break;
                    default:
                    Console.Write("\nThere is no any option you choose, kindly choose an option . . .");
                        break;
                }
                Console.WriteLine($"Index ke-{i}: {i} {operation} {nilai} = {currentResult}");
            }
            Console.WriteLine("\nPress [Ctrl + C] to stop the program or Press [Enter] to contine the program . . . .");
            Console.ReadLine();
        } while (true);
    }

    private static int plus(int index, int number) {
        return index + number;
    }
    private static int minus(int index, int number) {
        return index - number;
    }
    private static int multiply(int index, int number) {
        return index * number;
    }
    private static int divide(int index, int number) {
        return index / number;
    }
}
