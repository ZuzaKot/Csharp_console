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

namespace Priklad_6_1   // PRÁCE S TEXTOVÝMI ŘETĚZCI            // zatím pouze a) a b)      (body c) - f) nemám)
{
    class Program
    {
        static int PocetSlov(string x)
        {
            int pocetMezer = 0;
            int i;
            for (i = 0; i < x.Length; i++)
            {
                char a = x[i];
                if (!char.IsLower(a)) pocetMezer++;
            }
            int pocet = pocetMezer - 1; 
            return pocet;
        }
        static int PocetRuznychPismen(string x)
        {
            int pocet = 0;
            x = x.ToLower();                            // vstup převeden na znaky v ASCII (97-122)
            //Console.WriteLine(x);

            int i;
            for (i = 97; i < 123; i++)                  // prohledává ASCII v rozmezí 97-122
            {
                char a = (char)i;                       // převádí čísla na znaky
                bool obsahuje = x.Contains(a);          // prohledává ve vstupu shodu s ASCII
                if (obsahuje) pocet++;                  // počítá rozdílná písmena ve vstupu
            }
            return pocet;
        }
        static int PocetPismen(string x)
        {
            int pocet = 0;
            x = x.ToLower();
            Console.WriteLine(x);

            int j;
            for (j = 0; j < x.Length; j++)
            {
                char k = x[j];
                string k2 = k.ToString();

                int i;
                for (i = 97; i < 123; i++)
                {
                    char a = (char)i;
                    string a2 = a.ToString();

                    int porovnani = string.Compare(k2, a2);
                    if (porovnani == 0) pocet++;

                }
            }
            return pocet;
        }
        static void Main(string[] args)
        {
            //string vstupniRetezec = "Dum spiro spero.";
            //string vstupniRetezec = "Per aspera ad astra.";
            string vstupniRetezec = "Scire est scire ubi est.";
            Console.WriteLine("Vstupní řetězec: {0}", vstupniRetezec);

            //int pp = PocetPismen(vstupniRetezec);
            //Console.WriteLine(pp);

            int prp = PocetRuznychPismen(vstupniRetezec);
            Console.WriteLine("Počet různých písmen: {0}", prp);

            int ps = PocetSlov(vstupniRetezec);
            Console.WriteLine("Počet slov: {0}", ps);

            Console.ReadLine();
        }
    }
}
