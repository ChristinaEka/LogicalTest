using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Soal
{
    public class Soal1 : LogicBase
    {
        public Soal1(int n)
        {
            LbrBangun = n;
            JmlBaris = n * 3;
            JmlKolom = JmlBaris;
            Array2D = new string[JmlBaris, JmlKolom];
            IsiArray();
            FunctionBase.printArray2D(Array2D);
        }

        private void IsiArray()
        {
            for (int b=0; b<LbrBangun; b++)
            {
                for (int k=0; k<LbrBangun; k++)
                {
                    if (b == 0 || b == LbrBangun - 1)
                    {
                        if (k == 0 || k == LbrBangun-1)
                        {
                            Array2D[b, LbrBangun + k] = "o";                           //atas
                            Array2D[LbrBangun + b, k] = "o";                           //kiri
                            Array2D[LbrBangun + b, JmlKolom - LbrBangun + k] = "o";    //kanan
                            Array2D[JmlBaris - LbrBangun + b, LbrBangun + k] = "o";    //bawah
                        }
                        else
                        {
                            Array2D[b, LbrBangun + k] = "*";                           //atas
                            Array2D[LbrBangun + b, k] = "*";                           //kiri
                            Array2D[LbrBangun + b, JmlKolom - LbrBangun + k] = "*";    //kanan
                            Array2D[JmlBaris - LbrBangun + b, LbrBangun + k] = "*";    //bawah
                        }
                        
                    }
                    else if (k == 0 || k == LbrBangun - 1)
                    {
                        Array2D[b, LbrBangun + k] = "*";                            //atas
                        Array2D[LbrBangun + b, k] = "*";                            //kiri
                        Array2D[LbrBangun + b, JmlKolom - LbrBangun + k] = "*";     //kanan
                        Array2D[JmlBaris - LbrBangun + b, LbrBangun + k] = "*";     //bawah
                    }
                }
            }
        }
    }
}
