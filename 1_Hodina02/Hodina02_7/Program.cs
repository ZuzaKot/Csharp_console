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

namespace Hodina02_7 // PŘÍKLAD 2.7: DOKONALÁ ČÍSLA 
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, i;

            Console.WriteLine("Bingo! Máme tady dokonalá čísla!");
            for (x = 2; x < 10000; x++)                     // hledáme všechna dokonalá čísla do 10 000
            {
                int y = 0;
                for (i = 1; i <= x; i++)
                {
                    if (x % i == 0)                         // hledáme celočíselné dělitele
                    {
                        if (i != x)
                        {
                            y = y + i;                      // zde sčítáme celočíselné dělitele
                        }
                    }
                    else if ((x % i != 0) && (x > i))       // vrací zpět na i++
                    {
                        continue;
                    }
                }
                if (y == x)                                 // porovnáváme součet celociferných dělitelů a původního x
                {
                    Console.Write(" {0} = ", x);
                    for (i = 1; i <= x; i++)                        // řešení:
                    {
                        if (x % i == 0)                             // znovu hledáme celociferné dělitele
                        {
                            if (i != x)                             // že je číslo dělitelné sebou sama nás tady nezajímá
                            {
                                if (i != 1) Console.Write(" + ");   // pouze grafické znázornění
                                Console.Write("{0}", i);    
                            }
                            if (i == x) Console.WriteLine("");      // znovu - že je dělitelné sebou sama nás nezajímá, ale můžeme to využít pro prázdný řádek, tj zase jen grafické znázornění
                        }
                    }
                }

            }

            Console.WriteLine("Všechna výše uvedená čísla jsou součtem všech svých dělitelů vyjma sebe sama.");
            Console.ReadLine();
        }
    }
}
