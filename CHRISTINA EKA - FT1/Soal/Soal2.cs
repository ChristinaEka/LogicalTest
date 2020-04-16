using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Soal
{
    public class Soal2 : LogicBase
    {
        public Soal2(int n)
        {
            JmlBangun = 3;
            JmlBaris = n * 2 - 1;
            JmlKolom = n * 3;
            LbrBangun = n;
            Array2D = new string[JmlBaris, JmlKolom];
            IsiArray();
            FunctionBase.printArray2D(Array2D);
        }

        private void IsiArray()
        {
            int BatasKanan = LbrBangun;
            int BatasBawah = BatasKanan;
            int geser = 0;

            for (int x=0; x<JmlBangun; x++)
            {
                for (int b = 0; b < LbrBangun; b++)
                {
                    for (int k = 0; k < LbrBangun; k++)
                    {
                        if (b + k >= LbrBangun - 1)
                        {
                            if (b == BatasBawah - 1 && k == BatasKanan - 1)
                            {
                                Array2D[b, k + geser] = "O";
                            }
                            else
                            {
                                Array2D[b, k + geser] = "*";
                            }
                            
                        }
                    }
                }
                geser += BatasKanan;
            }
        }
    }
}
