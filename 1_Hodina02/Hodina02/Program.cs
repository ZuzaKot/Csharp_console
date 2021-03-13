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

namespace Hodina02_1    // PŘÍKLAD 2.1: DVĚ ČÍSLA SESTUPNĚ
{
    class Program
    {
        static void Main(string[] args)
        {            
            int prvni;
            int druhe;
            Console.Write("Zadejte první číslo: ");
            prvni = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadejte druhé číslo: ");
            druhe = Convert.ToInt32(Console.ReadLine());

            if (prvni>druhe)
            {
                Console.WriteLine("Zjistili jsme, že z uvedených čísel je větší {0} a menší {1}.", prvni, druhe);
            }
            else
            {
                Console.WriteLine("Zjistili jsme, že z uvedených čísel je větší {0} a menší {1}.", druhe, prvni);
            }
            Console.ReadLine();

        }
    }
}
