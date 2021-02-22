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

namespace Priklad_5_1   // TEST SETŘÍDĚNOSTI POLE
{
    class Program
    {
        static bool Setridenost(int[] x)
        {
            int pocetPrvku = x.Length;
            int i = 0;
            Console.Write("Pole prvků: ");
            while (i < x.Length) { Console.Write("{0}, ", x[i]); i++; }
            Console.WriteLine("\n\nMoment, probíhá test....");

            bool y = true;
            for (i = 0; i < x.Length; i++)
            {
                if (i > 0)
                    if (x[i - 1] < x[i])
                    {
                        Console.WriteLine("\n\nNení sestupně setříděná posloupnost!\nPrvek na pozici č.{0} ({1}) nesplňuje podmínku.", i + 1, x[i]);
                        y = false;
                        break;
                    }
                    else
                    {
                        Console.Write("Prvek {0} je větší než {1}", x[i - 1], x[i]); Console.WriteLine("\t ...OK");
                    }
            }
            if (y) Console.WriteLine("\n\nJe sestupně setříděná posloupnost.");
           
            Console.ReadLine();
            return y;
        }
        static void Main(string[] args)
        {
            int[] vstupniHodnoty = { 30, 23, 18, 15, 14, 13, 13, 13, 11, 8, 5, 5, 102};
            Setridenost(vstupniHodnoty);
        }
    }
}
