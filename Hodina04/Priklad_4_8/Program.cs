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

namespace Priklad_4_8   // ZAPLATIT MINCEMI
{
    class Program
    {
        static void Mince()
        {
            int[] mince = { 50, 20, 10, 5, 2, 1 };
            Console.WriteLine("Zadejte částku v Kč: ");
            int castka = Convert.ToInt32(Console.ReadLine());
            int castka2 = castka;
            int i;
            int soucetMinci = 0;
            int[] pocet = new int[6];
            for (i = 0; castka > 0; i++)
            {
                while (castka - mince[i] >= 0)
                {
                    castka = castka - mince[i];
                    pocet[i]++;
                    soucetMinci++;
                }
            }

            Console.WriteLine("mince = {0}, {1}, {2}, {3}, {4}, {5}", mince[0], mince[1], mince[2], mince[3], mince[4], mince[5]);
            Console.WriteLine("pocet = {0}, {1}, {2}, {3}, {4}, {5}", pocet[0], pocet[1], pocet[2], pocet[3], pocet[4], pocet[5]);
            Console.WriteLine("Minimální počet mincí k zaplacení částky {0} je {1}.", castka2, soucetMinci);

        }
        static void Main(string[] args)
        {
            Mince();
            Console.ReadLine();

        }
    }
}
