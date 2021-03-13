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

namespace Priklad_4_4   // OBRÁCENÍ POLE
{
    class Program
    {
        static int[] ObratPole(int[] x)                     // zatím jenom kopíruje...
        {
            int i; 
            int j = x.Length - 1;
            int[] y = new int[x.Length];
            while (j >= 0)
            { 
                for (i = 0; i < x.Length; i++)
                {
                    y[j] = x[i];
                    Console.Write("{0}, ", y[j]);
                    j--;
                }
            }
            return y;
        }
        static void Main(string[] args)
        {
            int i;
            int[] vstup = { 5, 7, 8, 9, 13, 48 };
            for (i = 0; i < vstup.Length; i++) Console.Write("{0}, ", vstup[i]);
            Console.WriteLine("");
            ObratPole(vstup);

            Console.ReadLine();

        }
    }
}
