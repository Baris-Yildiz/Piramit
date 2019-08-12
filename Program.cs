using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_İLK_DENEME
{
    class Program
    {
        static void Print(string y)
        {
            Console.WriteLine(y);

        }
        static string MultiplyString(string y, int x)
        {
            string unmodifiedstr = y;
            while (x - 1 > 0)
            {
                y += unmodifiedstr;
                x--;
            }
            return y;
        }
        static string AddSpaces(int x)
        {
            string space = "";
            while (x > 0)
            {
                space += " ";
                x--;
            }
            return space;
        }
        static int OrtHesapla(int z)
        {
            z = 4 * (z - 1) + 1;
            return z;
        }
        static void Main(string[] args)
        {
            string key = "";

            while (key != "exit")
            {
                Print("Cıkıs?");
                key = Console.ReadLine();

                if(key == "exit")
                {
                    break;
                }

                Print("Icı dolu bir piramit mi? (1) / Icı bos bir piramit mi? (2)");
                int secim = Convert.ToInt32(Console.ReadLine());

                Print("Kac Sira Olsun?");
                int sıra = Convert.ToInt32(Console.ReadLine());
                int ORT = OrtHesapla(sıra);

                Print("Piramitte Kullanilacak Karakteri Seciniz");
                string karakter = Console.ReadLine();

                string pyramid = "";

                pyramid += AddSpaces(ORT) + karakter + Environment.NewLine;

                int t = 2;
                int aradakibosluk = 3;

                if (secim == 2)
                {
                    while (sıra - 1 > 0)
                    {
                        if (sıra - 1 == 1)
                        {
                            pyramid += AddSpaces(ORT - t) + karakter + MultiplyString(karakter, aradakibosluk) + karakter + Environment.NewLine;
                            break;
                        }

                        pyramid += AddSpaces(ORT - t) + karakter + AddSpaces(aradakibosluk) + karakter + Environment.NewLine;
                        t += 2;
                        aradakibosluk += 4;
                        sıra -= 1;
                    }
                }

                if (secim == 1)
                {
                    while (sıra - 1 > 0)
                    {
                        pyramid += AddSpaces(ORT - t) + karakter + MultiplyString(karakter, aradakibosluk) + karakter + Environment.NewLine;
                        t += 2;
                        aradakibosluk += 4;
                        sıra -= 1;
                    }
                }
                Print(pyramid);
                string last = Console.ReadLine();
            }
            
        }

    }
}

