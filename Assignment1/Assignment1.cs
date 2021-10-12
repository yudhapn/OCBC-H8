using System;

public class Assignment1
{
    public static void Main(string[] args)
    {
        char[,] arr = createTable();
        printArray(arr);
    }

    private static char[,] createTable()
    {
        // Panjang kolom array
        const int HEIGHT_LENGTH = 5;
        // Panjang max baris array = Rumus Un deret ganjil =  2n - 1 (n = Panjang kolom array)
        const int MAX_ROW_LENGTH = (2 * HEIGHT_LENGTH) - 1;
        const int CENTER_ELEMENT_INDEX = MAX_ROW_LENGTH / 2;
        char[,] arrChar = new char[HEIGHT_LENGTH, MAX_ROW_LENGTH];

        for (int i = 0; i < arrChar.GetLength(0); i++)
        {
            // Jumlah element karakter spasi / ' '
            int spaceCharLength = (HEIGHT_LENGTH - 1) - i;
            // Jumlah baris saat ini (kelipatan ganjil, n = (index kolom saat ini + 1)) 
            int currentRowLength = 2 * (i + 1) - 1;
            // Counter angka
            char currentChar = 'A';
            // Console.WriteLine("spaceCharLength: " + spaceCharLength + "currentRowLength: " + currentRowLength);
            for (int j = 0; j < arrChar.GetLength(1); j++)
            {
                // Jika indeks baris saat ini < Jumlah element karakter spasi (daerah kosong sebelah kiri)
                // Jika indeks baris saat ini > Jumlah element karakter spasi + Jumlah baris saat ini - 1 (daerah kosong sebelah kanan)
                if (j < spaceCharLength || j > (spaceCharLength + (currentRowLength - 1)))
                {
                    arrChar[i, j] = '*';
                }
                else
                {
                    arrChar[i, j] = currentChar;
                    // Jika indeks baris saat ini < index elemen tengah, increase number & contrary
                    if (j < CENTER_ELEMENT_INDEX)
                    {
                        currentChar++;
                    }
                    else
                    {
                        currentChar--;
                    }
                }
            }
        }
        return arrChar;
    }

    private static void printArray(char[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
