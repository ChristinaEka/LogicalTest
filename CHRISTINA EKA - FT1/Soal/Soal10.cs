using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Soal
{
    public class Soal10 : LogicBase
    {
        public Soal10(int n, int m, int o)
        {
            AngkaAwal = n;
            Selisih = m;
            JmlBaris = o * 3;
            JmlKolom = JmlBaris;
            LbrBangun = o;
            Array2D = new string[JmlBaris, JmlKolom];
            IsiArray();
            FunctionBase.printArray2D(Array2D);
        }

        private void IsiArray()
        {
            int panjang = (LbrBangun * 2) + ((LbrBangun - 2) * 2);
            string[] deret = new string[panjang];
            int angka = AngkaAwal;
            for (int i = 0; i<panjang; i++)
            {
                deret[i] = angka.ToString();
                angka += Selisih;
            }

            int min = 0;
            int max = (LbrBangun * 2) + ((LbrBangun - 2) * 2) - 1;
            for (int b=0; b<LbrBangun; b++)
            {
                for (int k=0; k<LbrBangun; k++)
                {
                    if (b == 0)
                    {
                        Array2D[b, k] = deret[min];                                                 //kiri atas
                        Array2D[b, JmlKolom - LbrBangun + k] = deret[min];                          //kanan atas
                        Array2D[JmlBaris - LbrBangun + b, k] = deret[min];                          //kiri bawah
                        Array2D[JmlBaris - LbrBangun + b, JmlKolom - LbrBangun + k] = deret[min];   //kanan bawah
                        min++;
                    }
                    else if (k == 0)
                    {
                        Array2D[b, k] = deret[max];
                        Array2D[b, JmlKolom - LbrBangun + k] = deret[max];
                        Array2D[JmlBaris - LbrBangun + b, k] = deret[max];
                        Array2D[JmlBaris - LbrBangun + b, JmlKolom - LbrBangun + k] = deret[max];
                        max--;
                    }
                    else if (k == LbrBangun-1)
                    {
                        Array2D[b, k] = deret[min];
                        Array2D[b, JmlKolom - LbrBangun + k] = deret[min];
                        Array2D[JmlBaris - LbrBangun + b, k] = deret[min];
                        Array2D[JmlBaris - LbrBangun + b, JmlKolom - LbrBangun + k] = deret[min];
                        min++;
                    }
                    else if (b == LbrBangun-1)
                    {
                        Array2D[b, k] = deret[max];
                        Array2D[b, JmlKolom - LbrBangun + k] = deret[max];
                        Array2D[JmlBaris - LbrBangun + b, k] = deret[max];
                        Array2D[JmlBaris - LbrBangun + b, JmlKolom - LbrBangun + k] = deret[max];
                        max--;
                    }
                    if (b == k || b + k == LbrBangun - 1)
                    {
                        Array2D[b, k] = "*";                                                 //kiri atas
                        Array2D[b, JmlKolom - LbrBangun + k] = "*";                          //kanan atas
                        Array2D[JmlBaris - LbrBangun + b, k] = "*";                          //kiri bawah
                        Array2D[JmlBaris - LbrBangun + b, JmlKolom - LbrBangun + k] = "*";   //kanan bawah
                    }
                }
            }
        }
    }
}
