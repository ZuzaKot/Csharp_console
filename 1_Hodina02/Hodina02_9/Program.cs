// Tento zdrojový kód jsem vypracovala zcela samostatně bez cizí pomoci.
// Neokopírovala jsem, ani jsem neopsala cizí zdrojové kódy.
// Nikdo mi při vypracování neradil.
// Pokud některý řádek porušuje toto pravidlo, je označen komentářem NENÍ MOJE TVORBA.
// Porušení těchto pravidel se považuje za podvod, který lze potrestat VYLOUČENÍM ZE STUDIA.
// Zuzana Kotásková, 36777

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hodina02_9 // PŘÍKLAD 2.9: STATISTICKÉ INFORMACE
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;
            int m = 0;      // počet zadaných cifer
            int k = 0;      // součet zadaných cifer


            Console.WriteLine("Zadejte posloupnost (maximálně pěti) kladných čísel.");
            Console.WriteLine("Zadejte první číslo: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                m = m + 1;
                k = k + a;
                int nejmensi = a;
                int nejvetsi = a;
                Console.WriteLine("Zadejte druhé číslo: ");
                b = Convert.ToInt32(Console.ReadLine());
                if (b > 0)
                {
                    m = m + 1;
                    k = k + b;
                    if (b < a) nejmensi = b;
                    else if (a < b) nejvetsi = b;
                    Console.WriteLine("Zadejte třetí číslo: ");
                    c = Convert.ToInt32(Console.ReadLine());
                    if (c > 0)
                    {
                        m = m + 1;
                        k = k + c;
                        if ((b < c) && (a < c)) nejvetsi = c;
                        else if ((c < b) && (c < a)) nejmensi = c;
                        Console.WriteLine("Zadejte čtvrté číslo: ");
                        d = Convert.ToInt32(Console.ReadLine());
                        if (d > 0)
                        {
                            m = m + 1;
                            k = k + d;
                            if ((a < d) && (b < d) && (c < d)) nejvetsi = d;
                            else if ((d < a) && (d < b) && (d < c)) nejmensi = d;
                            Console.WriteLine("Zadejte páté číslo: ");
                            e = Convert.ToInt32(Console.ReadLine());
                            if (e > 0)
                            {
                                m = m + 1;
                                k = k + e;
                                if ((a < e) && (b < e) && (c < e) && (d < e)) nejvetsi = e;
                                else if ((e < a) && (e < b) && (e < c) && (e < d)) nejmensi = e;
                            }
                        }
                    }

                }
                Console.WriteLine("Počet kladných čísel je: {0}.", m);
                if (m > 1)
                {
                    Console.WriteLine("Jejich součet je: {0}.", k);
                    Console.WriteLine("Nejmenší je: {0}.", nejmensi);
                    Console.WriteLine("Největší je: {0}.", nejvetsi);
                }
            }

            Console.ReadLine();
        }
    }
}

