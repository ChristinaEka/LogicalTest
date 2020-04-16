using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal
{
    public class Soal11
    {
        public string execute(int n, string k, string b)
        {
            try
            {
                int uang = n;
                int[] hargaKC = Array.ConvertAll(k.Split(','), int.Parse);
                int[] hargaBJ = Array.ConvertAll(b.Split(','), int.Parse);

                Array.Sort(hargaKC);
                Array.Reverse(hargaKC);
                Array.Sort(hargaBJ);
                Array.Reverse(hargaBJ);

                List<int> perpaduanHarga = new List<int>();
                bool ada = false;
                int hasil = 0;

                for (int kc = 0; kc < hargaKC.Length; kc++)
                {
                    for (int bj = 0; bj < hargaBJ.Length; bj++)
                    {
                        hasil = hargaKC[kc] + hargaBJ[bj];
                        if (hasil == uang)
                        {
                            perpaduanHarga.Add(hasil);
                            ada = true;
                            break;
                        }
                        else if (hasil < uang)
                        {
                            if (kc == 0 && bj == 0)
                            {
                                perpaduanHarga.Add(hasil);
                                ada = true;
                                break;
                            }
                            perpaduanHarga.Add(hasil);
                        }
                    }

                    if (ada)
                    {
                        break;
                    }
                }

                if (perpaduanHarga.Any())
                {
                    return "Biaya maksimal yang dapat dikeluarkan => " + perpaduanHarga.Max().ToString();
                }
                else
                {
                    return "Dana Andi tidak cukup";
                }
            }
            catch
            {
                return "Input Anda salah";
            }

        }

    }
}
