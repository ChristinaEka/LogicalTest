using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Soal
{
    public class Soal9 : LogicBase
    {
        public Soal9(int n, int m)
        {
            AngkaAwal = n;
            JmlBangun = m;
            LbrBangun = 2;
            JmlBaris = 2;
            JmlKolom = LbrBangun*m;
            Array2D = new string[JmlBaris, JmlKolom];
            IsiArray();
            FunctionBase.printArray2D(Array2D);
        }

        private void IsiArray()
        {
            int BatasBawah = 1;
            int BatasKanan = LbrBangun;
            int geser = 0;
            int Angka = AngkaAwal;

            for (int x=0; x<JmlBangun; x++)
            {
                for (int b = 0; b < BatasBawah; b++)
                {
                    for (int k = 0; k < BatasKanan; k++)
                    {
                        if (x % 2 == 0)
                        {
                            if (k==0)
                            {
                                Array2D[b, k + geser] = Angka.ToString();
                                Angka += AngkaAwal;
                            }
                            else
                            {
                                Array2D[b, k + geser] = (Angka*(-1)).ToString();
                                Angka += AngkaAwal;
                            }
                           
                        }
                        else
                        {
                            if (k==0)
                            {
                                Array2D[JmlBaris - 1 - b, k + geser] = Angka.ToString();
                                Angka += AngkaAwal;
                            }
                            else
                            {
                                Array2D[JmlBaris - 1 - b, k + geser] = (Angka*(-1)).ToString();
                                Angka += AngkaAwal;
                            }
                           
                        }
                    }
                }
                geser += BatasKanan;
            }
        }
    }
}
