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

namespace Priklad_2_9_ef   // STATISTICKÉ INFORMACE             // dodělání příkladu 2.9. (c, d, e, f)
{
    class Program
    {
        static void Nejmensi_Nejvetsi(int[] pole)
        {
            int pocetPrvku = pole.Length;
            int j = 0;
            while (j < pocetPrvku)
            {
                Console.Write("{0}, ", pole[j]);
                j++;
            }

            int i;
            int nejmensi = 0;
            int mensi = 0;
            int nejvetsi = 0;
            int vetsi = 0;
            for (i = 1; i < pocetPrvku; i++)
            {
                if ((nejmensi == 0) && (mensi == 0))
                {
                    nejmensi = Math.Min(pole[i - 1], pole[i]);
                }
                else
                {
                    mensi = Math.Min(pole[i - 1], pole[i]);
                    if (mensi <= nejmensi)
                    {
                        int tmp = nejmensi;
                        nejmensi = mensi;
                        mensi = nejmensi;
                    }
                }

                vetsi = Math.Max(pole[i - 1], pole[i]);
                if (vetsi >= nejvetsi)
                {
                    int tmp = nejvetsi;
                    nejvetsi = vetsi;
                    vetsi = nejvetsi;
                }
            }
            Console.Write("\nnejmensi = {0}, mensi = {1}, vetsi = {2}, nejvetsi = {3},", nejmensi, mensi, vetsi, nejvetsi);

        }
        static void Main(string[] args)
        {
            int[] zadaneHodnotyPole = { 30, 6, 18, 24, 16 };
            Nejmensi_Nejvetsi(zadaneHodnotyPole);

            Console.ReadLine();
        }
    }
}
