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

namespace ConsoleApp4 //PŘÍKLAD 1.4: NEJVĚTŠÍ ZE TŘÍ ČÍSEL
{
    class Program
    {
        static void Main(string[] args)
        {                                   // Prostor pro úpravu hodnot
            int a = 73;                     //  <---- ZDE ZADEJTE ČÍSLO
            int b = 1168;                   //  <---- ZDE ZADEJTE ČÍSLO
            int c = 215;                    //  <---- ZDE ZADEJTE ČÍSLO
            int nejvetsi_CA4 = a;

            if (b > a)
                if (b > c)
                    nejvetsi_CA4 = b;
            if (c > a)
                if (c > b)
                    nejvetsi_CA4 = c;
            
              
            Console.WriteLine("Z čísel {0}, {1} a {2} je největší: {3}.", a, b, c, nejvetsi_CA4);
            Console.ReadLine();
        }
    }
}
