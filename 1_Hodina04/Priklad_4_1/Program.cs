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

namespace Priklad_4_1   // SESTUPNÉ SETŘÍDĚNÍ
{
    class Program
    {
        static void Setrid(ref int x, ref int y)
        {
            if (x < y) Console.WriteLine("Sestupně: {0}, {1}", y, x);
            else Console.WriteLine("Sestupně: {0}, {1}", x, y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte dvě čísla\n\nprvní:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("druhé:");
            int b = Convert.ToInt32(Console.ReadLine());

            Setrid(ref a, ref b);

            Console.ReadLine();
        }
    }
}
