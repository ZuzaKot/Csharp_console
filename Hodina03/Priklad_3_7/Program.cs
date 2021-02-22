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

namespace Priklad_3_7   // POČET DNÍ PO DATU        (+ Priklad_3_8      // DEN V TÝDNU)
{
    class Program
    {
        struct Datum                                ///////////////////////////
        {                                           //   NENÍ MOJE TVORBA    
            public int den;                         // zdroj: výuková skripta
            public int mesic;                       // Jan Lánský, Úvod do programování
            public int rok;                         // str. 29
        }                                           ///////////////////////////
        public static bool PrestupnyRok(int rok)    ///////////////////////////
        {                                           //   NENÍ MOJE TVORBA    
            if (rok % 4 != 0) return false;         // zdroj: výuková skripta
            if (rok % 100 != 0) return true;        // Jan Lánský, Úvod do programování
            if (rok % 400 != 0) return false;       // str. 31
            return true;                            ///////////////////////////
        }
        static int DatumNaCislo(Datum d)            ///////////////////////////
        {                                           //   NENÍ MOJE TVORBA    
            int i, vys = 0;                         // zdroj: výuková skripta
            vys = vys + d.den;                      // Jan Lánský, Úvod do programování
                                                    // str. 32-33
            for (i = 1900; i < d.rok; i++)          //
            {                                       //
                vys = vys + 365;                    //
                if (PrestupnyRok(i)) vys++;         //
            }                                       //
            for(i = 1; i < d.mesic; i++)            //
            {                                       //
                switch (i)                          //
                {                                   //
                    case 4:                         //
                    case 6:                         //
                    case 9:                         //
                    case 11:                        //
                        vys = vys + 30;             //
                        break;                      //
                    case 2:                         //
                        vys = vys + 28;             //
                        if (PrestupnyRok(d.rok)) vys++;//
                        break;                      //
                    default:                        //
                        vys = vys + 31;             //
                        break;                      //
                }                                   //
            }                                       //
            return vys;                             ///////////////////////////
        }
        static int CisloNaDatum(int x)            
        {                                           
            int i;
            int rok2 = 1900;
            int z = x;
            for (i = 0; (x / 365) >= 1; i++)          // počítá celé uplynulé roky
            {
                x = x - 365;
                if (PrestupnyRok(i)) x--;
                rok2++;
            }
            int mesic2 = 1;
            int mesic3 = mesic2;
            if ((x / 365) < 1)
            {
                z = x % 365;
                for (i = 1; z >= 31; i++)           // FUNKČNÍ... (Příklad_3_7: Počet dní po dnu)
                {                                   // zatím ALE SELHÁVÁ u některých datumů..... :-/
                    switch (i)
                    {
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            mesic2 = i;
                            z = z - 30;
                            break;
                        case 2:
                            mesic2 = i;
                            z = z - 28;
                            if (PrestupnyRok(rok2)) x--;
                            break;
                        default:
                            mesic2 = i;
                            z = z - 31;
                            break;
                    }
                }
                
            }
            mesic3 = mesic2 + 1;
            //if (!(z == 1) || (z == 2)) { /*z = z - 1;*/ }
            if ((z == 31) || (z == 0)) { z = 31; mesic3 = mesic3 - 1;  }
            if (z < 0) { z = z * (-1); mesic3 = mesic3 - 1; }

            Console.WriteLine("\nNový datum\nden: {0}", z);
            Console.WriteLine("měsíc: {0}", mesic3);
            return rok2;                          

        }
        static void NazevDne(int x)                                 // zdá se zcela funkční (Příklad_3_8: Den v týdnu)
        {
            int i;
            while (x % 7 > 7)
            {
                for (i = 1; i < x; i++)
                {
                    x = x / 7;
                }
            }
            if ((x % 7) == 1) Console.WriteLine("pondělí");
            else if ((x % 7) == 2) Console.WriteLine("úterý");
            else if ((x % 7) == 3) Console.WriteLine("středa");
            else if ((x % 7) == 4) Console.WriteLine("čtvrtek");
            else if ((x % 7) == 5) Console.WriteLine("pátek");
            else if ((x % 7) == 6) Console.WriteLine("sobota");
            else if ((x % 7) == 0) Console.WriteLine("neděle");
        }
        static void Main(string[] args)
        {
            Datum zadany;
            int novy;
            int dni;
            Console.Write("Den: ");
            zadany.den = Convert.ToInt32(Console.ReadLine());
            Console.Write("Měsíc: ");
            zadany.mesic = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rok: ");
            zadany.rok = Convert.ToInt32(Console.ReadLine());
            Console.Write("zadejte počet dní, které chcete přičíst: ");
            dni = Convert.ToInt32(Console.ReadLine());

            int x = DatumNaCislo(zadany);
            //Console.WriteLine("Zadaný datum vyčíslený ve dnech uplynutých od 1.1.1900:\n{0}", x);
            novy = (x + dni - 1);
            //Console.WriteLine("Výsledný datum vyčíslený ve dnech uplynutých od 1.1.1900:\n{0}", novy);
            int novy2 = novy;

            int y = CisloNaDatum(novy);
            Console.WriteLine("rok: {0}", y);
            NazevDne(novy2);

            Console.ReadLine();
        }
    }
}
