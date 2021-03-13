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

namespace ConsoleApp11 // PŘÍKLAD 1.11: Rychlost na dálnici
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 60;
            int minP = 1000;              // pokuta je 1000Kč
            int max = 130;
            int maxP = 2000;              // pokuta je 2000Kč
            int maxX = 150;               // rychlostní limit, od kterého se zvyšuje výše pokuty
            int XP = 5;                   // 5 km/h
            int maxXP = 500;              // pokuta je 500Kč
            int rychlost_CA11 = 162;      // rychlost v km/h                         <--------------ZDE ZADEJTE RYCHLOST
            int pokuta_CA11 = 0;
            int pocetXP = 0;


            if ((min < rychlost_CA11) && (rychlost_CA11 < max))
                pokuta_CA11 = 0;
            if (rychlost_CA11 < min)
                pokuta_CA11 = minP;
            if ((max < rychlost_CA11) && (rychlost_CA11 < maxX))
                pokuta_CA11 = maxP;
            if (rychlost_CA11 > maxX)
                pocetXP = ((rychlost_CA11 - maxX) / XP);
            if (rychlost_CA11 > maxX)
                pokuta_CA11 = maxP + (pocetXP * maxXP);



            Console.Write("Při nižší rychlosti než {0} km/h Vám hrozí {1} Kč pokuta," , min, minP);
            Console.Write("ale při vyšší rychlosti než {0} km/h Vám hrozí {1} Kč pokuta," , max, maxP);
            Console.WriteLine("ale pojedete-li více jak {0} km/h, pokuta se s každými dalšími {1} km/h zvyšuje o {2} Kč." , maxX, XP, maxXP);
            Console.Write("Jel jste {0} km/h a hrozí Vám pokuta {1} Kč.", rychlost_CA11, pokuta_CA11);
            Console.Read();
        }
    }
}
