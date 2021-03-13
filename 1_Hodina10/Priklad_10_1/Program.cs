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

namespace Priklad_10_1   // REKURZE S JEDNÍM VOLÁNÍM
// S využitím rekurze napište následující funkce. Na začátku každé funkce bude výpis
// (v režimu Append) do souboru log.txt. Zapisovat budeme: (1) volání funkce a hodnotu parametrů;
// (2) ukončení funkce a návratová hodnota. Otevřený soubor bude jedním z parametrů funkce.
//      a) Rekurzivní funkce zanořující se na podproblém velikosti n-1, která vrátí hodnotu
// nejmenšího prvku v poli.
//      b) Rekurzivní funkce zanořující se na podproblém velikosti n-1, která vrátí součet prvků
// v poli, které mají kladnou hodnotu.
//      c) Rekurzivní funkce zanořující se na dva podproblémy velikosti n/2, která vrátí hodnotu
// nejmenšího prvku v poli.
//      d) Rekurzivní zanořující se na dva podproblémy velikosti n/2, která vrátí součet prvků
// v poli, které mají kladnou hodnotu.


// ENG
// RECURSIVE FUNCTION WITH ONE CALL
// Use recursive to write following functions. There will be listed to file log.txt
// at the beginning of each. We will write: (1) call the function with parameter,
// (2) end of function and returned value. Open file will be one of parameter of function.
//    a) Recursive function (size n-1), which returns the smallest value of element.
//    b) Recursive function (size n-1), which returns the sum of the elements with a positive value.
//    c) Recursive function (size n/2), which returns the smallest value of element.
//    d) Recursive function (size n/2), which returns the sum of the elements with a positive value.

{
    class Program
    {
        static void PocetKladnych(StreamWriter doc, int[] p, int aktualniIndex, int maxIndex, int soucet)
        {
            if ((maxIndex >= 0) && (aktualniIndex < maxIndex))
            {
                doc.WriteLine("PocetKladnych\t(p[], aktualniIndex = {0}, maxIndex = {1}, soucet = {2})", aktualniIndex, maxIndex, soucet);
                if (p[aktualniIndex] > 0) soucet++;
                if (p[maxIndex] > 0) soucet++;
                PocetKladnych(doc, p, aktualniIndex + 1, maxIndex - 1, soucet);
            }
            else Console.WriteLine("Počet kladných čísel v poli: {0}", soucet);
        }
        static void NejmensiPrvek(StreamWriter doc, int[] p, int aktualniIndex, int maxIndex, int nejmensi)
        {
            doc.WriteLine("NejmensiPrvek\t(p[], aktualniIndex = {0}, nejmensi = {1})", aktualniIndex, nejmensi);
            if ((maxIndex >= 0) && (aktualniIndex < maxIndex))
            {
                nejmensi = Math.Min(p[aktualniIndex], nejmensi);
                nejmensi = Math.Min(p[maxIndex], nejmensi);
                NejmensiPrvek(doc, p, aktualniIndex + 1, maxIndex - 1, nejmensi);
            }
            else Console.WriteLine("Nejmenší prvek pole: {0}", nejmensi);
        }
        static void SoucetKladnych(StreamWriter doc, int[] p, int aktualniIndex, int soucet)
        {
            doc.WriteLine("SoucetKladnych\t(p[], aktualniIndex = {0}, soucet = {1})", aktualniIndex, soucet);
            if (aktualniIndex < p.Length)
            {
                if (p[aktualniIndex] >= 0) soucet = soucet + p[aktualniIndex];
                SoucetKladnych(doc, p, aktualniIndex + 1, soucet);
            }
            else Console.WriteLine("Součet kladných čísel v poli: {0}", soucet);
        }
        static void Min(StreamWriter doc, int[] p, int maxIndexP, int indexNejmensiP)
        {
            doc.WriteLine("Min\t(p[], maxIndexP = {0}, indexNejmensiP = {1})", maxIndexP, indexNejmensiP);
            if (maxIndexP >= 0)
            {
                if (p[maxIndexP] < p[indexNejmensiP]) indexNejmensiP = maxIndexP;
                Min(doc, p, maxIndexP - 1, indexNejmensiP);
            }
            else Console.WriteLine("Nejmenší prvek z pole: {0}", indexNejmensiP);
        }
        static void Main(string[] args)
        {
            int[] p = { 7, 6, 8, -3, 0, 13, -5, 50, 13, -27, -4, -26};      // LZE MĚNIT HODNOTY
            int maxIndexP = p.Length - 1;
            int indexNejmensiP = 0;
            int soucetKladnych = 0;

            string soubor = @"..\..\..\log.txt";
            StreamWriter dokument = new StreamWriter(soubor);
                Min(dokument, p, maxIndexP, indexNejmensiP);
                SoucetKladnych(dokument, p, indexNejmensiP, soucetKladnych);
                NejmensiPrvek(dokument, p, indexNejmensiP, maxIndexP, soucetKladnych);
                PocetKladnych(dokument, p, indexNejmensiP, maxIndexP, soucetKladnych);
            dokument.Close();

            Console.ReadLine();
        }
    }
}
