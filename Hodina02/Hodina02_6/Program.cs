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

namespace Hodina02_6 // PŘÍKLAD 2.6: PRVOČÍSLA
{
    class Program
    {
        static void Main(string[] args)
        {                                       // Bože! Jak já se u tohohle příkladu zapotila! Ufff! :-D
            int x;
            int i;

            for(x = 2; x < 1000; x++)           // opakujeme x od prvního do posledního čísla řady (ze zadání všechna do 1000)
            {
                for (i = 1; i <= x; i++)        // i nám v tomto případě poslouží jako dělitel x
                {
                    if (x % i != 0)             // pokud nemá celočíselného dělitele, vrací se do for -> i++
                    {
                       continue;
                    }
                    else if ((x % i == 0) && (i != 1) && (i != x))         //našel se celočíselný dělitel, který je jiný od 1 a x
                    {
                       break;                   // toto číslo je tedy dělitelné něčím menším než je samo, tedy jdeme na další x (vyskakujeme z tohoto for)
                    }
                    else if (x == i)            // už vyzkoušel všechny varianty k dělení a zbývá už jen dělit sebe sama
                    {
                        Console.Write("{0}, ", x);     //už máme jasno, že splňuje podmínky pro prvočíslo a lze jej tedy zapsat.
                        break;                         // znovu se vracíme do prvního for a děláme totéž pro všechna čísla x, která splňují uvedené podmínky
                    }
                }
            }
            Console.ReadLine();                 // oh my god... :-D takhle to vypadá easy, ale já se rosila úplně všude :-D
        }
    }
}
