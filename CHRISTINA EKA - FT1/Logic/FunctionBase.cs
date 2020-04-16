using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class LogicBase
    {
        public int JmlBaris { get; set; } // get untuk mengambil value; set untuk mengisi value
        public int JmlKolom { get; set; }
        public int JmlBangun { get; set; }
        public int LbrBangun { get; set; }
        public int AngkaAwal { get; set; }
        public int Selisih { get; set; }
        public string[,] Array2D { get; set; }
        public string[] Array1D { get; set; }
    }

    public class FunctionBase
    {
        public static int counter(int x)
        {
            int hasil = 0;
            for (int b = 1; b <= x; b++)
            {
                hasil = hasil + b;
            }
            return hasil;
        }

        public static int[] deret(int x)
        {
            int[] hasil = new int[x];
            int angka = 1;
            for (int b = 0; b < x; b++)
            {
                hasil[b] = angka;
                angka++;
            }
            return hasil;
        }


        public static int[] ganjil(int x)
        {
            int[] hasil = new int[x];
            int angka = 1;
            for (int b = 0; b < x; b++)
            {
                hasil[b] = angka;
                angka += 2;
            }
            return hasil;
        }

        public static int[] genap(int x)
        {
            int[] hasil = new int[x];
            int angka = 0;
            for (int b = 0; b < x; b++)
            {
                hasil[b] = angka;
                angka += 2;
            }
            return hasil;
        }

        public static void printArray2D(string[,] array)
        {
            for (int b = 0; b < array.GetLength(0); b++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write(" {0}\t", array[b, k]);
                }
                Console.WriteLine("\n");
            }
        }

        public static void printArrayBiasa(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(" {0}\t", array[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
