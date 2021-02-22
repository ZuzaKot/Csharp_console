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

namespace Priklad_3_1   // DPH
{
    class Program
    {
        static void TypDPH(float a)
        {
            switch (a)
            {
                case 10: Console.WriteLine("\n{0}% je druhá snížená sazba DPH.\n", a);
                    break;
                case 15: Console.WriteLine("\n{0}% je první snížená sazba DPH.\n", a);
                    break;
                case 21: Console.WriteLine("\n{0}% je základní sazba DPH.\n", a);
                    break;
                default: Console.WriteLine("\n{0}% se pro výpočet DPH nepoužívá.\n", a);
                    break;
            }
            /*
            if (a == 10) Console.WriteLine("\n{0}% je druhá snížená sazba DPH.\n", a);
            if (a == 15) Console.WriteLine("\n{0}% je první snížená sazba DPH.\n", a);
            if (a == 21) Console.WriteLine("\n{0}% je základní sazba DPH.\n", a);
            */
        }
        static float DPH()
        {
            float x;
            float y;
            float a = 100;
            Console.WriteLine("Výše DPH v %: ");
            x = Convert.ToInt32(Console.ReadLine());
            TypDPH(x);
            y = (x / a);
            return y;
        }
        static void CenaDPH(float x)
        {
            float y;
            Console.WriteLine("Cena zboží v Kč: ");
            y = Convert.ToInt32(Console.ReadLine());
            float z = (y + (y * x));
            Console.WriteLine("\nCena zboží celkem: {0} Kč", z);
        }

        static void Main(string[] args)
        {
            float a;
            a = DPH();
            CenaDPH(a);
            Console.WriteLine("");
            /*
            float b;
            b = DPH();
            CenaDPH(b);
            */
            Console.ReadLine();
        }
    }
}
