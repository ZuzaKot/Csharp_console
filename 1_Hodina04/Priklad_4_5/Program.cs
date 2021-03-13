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

namespace Priklad_4_7   // SKALÁRNÍ SOUČIN
{
    class Program
    {
        static int SkalarniSoucin(ref int[] x, ref int[] y)
        {
            int a = 0;
            int i;
            for(i = 0; i < x.Length; i++)
            {
                a = a + (x[i] * y[i]);
            }
            Console.WriteLine("Skalární součin = {0}", a);
            return a;
        }
        static void Main(string[] args)
        {
            int[] u = { 5, 6, 1, 0, 8 };
            int[] v = { 4, 2, 5, 40, 1 };

            int i;
            for (i = 0; i < u.Length; i++) Console.Write("{0}, ", u[i]);
            Console.WriteLine("");
            for (i = 0; i < v.Length; i++) Console.Write("{0}, ", v[i]);
            Console.WriteLine("");

            SkalarniSoucin(ref u, ref v);

            Console.ReadLine();
        }
    }
}
