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

namespace ConsoleApp5 // PŘÍKLAD 1.5: Prostřední ze tří čísel
{
    class Program
    {
        static void Main(string[] args)
        {                                               // Prostor pro úpravu hodnot
            int d = 13;                                 //  <---- ZDE ZADEJTE ČÍSLO
            int e = 18;                                 //  <---- ZDE ZADEJTE ČÍSLO
            int f = 9;                                  //  <---- ZDE ZADEJTE ČÍSLO
            int prostredni_CA5 = 0;

            if ((e < d && d < f) || (f < d && d < e))
                prostredni_CA5 = d;
            if ((d < e && e < f) || (f < e && e < d))
                prostredni_CA5 = e;
            if ((e < f && f < d) || (d < f && f < e))
                prostredni_CA5 = f;

            Console.WriteLine("Z čísel {0}, {1} a {2} je prostřední číslo: {3}.", d, e, f, prostredni_CA5);
            Console.ReadLine();
        }
    }
}
