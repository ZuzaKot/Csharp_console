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

namespace Hodina02_4 // PŘÍKLAD 2.4: FAKTORIÁL
{
    class Program
    {
        static void Main(string[] args)
        {               
            int x;
            Console.Write("Zadejte celé číslo: ");
            x = Convert.ToInt32(Console.ReadLine());
            int i;
            int suma = x;

            if (x == 0) Console.WriteLine("Pro číslo 0 není faktoriál definován.");
            if (x < 0)
            {
                Console.WriteLine("Pro výpočet faktoriálu musí být číslo celé a vyšší od O.");
                Console.Write("Proto si číslo {0} převedeme na kladné ", x);
                x = (int)Math.Abs(x);                                           // Toto by zde nemuselo být, ale mně 
                suma = (int)Math.Abs(suma);                                     //      se to takto mnohem více líbí. :-)
                Console.WriteLine("a budeme počítat s novou hodnotou: {0}.", x);
            }
            if (x > 0)
            {
                for (i = (x - 1); i > 0; i--)
                {
                    suma = suma * i;
                }
                Console.WriteLine("Výsledek {0}! je {1}.", x, suma);
            }
            Console.ReadLine();

        }
    }
}
