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

namespace Hodina02_5 // PŘÍKLAD 2.5: NEJMENŠÍ SPOLEČNÝ NÁSOBEK
{
    class Program
    {
        static void Main(string[] args)
        {         
            int x;
            int y;
            int z;
            int nsn = 0;
            Console.Write("Zadejte první číslo: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadejte druhé číslo: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nejmenší společný násobek čísel {0} a {1} je: ", x, y);
            if ((y % x) == 0)
            {
                nsn = y;
                Console.WriteLine("{0}. ", nsn);
            }
            else if ((x % y) == 0)
            {
                nsn = x;
                Console.WriteLine("{0}. ", nsn);
            }
            else
            {
                if ((x > 0) && (y > 0))
                {
                    for (z = x; z > 0; z--)
                    {
                        if ((x % z == 0) && (y % z == 0))
                        {
                            if (x < y) nsn = ((y / z) * x);
                            if (x > y) nsn = ((x / z) * y);
                            Console.WriteLine(" {0} ", nsn);
                            Console.WriteLine("Nejmenší společný dělitel: {0} ", z);
                            break;   
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
