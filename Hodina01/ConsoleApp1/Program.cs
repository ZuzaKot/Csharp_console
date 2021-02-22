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

namespace ConsoleApp1 // PŘÍKLAD 1.1: SPECIFICKÝ ARITMETICKÝ VÝRAZ
{
    class Program
    {
        static void Main(string[] args)
        {                                   // Prostor pro úpravy hodnot
            int m = 90;                     //  <---- ZDE ZADEJTE ČÍSLO
            int n = 9;                      //  <---- ZDE ZADEJTE ČÍSLO
            int o = 15;                     //  <---- ZDE ZADEJTE ČÍSLO

            int soucin_no = n * o;
            int rozdil = soucin_no - m;

            Console.WriteLine("{0} * {1} - {2} = {3}", o, n, m, rozdil);
            Console.ReadLine();
        }
    }
}
