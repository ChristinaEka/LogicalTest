using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Soal
{
    public class Soal7 : LogicBase
    {
        public Soal7(int n, int m)
        {
            JmlKolom = (m + (m - 1)) * 2;
            LbrBangun = JmlKolom / 2;
            AngkaAwal = n;
            Selisih = m;
            Array1D = new string[JmlKolom];
            IsiArray();
            FunctionBase.printArrayBiasa(Array1D);
        }

        private void IsiArray()
        {
            
            for (int k=0; k<LbrBangun; k++)
            {
                int angka = AngkaAwal;
                if (k % 2 == 0)
                {
                    Array1D[k] = AngkaAwal.ToString();
                    Array1D[JmlKolom - 1 - k] = (AngkaAwal*(-1)).ToString();
                    AngkaAwal -= Selisih;
                }
                else
                {
                    Array1D[k] = "*";
                    Array1D[JmlKolom - 1 - k] = "*";
                }
            }
        }
    }
}
