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

namespace Hodina02_2    // PŘÍKLAD 2.2: TŘI ČÍSLA VZESTUPNĚ
{
    class Program
    {
        static void Main(string[] args)
        {                              
            int x;                     
            int y;                     
            int z;                     
            Console.Write("Zadejte první číslo: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadejte druhé číslo: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadejte třetí číslo: ");
            z = Convert.ToInt32(Console.ReadLine());

            int nejmensi;
            int stredni;
            int nejvetsi;


            if ((x < y) && (x < z)) nejmensi = x;
            else
            {
                if ((y < x) && (y < z)) nejmensi = y;
                else nejmensi = z;
            }

            if ((x > y) && (x > z)) nejvetsi = x;
            else
            {
                if ((y > x) && (y > z)) nejvetsi = y;
                else nejvetsi = z;
            }

            if (((x > y) && (x < z)) || ((x > z) && (x < y))) stredni = x;
            else
            {
                if (((y > x) && (y < z)) || ((y > z) && (y < x))) stredni = y;
                else stredni = z;
            }
            
            Console.WriteLine("Vzestupně: nejmenší {0}, střední {1} a největší {2}.", nejmensi, stredni, nejvetsi);
            Console.ReadLine();
        }
    }
}
