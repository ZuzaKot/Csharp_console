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

namespace Priklad_8_2   // PŘEVOD BINÁRNÍHO SOUBORU NA TEXTOVÝ
{
    class Program
    {
        static void PocetZnakuVSouboru(string soubor)
        {
            FileInfo pocetZnaku= new FileInfo(soubor);
            StreamReader otevriSoubor = new StreamReader(soubor);
            
            Console.WriteLine(pocetZnaku.Name + " - " + pocetZnaku.Length + " B");
            // zobrazuje název souboru a jeho velikost  (404 je velikost souboru v B (bytech))
            otevriSoubor.Close();
        }
        static void PrevedZBinaruDoTextaku(string zdroj, string cil)
        {
            FileStream puvodniZdroj = new FileStream(zdroj, FileMode.Open);
            FileStream novyCil = new FileStream(cil, FileMode.Create);
            
            BinaryReader cteckaBinaru = new BinaryReader(puvodniZdroj);
            StreamWriter zapisDoCile = new StreamWriter(novyCil);

            int i;
            for (i = 0; i < puvodniZdroj.Length; i++)
            {
                int pokus = cteckaBinaru.Read();
                zapisDoCile.Write(pokus);
                if (i % 40 == 0) zapisDoCile.WriteLine();
                if (i % 1000 == 0) zapisDoCile.Flush();
            }
            
            zapisDoCile.Close();
            // nooooo, skoro.... vypíše tabulku 10 x 10 čísel (převede z binárního souboru do texťáku)
            // ale čísla jsou prokládaná "000" (třema nulama), to by chtělo ještě nějak ošetřit...
            
        }
        static void Main(string[] args)
        {
            string cestaKSouboru = @"..\..\..\pokus2.doc";
            PocetZnakuVSouboru(cestaKSouboru);

            string novySoubor = @"..\..\..\pokus2.txt";
            PrevedZBinaruDoTextaku(cestaKSouboru, novySoubor);
            PocetZnakuVSouboru(novySoubor);

            Console.ReadLine();
        }
    }
}
