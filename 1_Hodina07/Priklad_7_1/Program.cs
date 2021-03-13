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
using System.IO;

namespace Priklad_7_1   // DLOUHÁ CELÁ ČÍSLA
{
    class Program
    {
        static long VydelDveCisla(string prvni, string druhe)       // g) ...která vydělí číslo číslem
        {
            long podil;
            long prvniNaCeleCislo = Convert.ToInt64(prvni);
            long druheNaCeleCislo = Convert.ToInt64(druhe);

            if (prvniNaCeleCislo < druheNaCeleCislo) podil = druheNaCeleCislo / prvniNaCeleCislo;
            else podil = prvniNaCeleCislo / druheNaCeleCislo;
            Console.WriteLine(podil);
            return podil;
        }
        static decimal VynasobDveCisla(string prvni, string druhe)       // f) ...která vynásobí dvě čísla
        {
            decimal soucin;             // musím na reálný datový typ, jinak přeteče !!!
            decimal prvniNaCeleCislo = Convert.ToDecimal(prvni);      // tyto musí taky být reálného typu
            decimal druheNaCeleCislo = Convert.ToDecimal(druhe);      //

            soucin = prvniNaCeleCislo * druheNaCeleCislo;
            Console.WriteLine(soucin);
            return soucin;
        }
        static long OdectiDveCisla(string prvni, string druhe)       // e) ...která odečte menší číslo od většího
        {
            long rozdil;
            long prvniNaCeleCislo = Convert.ToInt64(prvni);
            long druheNaCeleCislo = Convert.ToInt64(druhe);

            if (prvniNaCeleCislo < druheNaCeleCislo) rozdil = druheNaCeleCislo - prvniNaCeleCislo;
            else rozdil = prvniNaCeleCislo - druheNaCeleCislo;
            Console.WriteLine(rozdil);
            return rozdil;
        }
        static long SectiDveCisla(string prvni, string druhe)        // d) ...která sečte dvě čísla
        {
            long soucet;
            long prvniNaCeleCislo = Convert.ToInt64(prvni);
            long druheNaCeleCislo = Convert.ToInt64(druhe);

            soucet = prvniNaCeleCislo + druheNaCeleCislo;
            Console.WriteLine(soucet);
            return soucet;
        }
        static int Porovnej(string prvni, string druhe)     // c) ...která porovná dvě čísla...
        {
            int rovnost = 0;
            long prvniNaCeleCislo = Convert.ToInt64(prvni);    // decimal použit pouze proto, že delší vstupní text
            long druheNaCeleCislo = Convert.ToInt64(druhe);    // vyleze jako několika bitové číslo a dojde k přetečení, resp. vyhodnotí se to jako chyba
            
            if (prvniNaCeleCislo < druheNaCeleCislo) rovnost = -1;
            else if (prvniNaCeleCislo > druheNaCeleCislo) rovnost = 1;

            Console.WriteLine("{0}", rovnost);
            return rovnost;
        }
        static string VypisCiselnePole(int[] ciselnePole)      // b) ...která vypíše číslo na obrazovku bez zbytečných nul.
        {
            int i;
            string ciselko = "";
            for (i = 0; i < ciselnePole.Length; i++)
            {
                if (ciselnePole[i] == 0 && ciselnePole[i + 1] == 0 && ciselnePole[i + 2] == 0 && ciselnePole[i + 3] == 0) break;  // tady použijeme znalosti ASCII tabulky a budeme počítat s tím, že je-li více jak tři cifry rovno 0
                                                                                             // ...pak i zbytek budou nuly a už je nemusíme vypisovat...
                ciselko += ciselnePole[i];
            }
            Console.Write(ciselko);
            Console.WriteLine("");      // jen pro lepší čitelnost            
            
            return ciselko;
        }
        static int[] PrevedTextNaCislo(string text)          // a) ...která převede textový řetězec na číslo.
        {
            char[] textNaPoleZnaku = text.ToCharArray();
            //Console.WriteLine(textNaPoleZnaku);
            int[] ciselnePole = new int[10]; // omezení na 100 čísel
            int i;
            for (i = 0; i < textNaPoleZnaku.Length; i++)
            {
                int ciselneVyjadreniZnaku = Convert.ToInt32(textNaPoleZnaku[i]);
                ciselnePole[i] = ciselneVyjadreniZnaku;   // pokud existují v řetězci písmena, přepíše je na číselnou hodnotu dle ASCII
            }
            while (i >= textNaPoleZnaku.Length && i < ciselnePole.Length)
            {
                ciselnePole[i] = 0;     // pokud písmena došla, doplní zbytek nulama...
                i++;
            }
            //VypisCiselnePole(ciselnePole);
            return ciselnePole;
        }
        static void Main(string[] args)
        {
            string textovyRetezec = "Ahoj";
            string textovyRetezec_2 = "Hello";
            Console.WriteLine("Vstup 1: {0}\nVstup 2: {1}", textovyRetezec, textovyRetezec_2);
            Console.WriteLine("Vstupy na celá čísla:");
            PrevedTextNaCislo(textovyRetezec);
            PrevedTextNaCislo(textovyRetezec_2);
            

            string a = VypisCiselnePole(PrevedTextNaCislo(textovyRetezec));
            string b = VypisCiselnePole(PrevedTextNaCislo(textovyRetezec_2));

            Console.Write("Výsledek porovnání: ");
            Porovnej(a, b);
            Console.Write("Součet: ");
            SectiDveCisla(a, b);
            Console.Write("Rozdíl: ");
            OdectiDveCisla(a, b);
            Console.Write("Součin: ");
            VynasobDveCisla(a, b);
            Console.Write("Podíl: ");
            VydelDveCisla(a, b);

            Console.ReadLine();
        }
    }
}
