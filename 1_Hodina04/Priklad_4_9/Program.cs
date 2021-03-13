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

namespace Priklad_4_9   // SPORTKA                      // :-) zdá se to funkční :-)
{
    class Program
    {
        static int[] VsadSi(int length, int min, int max)
        {
            Console.WriteLine("Vsaďte si 6 čísel od 1 do 49.");
            //int[] vsazeno = { 3, 6, 18, 34, 37, 41 };

            int i;
            int[] vsazeno = new int[length];
            for (i = 0; i < length; i++)
                vsazeno[i] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nVáš tah:\n{0}, {1}, {2}, {3}, {4}, {5}", vsazeno[0], vsazeno[1], vsazeno[2], vsazeno[3], vsazeno[4], vsazeno[5]);
            return vsazeno;
        }
        static int[] Sportka1(int length, int min, int max)
        {
            Random losovaneCislo1 = new Random();
            int[] vylosovana = new int[length];
            int i, j;
            //int nejmensi = 50;
            for (i = 0; i < length; i++)
            {
                vylosovana[i] = losovaneCislo1.Next(min, max);
                if ((i > 0) && (vylosovana[i] == vylosovana[i - 1])) vylosovana[i] = losovaneCislo1.Next(min, max);
            }
            Console.WriteLine("\nVylosovaná čísla - 1. tah:\n{0}, {1}, {2}, {3}, {4}, {5} / {6}", vylosovana[0], vylosovana[1], vylosovana[2], vylosovana[3], vylosovana[4], vylosovana[5], vylosovana[6]);
            Console.WriteLine("\nVylosovaná čísla - 2. tah:\n{0}, {1}, {2}, {3}, {4}, {5} / {6}", vylosovana[7], vylosovana[8], vylosovana[9], vylosovana[10], vylosovana[11], vylosovana[12], vylosovana[13]);
            return vylosovana;
        }
        static void Porovnej(int[]x, int[]y)
        {
            int i, j;
            int match = 0;
            for (i = 0; i < x.Length; i++)
            {
                for (j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j]) match++;
                }
            }
            switch (match)
            {
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("\nJe nám líto. Snad to vyjde příště.\n");
                    break;
                case 3:
                    Console.WriteLine("\nGratulujeme! Vaše výhra činí: 113 Kč.\n");
                    break;
                case 4:
                    Console.WriteLine("\nGratulujeme! Vaše výhra činí: 619 Kč.\n");
                    break;
                case 5:
                    Console.WriteLine("\nGratulujeme! Vaše výhra činí: 24 971 Kč.\n");
                    break;
                case 6:
                    Console.WriteLine("\nGratulujeme! Vaše výhra činí: 815 723 Kč.\n");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte počet tahů:");
            int xKrat = Convert.ToInt32(Console.ReadLine());
            int i;
            for (i = 0; i <= xKrat - 1; i++) Porovnej(VsadSi(6, 1, 50), Sportka1(14, 1, 50));
            int naklady = i * 20;
            Console.WriteLine("Celkové náklady na tento ticket: {0} Kč.", naklady);
            Console.ReadLine();
        }
    }
}
