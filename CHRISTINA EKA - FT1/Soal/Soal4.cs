using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Soal
{
    public class Soal4 : LogicBase
    {
        public Soal4(int n, int m)
        {
            JmlBaris = n;
            JmlKolom = JmlBaris;
            AngkaAwal = m;
            Array2D = new string[JmlBaris, JmlKolom];
            IsiArray();
            FunctionBase.printArray2D(Array2D);
        }

        private void IsiArray()
        {
            int panjang = (JmlBaris - 1) * 3;
            string[] deret = new string[panjang];
            int angka = AngkaAwal;
            int tambah;

            if (AngkaAwal%2 == 0)
            {
                tambah = -1;
            }
            else
            {
                tambah = 0;
            }

            for (int i=0; i<panjang; i++)
            {
                if (i % 2 == 0)
                {
                    deret[i] = angka.ToString();
                    tambah += 2;
                    angka += tambah;
                }
                else
                {
                    deret[i] = "*";
                }
            }

            int min = 0;
            int max = panjang - 1;
            for (int b=JmlBaris-1; b>=0; b--)
            {
                for (int k=JmlKolom-1; k>=0; k--)
                {
                    if (k == JmlKolom-1 || b == 0)
                    {
                        Array2D[b, k] = deret[min].ToString();
                        min++;
                    }
                    else if (b == k)
                    {
                        Array2D[b, k] = deret[max].ToString();
                        max--;
                    }
                }
            }
        }
    }
}
