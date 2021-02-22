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

namespace Priklad_3_3   // ARITMETICKÝ VÝRAZ
{                                                           // Vypracováno pouze a) a b), příklady c) a d) zatím nevypracovány
    class Program
    {
        static double Faktorial()                               
        {
            Console.WriteLine("Počítáme faktoriál čísla");
            double n;
            Console.WriteLine("Zadejte číslo: ");
            n = Convert.ToInt32(Console.ReadLine());

            double f = n;
            double i;
            for(i = 1; i <= n; i++)
            {
                if (i != n)
                {
                    f = (f * (n - i));
                }
                /*else f = f;*/
            }
            Console.WriteLine("\nfaktoriál = {0}", f);
            return f;
        }
        static double Mocnina()
        {
            Console.WriteLine("\nPočítáme kladnou mocninu čísla");
            double a;
            Console.WriteLine("Zadejte číslo: ");
            a = Convert.ToInt32(Console.ReadLine());
            double b;
            Console.WriteLine("Zadejte mocninu: ");
            b = Convert.ToInt32(Console.ReadLine());
            double i;
            double c = a;
            for (i = 1; i < b; i++)
            {
                c = c * a; 
            }
            Console.WriteLine("\nmocnina = {0}", c);
            return b;
        }
        /*
        static double En()
        {
            Console.WriteLine("\nPočítáme hodnotu e na n-tou");
            double d;
            Console.WriteLine("Zadejte číslo n: \n");
            d = Convert.ToInt32(Console.ReadLine());

            double sto = 5;
            double f = sto;
            double h = d;
            double i;
            double vysledek = 0;
            double mezivypocet = 1;
            for (i = 1; i <= sto; i++)
            {
                    if (i != sto)
                    {
                        f = f * (sto - i);        // faktoriál
                        h = h * h;          // možná umocněné číslo n
                        mezivypocet = h / f;      // člen posloupnosti
                        vysledek = vysledek + mezivypocet; 
                    }
            }
            
            
            Console.WriteLine("\numocněné n = {0}", h);
            Console.WriteLine("\nfaktoriál {0}! = {1}", sto, f);
            Console.WriteLine("\n(umocněné n / faktoriál {0}!) = {1}", sto, mezivypocet);
            Console.WriteLine("\nvýsledek e na n-tou = {0}", vysledek);
            Console.WriteLine("\n\nPozor! Funkce má aktuálně nastavenou hodnotu k = {0}, nikoli k = 100 pro výpočet e na n-tou. ", sto);
            return vysledek;
        }
        */
        static void Main(string[] args)
        {
            double k;           // příklad a) FUNKČNÍ
            k = Faktorial();       
            double e;           //  příklad b) FUNKČNÍ
            e = Mocnina();
            
            /*
            double f;           // příklad c) NENÍ ZATÍM FUNKČNÍ
            f = En();                   //   nutné ještě dodělat příklad d)
            */

            /*
            double n;
            Console.WriteLine("Zadejte n: ");
            n = Convert.ToInt32(Console.ReadLine());
            int k;
            double vysledek = 0;
            double o = 100;
            for(k = 100; (k <= 100) && (k >= 0); k--)
            {
                if (k == 0)
                {
                    Console.WriteLine("k! = {0}\n", o);         // k!, resp. 100!
                    Console.WriteLine("n na k = {0}\n", n);     // n na k-tou, resp. n na 100tou
                }
                else if (k != 0)
                {
                    o = o * k;
                    n = n * n;
                    double p = (n / o);                         // p = (n na k-tou)/k!
                    vysledek = (vysledek + p);
                }
                
            }
            Console.WriteLine("Výsledek = {0}\n", vysledek);
            */
            Console.ReadLine();
        }
    }
}
