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

namespace Priklad_6_3   // NAŠE VLASTNÍ ŘETĚZCE
{
    class Program
    {
        static char[] VymazaniPodretezce(char[] odkud, int zacMazaneho, int delkaMazaneho)
        {
            char[] korektura = new char[odkud.Length - delkaMazaneho];
            
            int i;
            int j = 0;

            char[] vymaz = new char[delkaMazaneho];
            for (i = zacMazaneho; i < (zacMazaneho + delkaMazaneho); i++)
            {
                vymaz[j] = odkud[i];
                j++;
            }
            //Console.Write("Mažu slovo ");
            //Console.WriteLine(vymaz);

            j = 0;
            char[] zbyvaPred = new char[zacMazaneho];
            for (i = 0; i < zacMazaneho; i++)
            {
                zbyvaPred[j] = odkud[i];
                j++;
            }
            //Console.Write("Zbývá před smazaným slovem ");
            //Console.WriteLine(zbyvaPred);

            j = 0;
            int indexZaOdmazanym = zacMazaneho + delkaMazaneho;
            char[] zbyvaZa = new char[odkud.Length - indexZaOdmazanym];
            for (i = indexZaOdmazanym; i < odkud.Length; i++)
            {
                zbyvaZa[j] = odkud[i];
                j++;
            }
            //Console.Write("Zbývá za smazaným slovem ");
            //Console.WriteLine(zbyvaZa);

            j = 0;
            for (i = 0; i < (odkud.Length - delkaMazaneho); i++)
            {
                if (i < zbyvaPred.Length) korektura[i] = zbyvaPred[i];
                else if (i == zbyvaPred.Length) continue;
                else { korektura[i] = zbyvaZa[j]; j++; }
            }
            Console.WriteLine(korektura);
            return korektura;
        }
        static int LexikografickeSrovnani(char[] prvni, char[] druhe)
        {
            int maximalniDelka = Math.Min(prvni.Length, druhe.Length);
            int i;
            int porovnej = 0;
            for (i = 0; i < maximalniDelka; i++)
            {
                int prvniNaCislo = Convert.ToInt32(prvni[i]);
                int druheNaCislo = Convert.ToInt32(druhe[i]);

                if (prvniNaCislo < druheNaCislo)
                {
                    porovnej = -1;
                    Console.Write("Prvni písmeno, které je rozdílné, je {0}, jeho hodnota v ASCII je {1}, a {2}, v ASCII pod číslem {3}.", prvni[i], prvniNaCislo, druhe[i], druheNaCislo);
                    break;
                }
                else if (prvniNaCislo == druheNaCislo) porovnej = 0;
                else if (prvniNaCislo > druheNaCislo)
                {
                    porovnej = 1;
                    Console.Write("Prvni písmeno, které je rozdílné, je {0}, jeho hodnota v ASCII je {1}, a {2}, v ASCII pod číslem {3}.", prvni[i], prvniNaCislo, druhe[i], druheNaCislo);
                    break;
                }
            }
            
            Console.WriteLine(porovnej);
            return porovnej;
        }
        static char[] Podretezec(char[] x, int od, int kolik)
        {
            char[] vysledek = new char[kolik];
            int i;
            int j = 0;
            
            for (i = od; i < (od + kolik); i++)
            {
                vysledek[j] = x[i];
                j++;
            }
            
            Console.WriteLine(vysledek);
            return vysledek;
        }
        static void Main(string[] args)
        {
            char[] vstupniRetezec = "Včera neděle byla.".ToCharArray();
            char[] vstupniRetezec2 = "Za týden bude zas.".ToCharArray();

            char[] podretezec = Podretezec(vstupniRetezec, 0, 5);          // FUNKČNÍ :-) bod c) Substring
            char[] podretezec2 = Podretezec(vstupniRetezec2, 3, 5);

            int srovnavacPodretezcu = LexikografickeSrovnani(podretezec, podretezec2);  // FUNKČNÍ :-) bod a) Compare

            char[] opraveny = VymazaniPodretezce(vstupniRetezec, 6, 6);         // FUNKČNÍ :-) e) Remove



            Console.ReadLine();
        }
    }
}
