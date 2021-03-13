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

namespace Priklad_4_3   // ZAOKROUHLENÍ POLE
{
    class Program
    {
        static void Zaokrouhleni(double[] pole)                                               
        {                                                                                  
            int i;                                                                       
            for (i = 0; i < pole.Length; i++)
            {
                pole[i] = Math.Round(pole[i]);                                              
                Console.Write("{0},", pole[i]);
            }                                                                                               
        }                                                                                   
        static void Main(string[] args)
        {
            Console.Write("Zaokrouhlení reálných čísel v poli:\n");
            
            double[] vstup = { 5.9, -8.6984, 8.745916, -2.124, 845.1455};
            Console.WriteLine(" {0}\n {1}\n {2}\n {3}\n {4}", vstup[0], vstup[1], vstup[2], vstup[3], vstup[4]);
            Console.Write("\na = {");
            Zaokrouhleni(vstup);
            Console.WriteLine("}");
            Console.ReadLine();
        }
    }
}
