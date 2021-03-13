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

namespace Priklad_4_2   // ABSOLUTNÍ HODNOTA POLE
{
    class Program
    {
        static void AbsolutniPrvky(int[] prvky)                                               
        {                                                                               
            int i;                                                                      
            for (i = 0; i < prvky.Length; i++)
            {
                if (prvky[i] < 0) prvky[i] = Math.Abs(prvky[i]);
                Console.Write("{0},", prvky[i]);
            }
        }                                      
        static void Main(string[] args)
        {
            int[] vstup = new int[5];
            Console.Write("Absolutní hodnota pole\n\nZadejte 5 čísel, mohou být i záporná.\n\nprvek 1:");
            vstup[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("prvek 2:");
            vstup[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("prvek 3:");
            vstup[2] = Convert.ToInt32(Console.ReadLine());
            Console.Write("prvek 4:");
            vstup[3] = Convert.ToInt32(Console.ReadLine());
            Console.Write("prvek 5:");
            vstup[4] = Convert.ToInt32(Console.ReadLine());
        
            Console.Write("\na = {");
            AbsolutniPrvky(vstup);
            Console.WriteLine("}");
            Console.ReadLine();
        }
    }
}
