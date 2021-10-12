using System;

namespace Assignment1
{
    public class Task2
    {
        public void start()
        {
            Console.Write("Enter the range=");
            char[,] arr = createTable(int.Parse(Console.ReadLine()));
            printArray(arr);
        }

        private char[,] createTable(int height)
        {
            // Panjang kolom array
            int HEIGHT_LENGTH = height;
            // Panjang max baris array = Rumus Un deret ganjil =  2n - 1 (n = Panjang kolom array)
            int MAX_ROW_LENGTH = (2 * HEIGHT_LENGTH) - 1;
            int CENTER_ELEMENT_INDEX = MAX_ROW_LENGTH / 2;
            char[,] arrNumber = new char[HEIGHT_LENGTH, MAX_ROW_LENGTH];

            for (int i = 0; i < arrNumber.GetLength(0); i++)
            {
                // Jumlah element karakter spasi / ' '
                int spaceCharLength = (HEIGHT_LENGTH - 1) - i;
                // Jumlah baris saat ini (kelipatan ganjil, n = (index kolom saat ini + 1)) 
                int currentRowLength = 2 * (i + 1) - 1;
                // Counter angka
                int currentNumber = 1;
                // Console.WriteLine("spaceCharLength: " + spaceCharLength + "currentRowLength: " + currentRowLength);
                for (int j = 0; j < arrNumber.GetLength(1); j++)
                {
                    // Jika indeks baris saat ini < Jumlah element karakter spasi (daerah kosong sebelah kiri)
                    // Jika indeks baris saat ini > Jumlah element karakter spasi + Jumlah baris saat ini - 1 (daerah kosong sebelah kanan)
                    if (j < spaceCharLength || j > (spaceCharLength + (currentRowLength - 1)))
                    {
                        arrNumber[i, j] = '*';
                    }
                    else
                    {
                        arrNumber[i, j] = Convert.ToChar(currentNumber + '0');
                        // Jika indeks baris saat ini < index elemen tengah, increase number & contrary
                        if (j < CENTER_ELEMENT_INDEX)
                        {
                            currentNumber++;
                        }
                        else
                        {
                            currentNumber--;
                        }
                    }
                }
            }
            return arrNumber;
        }
        private void printArray(char[,] arr)
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
}
