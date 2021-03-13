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

namespace ConsoleApp10 // PŘÍKLAD 1.10: Jízdné v MHD
{
    class Program
    {
        static void Main(string[] args)
        {                                           // Prostor pro úpravy hodnot
            int vek = 35;                           //  <---- ZDE ZADEJTE ČÍSLO
            int jizdne = 0;

            if ((vek >= 6) && (vek < 15))
                jizdne = 12;
            if ((vek >= 15) && (vek < 60))
                jizdne = 24;
            if ((vek < 6) || (vek >= 60))
                jizdne = 0;

            Console.WriteLine("Uvedli jste věk {0} let, cena jízdného bude {1},-Kč." , vek, jizdne);
            Console.Read();
        }
    }
}
