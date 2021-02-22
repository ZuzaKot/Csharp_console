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

namespace ConsoleApp3 // PŘÍKLAD 1.3: POČET ČÍSEL MENŠÍCH NEŽ 10
{
    class Program
    {
        static void Main(string[] args)
        {                                           // Prostor pro úpravu hodnot
            int e = 14;                             //  <---- ZDE ZADEJTE ČÍSLO
            int f = 16;                             //  <---- ZDE ZADEJTE ČÍSLO
            int g = 51;                             //  <---- ZDE ZADEJTE ČÍSLO

            int h = 10;
            int vysl_CA3 = 0;

            if (e <= h)
                vysl_CA3++;
            if (f <= h)
                vysl_CA3++;
            if (g <= h)
                vysl_CA3++;


            Console.WriteLine("Z čísel {0}, {1} a {2} je menších než 10 celkem {3}.", e, f, g, vysl_CA3);
            Console.ReadLine();
        }
    }
}
