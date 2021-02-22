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

namespace ConsoleApp6 // PŘÍKLAD 1.6: Různá čísla
{
    class Program
    {
        static void Main(string[] args)
        {                                                       // Prostor pro úpravu hodnot
            int g = 118;                                        //  <---- ZDE ZADEJTE ČÍSLO
            int h = 18;                                         //  <---- ZDE ZADEJTE ČÍSLO
            int i = 9;                                          //  <---- ZDE ZADEJTE ČÍSLO
            // int shoda_CA6 = 0;

            Console.Write("Z čísel {0}, {1} a {2} lze usoudit, že ", g, h, i);
            if ((g == h) || (g == i) || (h == i))
                Console.WriteLine("NEjsou rozdílné.");
            else Console.WriteLine("jsou rozdílné.");

            
            Console.ReadLine();
        }
    }
}
