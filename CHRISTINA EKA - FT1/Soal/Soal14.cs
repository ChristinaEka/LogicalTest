using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal
{
    public class Soal14
    {
        public string execute(string harga)
        {
            try
            {
                int[] daftarHarga = Array.ConvertAll(harga.Split(','), int.Parse);

                double menuIkan = (daftarHarga[0] + (0.15 * daftarHarga[0])) / 3;
                double menu = 0;

                for (int i = 1; i < daftarHarga.Length; i++)
                {
                    menu += daftarHarga[i];
                }

                double menuLain = (menu + (0.15 * menu)) / 4;

                return "Yang harus dibayar teman 1 => " + menuLain + "\n\n         dan teman lainnya => " + (menuLain + menuIkan);
            }
            catch
            {
                return "Format yang Anda masukkan salah.";
            }
        }
    }
}
