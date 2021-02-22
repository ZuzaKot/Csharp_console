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

namespace ConsoleApp8 // PŘÍKLAD 1.8: Dělitel čísla
{
    class Program
    {
        static void Main(string[] args)
        {                                                           // Prostor pro úpravu hodnot
            int x = 8;                                              //  <---- ZDE ZADEJTE ČÍSLO
            int y = 23;                                             //  <---- ZDE ZADEJTE ČÍSLO
            int z = 4;                                              //  <---- ZDE ZADEJTE ČÍSLO

            int pokus1 = (x / y);
            int pokus2 = (x / z);
            int pokus3 = (y / x);
            int pokus4 = (y / z);
            int pokus5 = (z / y);
            int pokus6 = (z / x);

            Console.WriteLine("Máme zadána čísla {0}, {1} a {2}." , x, y, z);
            if (x == (pokus1 * y))
                Console.WriteLine("Číslo {0} je dělitelem čísla {1}.", y, x);
           // else Console.WriteLine("Číslo {0} NENÍ dělitelem čísla {1}.", y, x);
            if (x == (pokus2 * z))
                Console.WriteLine("Číslo {0} je dělitelem čísla {1}.", z, x);
            //else Console.WriteLine("Číslo {0} NENÍ dělitelem čísla {1}.", z, x);
            if (y == (pokus3 * x))
                Console.WriteLine("Číslo {0} je dělitelem čísla {1}.", x, y);
            //else Console.WriteLine("Číslo {0} NENÍ dělitelem čísla {1}.", x, y);
            if (y == (pokus4 * z))
                Console.WriteLine("Číslo {0} je dělitelem čísla {1}.", z, y);
            //else Console.WriteLine("Číslo {0} NENÍ dělitelem čísla {1}.", z, y);
            if (z == (pokus5 * y))
                Console.WriteLine("Číslo {0} je dělitelem čísla {1}.", y, z);
            //else Console.WriteLine("Číslo {0} NENÍ dělitelem čísla {1}.", y, z);
            if (z == (pokus6 * x))
                Console.WriteLine("Číslo {0} je dělitelem čísla {1}.", x, z);
            //else Console.WriteLine("Číslo {0} NENÍ dělitelem čísla {1}.", x, z);

            //else Console.WriteLine("Žádné z čísel není dělitelem čísla jiného.");

            Console.Read();


        }
    }
}
