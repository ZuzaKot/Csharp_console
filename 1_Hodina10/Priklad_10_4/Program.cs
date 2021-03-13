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

namespace Priklad_10_4   // FALEŠNÁ MINCE
// Na vstupu je pole, obsahující hmotnosti mincí. Všechny mince mají shodnou hmotnost s výjimkou
// jedné falešné mince, která má hmotnost menší. K dispozici máme dvojramennou váhu,
// pomocí které můžeme porovnat hmotnost jedné skupiny mincí vůči hmotnosti druhé
// skupiny mincí. Napište funkci, která vrátí index falešné mince za použití co nejmenšího
// počtu vážení. Nápověda: počet vážení řádově odpovídající počtu mincí je neefektivní.

// ENG
// FALSE COIN
// There is a field includes weight of coins as a input. All of coins have same weight
// except false one which has lower weight. We have got two-arm weighing scale and we can
// compare weight of two groups of coins. Write a function which returns index of false coin
// by using repetitions as less as possible.


{
    class Program
    {
        static void IndexFM(int[] poleMinci, int aktualniIndex, int maxIndex, int vaha)
        {
            if (aktualniIndex <= maxIndex)
            {
                if ((poleMinci[aktualniIndex] == vaha) && (poleMinci[maxIndex] == vaha)) IndexFM(poleMinci, aktualniIndex + 1, maxIndex - 1, vaha);
                else if (poleMinci[aktualniIndex] != vaha) Console.WriteLine("Index falešné mince: {0}", aktualniIndex);
                else if (poleMinci[maxIndex] != vaha) Console.WriteLine("Index falešné mince: {0}", maxIndex);
            }
        }
        static int[] NaplnPole(int pocet, int vaha)
        {
            Random nahoda = new Random();
            int indexFMince = nahoda.Next(pocet);
            int vahaFMince = vaha - 1;
            int[] novePole = new int[pocet];
            for (int i = 0; i < pocet; i++)
            {
                novePole[i] = vaha;
                if (i == indexFMince) novePole[i] = vahaFMince;
                Console.Write("{0}, ", novePole[i]);
            }
            return novePole;
        }
        static void Main(string[] args)
        {
            int pocetMinci = 1000;
            int vahaMince = 5;
            int maxIndex = pocetMinci - 1;
            int aktualniIndex = 0;

            NaplnPole(pocetMinci, vahaMince);
            IndexFM(NaplnPole(pocetMinci, vahaMince), aktualniIndex, maxIndex, vahaMince);



            Console.ReadLine();
        }
    }
}
