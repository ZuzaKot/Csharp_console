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

namespace Priklad_8_3   // SOUČET ČÍSEL NA ŘÁDKU            ...a že jsem se zapotila...! :-)
{
    class Program
    {
        static int[] PoleTazenychCisel()            // z Priklad_8_1 (nebudu se přece obtěžovat vymyslet řetězec čísel :-) )
        {
            Random nahodne = new Random();
            int[] tazene = new int[100];            // vypíše 100 náhodných čísel
            int i;
            int nove;
            for (i = 0; i < tazene.Length; i++)
            {
                nove = nahodne.Next(0, 51);         // jen v intervalu [0; 50]
                tazene[i] = nove;
                Console.Write("{0}, ", tazene[i]);
            }
            return tazene;
        }
        static void VytvoreniNovehoSouboru(int[] poleCisel, string soubor)      // hezky funkční, vytvoří to texťák a zapíše do něj, co chci
        {
            FileStream novySoubor = new FileStream(soubor, FileMode.Create);
            novySoubor.Close();                         // musíme teď nově vytvořený .txt dokument zavřít, jinak nemůžeme v dalším kroku do dokumentu zapisovat
            StreamWriter zapisCisel = new StreamWriter(soubor); // nebo bych tady nesměla volat soubor, ale novySoubor

            int i;
            for(i = 0; i < poleCisel.Length; i++)
            {
                zapisCisel.WriteLine(poleCisel[i]);
            }
            zapisCisel.Close();
        }
        static void KopieSouboruPoRadcich(string zdroj, string cil)
        {
            StreamReader cteniZdroje = new StreamReader(zdroj);
            StreamWriter zapisDoCile = new StreamWriter(cil);
            int i;
            for (i = 0; i < 100; i++)               // vytvoří hezkou přehlednou tabulku 10 x 10 z čísel dle původního dokumentu
            {
                if (i % 10 == 0) zapisDoCile.WriteLine();
                zapisDoCile.Write("{0} ", cteniZdroje.ReadLine());
            }
            cteniZdroje.Close();
            zapisDoCile.Close();
        }
        static void ScitaniPoRadcich(string zdroj, string cil)
        {
            StreamReader cteniZdroje = new StreamReader(zdroj);
            StreamWriter zapisDoCile = new StreamWriter(cil);

            int i, soucet = 0, pomocne;
            for (i = 0; i <= 100; i++)
            {                                                           ////////////////////////////////    nutno hlídat kde se to volá! jinak to nefunguje!
                pomocne = Convert.ToInt32(cteniZdroje.ReadLine());      // POZOR! TOTO JE KLÍČOVÉ!!! ///    pokud bych vložila hodnoty do pomocne před cyklem, stále by mi to opakovalo jen 1. řádek, nic víc
                if ((i % 10 != 0) || (i == 0)) soucet += pomocne;       ////////////////////////////////
                else if (i % 10 == 0)
                {
                    zapisDoCile.WriteLine();
                    zapisDoCile.Write("{0} ", soucet);
                    soucet = 0;     // nechám to tak, aby bylo vidět, že vyprazdňuji zásobník,
                    soucet += pomocne;  // ale současně musím přičíst i číslo, které má index dělitelný 10
                }
            }
            cteniZdroje.Close();
            zapisDoCile.Close();
        }
        static void Main(string[] args)
        {
            //PoleTazenychCisel();            // když to volám i tady, nemůžu se divit, že mi konzole vypisuje jiná náhodná čísla, než....
            string novySoubor = @"..\..\..\vytvorenySoubor_sNahodnymiCisly.txt";
            VytvoreniNovehoSouboru(PoleTazenychCisel(), novySoubor);        //...než tady ukládá do souboru, kdy funkci náhodných čísel volám znova. :-D

            string kopieSouboru = @"..\..\..\kopieSouboru_sCislyVRade.txt";
            KopieSouboruPoRadcich(novySoubor, kopieSouboru);

            string vyslednySoubor = @"..\..\..\vyslednySoubor_soucetCiselVRade.txt";
            ScitaniPoRadcich(novySoubor, vyslednySoubor);

            Console.ReadLine();
        }
    }
}
