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

namespace Priklad_8_4   // ZMĚNA VELIKOSTI PÍSMEN
{   
    class Program
    {
        static void ZformatujDokument(string zdroj, string cil)        
        {
            FileStream vytvoreniNovehoDokumentu = new FileStream(cil, FileMode.Create);
            vytvoreniNovehoDokumentu.Close();

            StreamReader zdrojovyDokument = new StreamReader(zdroj);
            StreamWriter zapisujDoNoveho = new StreamWriter(cil);

            int i = 0;
            string s;
            string nadpis = zdrojovyDokument.ReadLine();    // tady využiju, nad čím jsem se v předchozím příkladu zapotila (bere pouze první řádek dokumentu)
            string velkyNadpis = nadpis.ToUpper();
            zapisujDoNoveho.WriteLine(velkyNadpis);
            while ((s = zdrojovyDokument.ReadLine()) != null)   // pokračuje ve vypisování obsahu původního dokumentu
            {                                                   
                string rada = s;
                char[] radaVZnacich = rada.ToCharArray();
                for (i = 0; i < radaVZnacich.Length; i++)
                {
                    bool mezera = char.IsWhiteSpace(radaVZnacich[i]);
                    if (mezera) continue;
                    else
                    {
                        bool pismeno1 = char.IsLetter(radaVZnacich[i]);
                        if (pismeno1)
                        {
                            bool pismeno2 = char.IsLetter(radaVZnacich[i + 1]);
                            if (pismeno2)
                            {
                                bool pismeno3 = char.IsLetter(radaVZnacich[i + 2]);
                                if (pismeno3)
                                {
                                    radaVZnacich[i] = char.ToUpper(radaVZnacich[i]); // Pokud má slovo alespoň 3 písmena, první se přepíše na velké
                                    int j = 3; // Dále kontroluje zbylé znaky, dokud nenarazí na mezeru
                                    while (((i + j) < radaVZnacich.Length) && (!(char.IsWhiteSpace(radaVZnacich[i + j])))) j++;
                                    i = i + j - 1; // odečítání 1 by tam nemuselo být, ale přijde mi to lepší, že si konzole vezme nižší index a ten pak zkontroluje, že jde opravdu o mezeru 

                                }
                            }
                        }
                    }
                }
                zapisujDoNoveho.Write(radaVZnacich);
                                
            }

            zdrojovyDokument.Close();
            zapisujDoNoveho.Close();        // když nezavřu soubor, tak se do souboru nic nezapíše a já uvidím jen vytvořený prázdný texťák :-)
        }
        static void Main(string[] args)
        {
            string puvodniDokument = @"..\..\..\text_puvodni.txt";
            string zformatovanyDokument = @"..\..\..\zformatovany_text.txt";
            ZformatujDokument(puvodniDokument, zformatovanyDokument);
            
        }
    }
}
