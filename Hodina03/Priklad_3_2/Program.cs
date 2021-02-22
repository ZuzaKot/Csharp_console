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

namespace Priklad_3_2   // BMI
{
    class Program
    {
        static void BMIslovne(double x)
        {
            if ((x >= 0) && (x < 16.5)) Console.WriteLine("těžká podvýživa ");
            if ((x >= 16.5) && (x < 18.5)) Console.WriteLine("podváha ");
            if ((x >= 18.5) && (x < 25)) Console.WriteLine("optimální váha ");
            if ((x >= 25) && (x < 30)) Console.WriteLine("nadváha ");
            if ((x >= 30) && (x < 35)) Console.WriteLine("obezita prvního stupně ");
            if ((x >= 35) && (x < 40)) Console.WriteLine("obezita druhého stupně ");
            if (x >= 40) Console.WriteLine("obezita třetího stupně ");
        }
        static double Vyska()
        {
            double y;
            double z;
            Console.WriteLine("Výška v metrech: ");
            y = Convert.ToDouble(Console.ReadLine());
            z = (y * y);
            return z;
        }
        static double BMI()
        {
            double a;
            double b;
            Console.WriteLine("Váha v kilogramech: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = (a / Vyska());
            
            Console.WriteLine("\nVaše BMI je: {0} ", b);
            BMIslovne(b);
            return b;
        }
        static void Main(string[] args)
        {
            BMI();
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
