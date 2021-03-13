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

namespace Priklad_5_2   // PŘÍPRAVA NA TŘÍDĚNÍ
{
    class Program
    {
        static int x = 5, y = 4, z = 3;                                 
        static int i = 0, j = 0, k = 0;
        static int Prirazeni(ref int a, ref int b)
        {
            if (a != b)
            {
                if ((a == x) || (b == x)) i++;
                if ((a == y) || (b == y)) j++;
                if ((a == z) || (b == z)) k++;
            }
            else if (a == b)
            {
                if ((a == x) && (b == x)) i+=2;
                if ((a == y) && (b == y)) j+=2;
                if ((a == z) && (b == z)) k+=2;
            }
            return i;
        }
        static int Porovnani(ref int a, ref int b)
        {
            int s = Math.Min(a, b);
            int t = Math.Max(a, b);
            if(a != b)
            {
                if ((a == x) || (b == x)) i++;
                if ((a == y) || (b == y)) j++;
                if ((a == z) || (b == z)) k++;
            }
            else if (a == b)
            {
                if ((a == x) && (b == x)) i += 2;
                if ((a == y) && (b == y)) j += 2;
                if ((a == z) && (b == z)) k += 2;
            }
            return i;
        }
        static void Main(string[] args)
        {
            Prirazeni(ref x, ref y);
            Prirazeni(ref y, ref z);
            Prirazeni(ref x, ref z);
            Prirazeni(ref z, ref z);
            Console.WriteLine("\nVe funkci Přiřazení bylo použito:\n x: {0}-krát\n y: {1}-krát\n z: {2}-krát", i, j, k);

            i = 0; j = 0; k = 0;
            Porovnani(ref x, ref y);
            Porovnani(ref y, ref y);
            Porovnani(ref y, ref y);
            Console.WriteLine("\nVe funkci Porovnání bylo použito:\n x: {0}-krát\n y: {1}-krát\n z: {2}-krát", i, j, k);


            Console.ReadLine();
        }
    }
}
