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

namespace Priklad_8_5   // ŘÁDKY SE ZADANÝM ŘETĚZCEM
{
    class Program
    {
        static void HledejSlova(string zakladniText, string hledaneSlovo)
        {
            FileStream vytahZPuvodniho = new FileStream("..\\..\\..\\vytah_zPovidani.txt", FileMode.Create);
            StreamWriter zapisVytahu = new StreamWriter(vytahZPuvodniho);
            StreamReader prohledavanyDokument = new StreamReader(zakladniText);
            int i, j;
            string s;
            char[] hledaneSlovoVZnacich = hledaneSlovo.ToCharArray();       //  převedení hledaného slova na pole znaků
            int a = hledaneSlovoVZnacich.Length;                            // délka hledaného znaku
            while ((s = prohledavanyDokument.ReadLine()) != null)           //  dokud není na konci dokumentu, pak.....
            {
                string radek = s;                                       // radek = celý aktuální řádek
                char[] radekVZnacich = radek.ToCharArray();             // radek převedený na pole znaků
                int n = radekVZnacich.Length;                           // počet znaků na řádek
                for (i = 0; i <= n - a; i++)        // dokud jsou na radku znaky, pak.....
                {
                    for (j = 0; j < a; j++)    // dokud je menší než délka hledaného slova, pak...
                    {
                        if (radekVZnacich[i] != hledaneSlovoVZnacich[j]) break; // pokud znak ze řádku neodpovídá znaku ve slově, pak jedeme v řádku dál a hledáme, co bude odpovídat
                        else
                        {   // pokud ale odpovídá znak ze řádku znaku v hledaném slově, pak....
                            if ((j < a - 1) && (radekVZnacich[i] == hledaneSlovoVZnacich[j]))
                            {           
                                i = i + 1; // zkontrolujeme celé slovo na řádku
                                continue;
                            }
                            else
                            {
                                zapisVytahu.WriteLine(radek); // pokud najde celé hledané slovo, vypíše celý řádek :-)
                                i = n - 1;  // skočí na konec prohledávaného řádku, pokud bych to neudělala, tak vypíše řádek pokaždé, kdy najde hledané slovo...
                            }
                        }
                    }
                }
            }
            prohledavanyDokument.Close();
        }
        static void Main(string[] args)
        {
            string zakladniText = @"..\..\..\povidani_text.txt";
            string hledaneSlovo = "GitHub";
            HledejSlova(zakladniText, hledaneSlovo);

            //Console.ReadLine();
        }
    }
}
