using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace Soal
{
    public class Soal8 : LogicBase
    {
        public Soal8(int n)
        {
            JmlBangun = n;
            JmlBaris = 2 * n;
            JmlKolom = JmlBaris;
            LbrBangun = 2;
            Array2D = new string[JmlBaris, JmlKolom];
            IsiArray();
            FunctionBase.printArray2D(Array2D);
        }

        private void IsiArray()
        {
            int geser = 0;
            for (int x=0; x<JmlBangun; x++)
            {
                int tinggi = x + 1;
                int BatasKanan = LbrBangun;
                for (int b=0; b<tinggi; b++)
                {
                    for (int k=0; k<LbrBangun; k++)
                    {
                        if (b%2 == 0)
                        {
                            Array2D[JmlBaris / 2 - 1 - b, k + geser] = ((JmlBaris / 2 - b) * 3 * (-1)).ToString();
                            Array2D[JmlBaris / 2 + b, k + geser] = ((JmlBaris / 2 - b) * 3).ToString();
                        }
                        else
                        {
                            Array2D[JmlBaris / 2 - 1 - b, k + geser] = ((JmlBaris / 2 - b) * 3).ToString();
                            Array2D[JmlBaris / 2 + b, k + geser] = ((JmlBaris / 2 - b) * 3 * (-1)).ToString();
                        }                           
                    }
                }
                geser += LbrBangun;
            }         
        }
    }
}
