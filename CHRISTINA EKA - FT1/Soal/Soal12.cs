using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal
{
    public class Soal12
    {
        public string execute (string kata)
        {
            kata = kata.ToUpper();            
            char[] palindrome = kata.ToCharArray();
            Array.Reverse(palindrome);
            string akhir = new string(palindrome);            

            if (kata == akhir)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
    }
}
