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

namespace ConsoleApp2 // PŘÍKLAD 1.2: ZBYTEK PO CELOČÍSELNÉM DĚLENÍ BEZ OPERÁTORU %
{
    class Program
    {
        static void Main(string[] args)
        {                                       // Prostor pro úpravu hodnot
            int v = 30;                         //  <---- ZDE ZADEJTE ČÍSLO
            int w = 18;                         //  <---- ZDE ZADEJTE ČÍSLO

            int podil = v / w;
            int rozdil = (v * podil) - (w * podil);

            Console.WriteLine("Podíl čísel {0} a {1} má po vydělení zbytek {2}.", v, w, rozdil);
            Console.ReadLine();
        }
    }
}
