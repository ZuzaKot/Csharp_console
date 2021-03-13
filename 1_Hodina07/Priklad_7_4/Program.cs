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

namespace Priklad_7_4   // ŘÍMSKÁ ČÍSLA
{
    class Program
    {
        static int RimskeNaDekadicke(string x)
        {
            int dekadickymi = 0;
            char[] xNaZnaky = x.ToCharArray();
            for (int i = 0; i < xNaZnaky.Length; i++)
            {
                if (x[i] == 'M')
                {
                    if (i > 0 && x[i - 1] == 'C') continue;
                    else dekadickymi += 1000;
                }
                if (x[i] == 'C')
                {
                    if (x[i - 1] == 'X') dekadickymi += 90;
                    else if (x[i + 1] == 'M') dekadickymi += 900;
                    else if (x[i + 1] == 'D') dekadickymi += 400;
                    else dekadickymi += 100;
                }
                if (x[i] == 'D')
                {
                    if (x[i - 1] == 'C') continue;
                    else dekadickymi += 500;
                }
                if (x[i] == 'L')
                {
                    if (x[i - 1] == 'X') dekadickymi += 40;
                    else dekadickymi += 50;
                }
                if (x[i] == 'X')
                {
                    if (x[i - 1] == 'I') dekadickymi += 9;
                    if (x[i + 1] == 'L') continue;
                    else dekadickymi += 10;
                }
                if (x[i] == 'V')
                {
                    if (x[i - 1] == 'I') dekadickymi += 4;
                    else dekadickymi += 5;
                }
                if (x[i] == 'I')
                {
                    if (x[xNaZnaky.Length - 1] == 'V') continue;
                    if (x[xNaZnaky.Length - 1] == 'X') continue;
                    else dekadickymi += 1;
                }

            }
            Console.WriteLine("{0}", dekadickymi);
            return dekadickymi;
        }
        static string NaString(char[] x)
        {
            string vystup = "";
            for (int i = 0; i < x.Length; i++)
            {
                vystup += x[i];
            }
            Console.WriteLine(vystup);
            return vystup;
        }               
        static string DekadickeNaRimske(int x)
        {
            string xNaString = x.ToString();
            char[] xNaChary = xNaString.ToCharArray();
            int delka = xNaChary.Length;

            string vysledny = "";
            for (int i = 0; i < delka; i++)
            {
                if (i == delka - 1)
                {
                    switch (xNaChary[i])
                    {
                        case '0':
                            break;
                        case '1':
                            vysledny += 'I';
                            break;
                        case '2':
                            vysledny = vysledny+'I'+'I';
                            break;
                        case '3':
                            vysledny = vysledny + 'I' + 'I' + 'I';
                            break;
                        case '4':
                            vysledny = vysledny + 'I' + 'V';
                            break;
                        case '5':
                            vysledny = vysledny + 'V';
                            break;
                        case '6':
                            vysledny = vysledny + 'V' + 'I';
                            break;
                        case '7':
                            vysledny = vysledny + 'V' + 'I' + 'I';
                            break;
                        case '8':
                            vysledny = vysledny + 'V' + 'I' + 'I' + 'I';
                            break;
                        case '9':
                            vysledny = vysledny + 'I' + 'X';
                            break;
                    }
                }
                if (i == delka - 2)
                {
                    switch (xNaChary[i])
                    {
                        case '0':
                            break;
                        case '1':
                            vysledny += 'X';
                            break;
                        case '2':
                            vysledny = vysledny + 'X' + 'X';
                            break;
                        case '3':
                            vysledny = vysledny + 'X' + 'X' + 'X';
                            break;
                        case '4':
                            vysledny = vysledny + 'X' + 'L';
                            break;
                        case '5':
                            vysledny = vysledny + 'L';
                            break;
                        case '6':
                            vysledny = vysledny + 'L' + 'X';
                            break;
                        case '7':
                            vysledny = vysledny + 'L' + 'X' + 'X';
                            break;
                        case '8':
                            vysledny = vysledny + 'L' + 'X' + 'X' + 'X';
                            break;
                        case '9':
                            vysledny = vysledny + 'X' + 'C';
                            break;
                    }
                }
                if (i == delka - 3)
                {
                    switch (xNaChary[i])
                    {
                        case '0':
                            break;
                        case '1':
                            vysledny += 'C';
                            break;
                        case '2':
                            vysledny = vysledny + 'C' + 'C';
                            break;
                        case '3':
                            vysledny = vysledny + 'C' + 'C' + 'C';
                            break;
                        case '4':
                            vysledny = vysledny + 'C' + 'D';
                            break;
                        case '5':
                            vysledny = vysledny + 'D';
                            break;
                        case '6':
                            vysledny = vysledny + 'D' + 'C';
                            break;
                        case '7':
                            vysledny = vysledny + 'D' + 'C' + 'C';
                            break;
                        case '8':
                            vysledny = vysledny + 'D' + 'C' + 'C' + 'C';
                            break;
                        case '9':
                            vysledny = vysledny + 'C' + 'M';
                            break;
                    }
                }
                if (i == delka - 4)
                {
                    switch (xNaChary[i])
                    {
                        case '0':
                            break;
                        case '1':
                            vysledny += 'M';
                            break;
                        case '2':
                            vysledny = vysledny + 'M' + 'M';
                            break;
                        case '3':
                            vysledny = vysledny + 'M' + 'M' + 'M';
                            break;
                        case '4':
                            vysledny = vysledny + 'M' + 'M' + 'M' + 'M';
                            break;
                        case '5':
                            vysledny = vysledny + 'M' + 'M' + 'M' + 'M' + 'M';
                            break;
                        case '6':
                            vysledny = vysledny + 'M' + 'M' + 'M' + 'M' + 'M' + 'M';
                            break;
                        case '7':
                            vysledny = vysledny + 'M' + 'M' + 'M' + 'M' + 'M' + 'M' + 'M';
                            break;
                        case '8':
                            vysledny = vysledny + 'M' + 'M' + 'M' + 'M' + 'M' + 'M' + 'M' + 'M';
                            break;
                        case '9':
                            vysledny = vysledny + 'M' + 'M' + 'M' + 'M' + 'M' + 'M' + 'M' + 'M' + 'M';
                            break;
                    }
                }
            }
            Console.WriteLine(vysledny);
            return vysledny;

        }
        static void Main(string[] args)
        {
            int rokDekadicky = 2248;
            string rokRimskymi = "MMMCDLXXVII";

            Console.WriteLine(rokRimskymi);
            RimskeNaDekadicke(rokRimskymi);             // funkční :-)
            Console.WriteLine("");
            Console.WriteLine(rokDekadicky);
            DekadickeNaRimske(rokDekadicky);            // funkční :-)

            Console.ReadLine();
        }
    }
}
