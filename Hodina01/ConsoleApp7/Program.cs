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

namespace ConsoleApp7 // PŘÍKLAD 1.7: Lichá vs. sudá čísla
{
    class Program
    {
        static void Main(string[] args)
        {                                                    //  Prostor pro úpravy hodnot
            int x = 30;                                      //  <---- ZDE ZADEJTE ČÍSLO
            int y = 18;                                      //  <---- ZDE ZADEJTE ČÍSLO
            int z = 111;                                     //  <---- ZDE ZADEJTE ČÍSLO
            int licha = 0;
            int suda = 0;

            Console.Write("Máme čísla {0}, {1} a {2},", x, y, z);

            /////////////////////////////////////////////////////////////////////////////////////////////////
            if (x % 2 == 1)                                             // NENÍ MOJE TVORBA
                licha++;                                                // Čerpáno z výukových materiálů
            else suda++;
            if (y % 2 == 1)
                licha++;
            else suda++;
            if (z % 2 == 1)
                licha++;
            else suda++;
            Console.WriteLine(" z toho sudých čísel je: {0} a lichých: {1}.", suda, licha);
            //////////////////////////////////////////////////////////////////////////////////////////////////

            int soucSud_CA7 = 0;
            int soucLic_CA7 = 0;

            if (x % 2 == 1)
                soucLic_CA7 = soucLic_CA7 + x;
            else soucSud_CA7 = soucSud_CA7 + x;

            if (y % 2 == 1)
                soucLic_CA7 = soucLic_CA7 + y;
            else soucSud_CA7 = soucSud_CA7 + y;

            if (z % 2 == 1)
                soucLic_CA7 = soucLic_CA7 + z;
            else soucSud_CA7 = soucSud_CA7 + z;


            if (soucSud_CA7 > soucLic_CA7)
                Console.WriteLine("Součet sudých čísel je {0}, tedy je vyšší, než součet lichých čísel, který je {1}.", soucSud_CA7, soucLic_CA7);
            if (soucLic_CA7 > soucSud_CA7)
                Console.WriteLine("Součet lichých čísel je {0}, tedy je vyšší, než součet sudých čísel, který je {1}.", soucLic_CA7, soucSud_CA7);


            Console.Read();
        }
    }
}
