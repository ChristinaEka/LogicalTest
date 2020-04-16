using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal
{
    public class Soal13
    {
        public string execute(string deret, int rotasi)
        {
            //string angkaGeser = "";
            //for (int i = 0; i < rotasi; i++)
            //{
            //    angkaGeser = deret.Substring(1);
            //    deret = angkaGeser + deret.Substring(0, 1);
            //}

            //return "Hasil rotasi terakhir => " + deret;

            string[] obj = deret.Split(',');
            string[] geser = new string[obj.Length];
            for (int i = 0; i < rotasi; i++)
            {
                for (int r = 0; r <= obj.Length - 1; r++)
                {
                    if (r == obj.Length - 1)
                    {
                        geser[r] = obj[0];
                    }
                    else
                    {
                        geser[r] = obj[r + 1];
                    }
                }
                obj = geser;
                geser = new string[obj.Length];
            }
            string hasil = string.Join(",", obj);

            return "Hasil rotasi terakhir => " + hasil;
        }
    }
}
