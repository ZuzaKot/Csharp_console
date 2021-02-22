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

namespace Priklad_6_2   // CÉSAROVA ŠIFRA
{
    class Program
    {
        static char[] CezarovaSifra(string x, int y)                    // b) Tak bylo by to trochu pracnější, ale
        {                                                               //      v principu vlastně klidně totéž, co při zašifrování
            char[] sifra = new char[x.Length];                          //      vzala bych celý řetězec, převedla na jejich číselnou hodnotu
            int delkaVstupu = x.Length;                                 //      a pak posouvala, dokud mi nevyjde smysluplná informace.
            int i;                                                      //      možná by nebylo od věci, pokud by to člověk potřeboval použít víckrát (dekodování),
            for(i = 0; i < delkaVstupu; i++)                            //         aby se napsala funkce, která by sama posouvala parametr a výsledky porovnávala se 
            {                                                           //         slovníkem.. to by byl složitější program.. 
                sifra[i] = x[i];
                int dotaz = Convert.ToInt32(sifra[i]);
                dotaz = dotaz + y;
                sifra[i] = (char)dotaz;
            }
            Console.WriteLine(sifra);
            return sifra;
        }
        static char[] Odsifruj(char[] x, int y)
        {
            char[] zkouska = new char[x.Length];
            int i;                                                      
            for (i = 0; i < x.Length; i++)                            
            {                                                         
                zkouska[i] = x[i];
                int dotaz = Convert.ToInt32(zkouska[i]);
                dotaz = dotaz - y;
                zkouska[i] = (char)dotaz;
            }
            Console.WriteLine(zkouska);
            return zkouska;
        }
        static void Main(string[] args)                                 // Je to funkční tam i zpět :-)
        {
            string vstupniZprava = "Čo bólo, to bólo. Terazky som majorom!";
            CezarovaSifra(vstupniZprava, 20);
            //Odsifruj(CezarovaSifra(vstupniZprava, 20), 20);

            Console.ReadLine();
        }
    }
}
