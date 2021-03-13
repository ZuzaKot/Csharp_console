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

namespace Priklad_5_5   // BINÁRNÍ VYHLEDÁVÁNÍ
{
    class Program
    {
        static int BinarniVyhledavani(int[] pole, int hodnota)       
        {                                                                   ///////////////////////////////////
            int stred, levy = 0, pravy = pole.Length - 1;                   //  NENÍ MOJE TVORBA
            while (pravy >= levy)                                           //  Zdroj: výukové materiály
            {                                                               //  Jan Lánský, Úvod do programování
                stred = (levy + pravy) / 2;                                 //  hodina 5.
                if (pole[stred] == hodnota) return stred;                   //  str. 21 - VZESTUPNĚ seřazené pole
                else if (pole[stred] < hodnota) pravy = stred + 1;          /////////////////////////////////////
                else levy = stred - 1;                                      //  UPRAVENÉ, aby bralo SESTUPNĚ 
            }                                                               //                  seřazené pole
            return -1;                                                      ///////////////////////////////////
        }                                                                   // binární vyhledávání není spolehlivý způsob...‼☺
        static void Main(string[] args)
        {
            int[] ciselnaRada = { 105, 43, 37, 23, 16, 11, 9, 6, 4, 1};
            int hledane = 37;
            Console.Write("Číselná řada: ");
            for (int i = 0; i < ciselnaRada.Length; i++) Console.Write("{0}, ", ciselnaRada[i]);
            Console.WriteLine("\nHledáme číslo: {0}", hledane);
            
            int s = BinarniVyhledavani(ciselnaRada, hledane);
            Console.WriteLine("\nČíslo {0} se nachází na {1}. místě číselné řady.", hledane, s + 1);
            Console.ReadLine();
        }
    }
}
