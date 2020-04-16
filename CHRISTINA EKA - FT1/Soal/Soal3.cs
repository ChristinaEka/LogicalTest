using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Soal
{
    public class Soal3 : LogicBase
    {
        public Soal3(int n)
        {
            JmlBangun = n;
            JmlKolom = FunctionBase.counter(n)*2;
            Array1D = new string[JmlKolom];
            IsiArray();
            FunctionBase.printArrayBiasa(Array1D);
        }

        private void IsiArray()
        {
            int angka = 2;
            int BatasKanan = 0;
            for (int x=0; x<JmlBangun; x++)
            {
                LbrBangun = x + 1;
                for (int k=0; k < LbrBangun; k++)
                {
                    Array1D[k + BatasKanan] = angka.ToString();
                    Array1D[JmlKolom - 1 - (k + BatasKanan)] = (angka * (-1)).ToString();
                }
                angka += 2;
                BatasKanan += LbrBangun;
            }
        }
    }
}
