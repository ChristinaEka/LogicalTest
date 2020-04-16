using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;
using Soal;

namespace FT1
{
    class Program
    {
        static void Main(string[] args)
        {
            string jawab = "y";
            while (jawab == "y" || jawab == "Y")
            {
                Console.WriteLine(); Console.Clear();
                Console.WriteLine("\n--- Logic ---");

                Console.Write("\nMasukkan Nomor Soal : ");
                int soal = int.Parse(Console.ReadLine());
                int n;
                int m;
                int o;
                string p;
                string q;

                switch (soal)
                {
                    case 1:
                        Console.Write("\nMasukkan nilai n : ");
                        n = int.Parse(Console.ReadLine());
                        Soal1 jawab1 = new Soal1(n);
                        break;
                    case 2:
                        Console.Write("\nMasukkan nilai n : ");
                        n = int.Parse(Console.ReadLine());
                        Soal2 jawab2 = new Soal2(n);
                        break;
                    case 3:
                        Console.Write("\nMasukkan nilai n : ");
                        n = int.Parse(Console.ReadLine());
                        Soal3 jawab3 = new Soal3(n);
                        break;
                    case 4:
                        Console.Write("\nMasukkan nilai n : ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("\nMasukkan nilai m : ");
                        m = int.Parse(Console.ReadLine());
                        Soal4 jawab4 = new Soal4(n, m);
                        break;
                    case 5:
                        Console.Write("\nMasukkan nilai n : ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("\nMasukkan nilai m : ");
                        m = int.Parse(Console.ReadLine());
                        Soal5 jawab5 = new Soal5(n, m);
                        break;
                    case 7:
                        Console.Write("\nMasukkan nilai y : ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("\nMasukkan nilai z : ");
                        m = int.Parse(Console.ReadLine());
                        Soal7 jawab7 = new Soal7(n, m);
                        break;
                    case 8:
                        Console.Write("\nMasukkan nilai n : ");
                        n = int.Parse(Console.ReadLine());
                        Soal8 jawab8 = new Soal8(n);
                        break;
                    case 9:
                        Console.Write("\nMasukkan nilai n : ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("\nMasukkan nilai m : ");
                        m = int.Parse(Console.ReadLine());
                        Soal9 jawab9 = new Soal9(n, m);
                        break;
                    case 10:
                        Console.Write("\nMasukkan nilai n : ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("\nMasukkan nilai m : ");
                        m = int.Parse(Console.ReadLine());
                        Console.Write("\nMasukkan nilai o : ");
                        o = int.Parse(Console.ReadLine());
                        Soal10 jawab10 = new Soal10(n, m, o);
                        break;

                    case 11:
                        Soal11 jawab11 = new Soal11();
                        Console.Write("\nMasukkan uang Andi : ");
                        n = int.Parse(Console.ReadLine());
                        Console.Write("\nMasukkan list harga kacamata : ");
                        p = Console.ReadLine();
                        Console.Write("\nMasukkan list harga baju : ");
                        q = Console.ReadLine();
                        Console.WriteLine("-\n" + jawab11.execute(n, p, q));
                        break;                                
                    case 12:
                        Soal12 jawab12 = new Soal12();
                        Console.Write("\nMasukkan kata : ");
                        p = Console.ReadLine();
                        Console.WriteLine("-\n" + jawab12.execute(p));
                        break;                                
                    case 13:
                        Soal13 jawab13 = new Soal13();
                        Console.Write("\nMasukkan deret : ");
                        p = Console.ReadLine();
                        Console.Write("\nMasukkan banyaknya rotasi : ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("-\n" + jawab13.execute(p, n));
                        break;                                
                    case 14:
                        Soal14 jawab14 = new Soal14();
                        Console.Write("\nMasukkan harga menu yang dipesan (Format => menuIkan,menuLain1,...) : ");
                        p = Console.ReadLine();
                        Console.WriteLine("-\n" + jawab14.execute(p));
                        break;                                
                    case 15:
                        Soal15 jawab15 = new Soal15();
                        Console.Write("\nMasukkan jam (Format => HH:mm:ss AM/PM) : ");
                        p = Console.ReadLine();
                        Console.WriteLine("-\n" + jawab15.execute(p));
                        break;

                    default:
                        Console.WriteLine("\nSoal Tidak Ditemukan");
                        break;
                }

                Console.Write("\nApakah masih berlanjut? [Y/T] ");
                jawab = Console.ReadLine();
            }
        }
    }
}
