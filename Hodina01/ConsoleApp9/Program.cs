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

namespace ConsoleApp9 // PŘÍKLAD 1.9: Sčítance čísla
{
    class Program
    {
        static void Main(string[] args)
        {                                                           // Prostor pro úpravy hodnot
            int x = 3;                                              //  <---- ZDE ZADEJTE ČÍSLO
            int y = 8;                                              //  <---- ZDE ZADEJTE ČÍSLO
            int z = 11;                                             //  <---- ZDE ZADEJTE ČÍSLO

            Console.Write("Z vybraných čísel {0}, {1} a {2}," , x, y, z);
            if (x == (y + z))
                Console.WriteLine(" je {0} součtem čísel {1} a {2}." , x, y, z);
            if (y == (x + z))
                Console.WriteLine(" je {0} součtem čísel {1} a {2}.", y, x, z);
            if (z == (x + y))
                Console.WriteLine(" je {0} součtem čísel {1} a {2}.", z, x, y);
            else Console.WriteLine(" není žádné součtem zbylých dvou.");
            Console.Read();
        }
    }
}
