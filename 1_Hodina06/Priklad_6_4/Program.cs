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

namespace Priklad_6_4   // RULETA
 /*
    TABULKA SÁZEK A VÝHER
    a) jednotlivé číslo (0 až 36), výhra 35x vsazená suma
    b) liché číslo (1,3,5,...35) nebo sudé číslo (2,4,6,...36), výhra 1x vsazená suma
    c) malé číslo (1 až 18) nebo vysoké číslo (19 až 36), výhra 1x vsazená suma
    d) tucet: první (1 až 12), druhý (13 až 24), třetí (25 až 36), výhra 2x vsazená suma
 
vstupní data jsou ve formátu: sázka vsazenaCastka sázka vsazenáČástka sázka vsazenáČástka....
kdy vsazenáČástka odpovídá sázce před ní napsané, např. "2 10" znamená, že na číslo 2 je vsazeno 10Kč
                                                        "5 20 sudá 100" znamená, že je na číslo 5 vsazeno 20Kč a na sudé číslo 100Kč 
 */
{
    class Program
    {
        static bool JeLiche(int x)
        {
            if (x % 2 != 0) return true;
            else return false;
        }
        static bool JeMale(int x)
        {
            if (x < 19) return true;
            else return false;
        }
        static int Tucet(int x)
        {
            if (x < 13) return 1;
            else if (x < 26) return 2;
            else return 3;
        }
        static int TahCisla()
        {
            Random tazeneCislo = new Random();
            int tC = tazeneCislo.Next(0, 37);
            Porovnani(tC);
            return tC;

        }
        static void Porovnani(int tC)
        {
            int jakyTucet = Tucet(tC);
            bool zdaMale = JeMale(tC);
            bool zdaLiche = JeLiche(tC);

            Console.WriteLine("{0}", tC);
            Console.WriteLine("{0}. tucet", jakyTucet);
            if (zdaMale) Console.WriteLine("malé");
            else Console.WriteLine("velké");
            if (zdaLiche) Console.WriteLine("liché");
            else Console.WriteLine("sudé");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo 0 - 36");
                int vstupniCislo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zadejte sázku v Kč");
                    int sazka1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sudé nebo liché?");
                string vSL = Console.ReadLine();
                Console.WriteLine("Zadejte sázku v Kč");
                    int sazka2 = Convert.ToInt32(Console.ReadLine());
                bool vstupniSL;
                if (vSL == "sude") vstupniSL = false;
                else vstupniSL = true;
            Console.WriteLine("Velké nebo malé?");
                string vVM = Console.ReadLine();
                Console.WriteLine("Zadejte sázku v Kč");
                    int sazka3 = Convert.ToInt32(Console.ReadLine());
                bool vstupniVM;
                if (vVM == "velke") vstupniVM = false;
                else vstupniVM = true;
            Console.WriteLine("Který tucet? (1 - 3)");
                int vKT = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zadejte sázku v Kč");
                    int sazka4 = Convert.ToInt32(Console.ReadLine());
                int vstupniKT = Tucet(vKT);

            
            int vyhra1 = sazka1 * 35;
            int vyhra2 = sazka2 * 1;
            int vyhra3 = sazka3 * 1;
            int vyhra4 = sazka4 * 2;
            int vyhraCelkem = 0;
            
            Console.WriteLine("\n\n");
            

            int tazeneCislo = TahCisla();

            if (tazeneCislo == vstupniCislo)
            {
                Console.WriteLine("BINGO! Výhra {0}Kč!", vyhra1);
                vyhraCelkem += vyhra1;
            }
            else
            {
                Console.WriteLine("Škoda...-{0}Kč", sazka1);
                vyhraCelkem -= sazka1;
            }


            if ((vstupniSL == JeLiche(tazeneCislo)) && (JeLiche(tazeneCislo) == true))
            {
                Console.WriteLine("BINGO, je liché! Výhra {0}Kč!", vyhra2);
                vyhraCelkem += vyhra2;
            }
            else if ((vstupniSL == JeLiche(tazeneCislo)) && (JeLiche(tazeneCislo) == false))
            {
                Console.WriteLine("BINGO, je sudé! Výhra {0}Kč!", vyhra2);
                vyhraCelkem += vyhra2;
            }
            else
            {
                Console.WriteLine("Škoda...-{0}Kč", sazka2);
                vyhraCelkem -= sazka2;
            }

            if ((vstupniVM == JeMale(tazeneCislo)) && (JeMale(tazeneCislo) == true))
            {
                Console.WriteLine("BINGO, je malé! Výhra {0}Kč!", vyhra3);
                vyhraCelkem += vyhra3;
            }
            else if ((vstupniVM == JeMale(tazeneCislo)) && (JeMale(tazeneCislo) == false))
            {
                Console.WriteLine("BINGO, je velké! Výhra {0}Kč!", vyhra3);
                vyhraCelkem += vyhra3;
            }
            else
            {
                Console.WriteLine("Škoda...-{0}Kč", sazka3);
                vyhraCelkem -= sazka3;
            }

            if (vKT == Tucet(tazeneCislo))
            {
                Console.WriteLine("BINGO, je to {0}. tucet! Výhra {1}Kč!", vKT, vyhra4);
                vyhraCelkem += vyhra4;
            }
            else
            {
                Console.WriteLine("Škoda...-{0}Kč", sazka4);
                vyhraCelkem -= sazka4;
            }

            
            Console.WriteLine("Výhra v tomto kole: {0}Kč", vyhraCelkem);
            
            Console.ReadLine();
        }
    }
}
