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

namespace Priklad_8_1   // NÁHODNÝ BINÁRNÍ SOUBOR           
{                       //...nebudu volat velká čísla, stačí 100 čísel v intervalu [0; 50], jinak by byly soubory zbytečně objemné
    class Program
    {
        static int[] PoleTazenychCisel()
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
        static void NahodnyBinarniSoubor(int[] poleCisel, string soubor)
        {
            FileStream novySoubor = new FileStream(soubor, FileMode.Create);        ////////////////////////////
            BinaryWriter zapisSouboru = new BinaryWriter(novySoubor);               // NENÍ MOJE TVORBA
            int i;                                                                  //  Použito výukových materiálů (použité jen vlastní názvy)
            zapisSouboru.Write(poleCisel.Length);                                   //  Jan Lánský - Úvod do programování
            for (i = 0; i < poleCisel.Length; i++)                                  //  8. hodina
            {                                                                       //
                zapisSouboru.Write(poleCisel[i]);                                   //
            }                                                                       //
            zapisSouboru.Close();                                                   ////////////////////////////
        }
        static void Main(string[] args)
        {
            PoleTazenychCisel();
            string cestaKSouboru = @"..\..\..\pokus2.doc";                          // FUNKČNÍ - vytvořený soubor je nečitelný, velký 404 B (bytů);
            NahodnyBinarniSoubor(PoleTazenychCisel(), cestaKSouboru);
            Console.ReadLine();
        }
    }
}
