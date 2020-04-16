using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Soal
{
    public class Soal5 : LogicBase
    {
        public Soal5(int n, int m)
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
            int panjang = JmlBaris * JmlKolom;
            string[] deret = new string[panjang];
            int lipat = 1;
            for (int i=0; i<panjang; i++)
            {
                if (i + 1 == AngkaAwal*lipat)
                {
                    deret[i] = " ";
                    lipat++;
                }
                else
                {
                    deret[i] = "*";
                }
            }

            panjang = 0;
            for (int b=0; b<JmlBaris; b++)
            {
                for (int k=0; k<JmlKolom; k++)
                {
                    if ((b==0 || b==JmlBaris-1) && (k==0 || k==JmlKolom-1) )
                    {
                        Array2D[b, k] = "o";
                        panjang++;
                    }
                    else
                    {
                        Array2D[b, k] = deret[panjang];
                        panjang++;
                    }
                }
            }
        }
    }
}
