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
using System.Diagnostics;

namespace Priklad_5_4   // TESTOVÁNÍ RYCHLOSTI ALGORITMŮ            
{
    class Program
    {
        static int f = 0;
        static void BubbleSort_sestupne(int[] pole)
        {
            int i;
            bool vymena = true;
            Console.Write("\nBubble Sort (sestupně): ");
            while (vymena)
            {
                vymena = false;
                for (i = 1; i < pole.Length; i++)
                    if (pole[i] > pole[i - 1])
                    {
                        Vymena(ref pole[i], ref pole[i - 1]);
                        vymena = true;
                    }
                f++;
            }
            
            for (i = 0; i < pole.Length; i++) Console.Write("{0}, ", pole[i]);
        }
        static void SelectionSort_sestupne(int[] pole)
        {
            int i, j, max;
            Console.Write("\nSelection Sort (sestupně): ");
            for (i = pole.Length - 1; i >= 0; i--)
            {
                max = i;
                for (j = i; j >= 0; j--)
                {
                    if (pole[j] < pole[max]) max = j;
                }
                Vymena(ref pole[max], ref pole[i]);
                f++;
            }
            
            for (i = 0; i < pole.Length; i++) Console.Write("{0}, ", pole[i]);
        }
        static void Vymena(ref int x, ref int y)                                /////////////////////////
        {                                                                       //  NENÍ MOJE TVORBA
            int tmp = x;                                                        //  Zdroj: výukové materiály
            x = y;                                                              //  Jan Lánský, Úvod do programování
            y = tmp;                                                            ////////////////////////
            f++;                                                                
        }                                                                       
        static void Main(string[] args)
        {
            int[] pole = { 2, 9, 1, 7, 6, 4, 5, 6, 7, 9 };
            Console.Write("Zadané hodnoty: ");
            int i;
            for (i = 0; i < pole.Length; i++) Console.Write("{0}, ", pole[i]);
            Console.WriteLine("\n");

            long time1, time1_2, time2, time2_2;
            Stopwatch cas = new Stopwatch();

            cas.Start();
            SelectionSort_sestupne(pole);
            cas.Stop();
            time1 = cas.ElapsedMilliseconds;
            time1_2 = cas.ElapsedTicks;
            Console.WriteLine("\nSelection Sort trval: {0}ms.", time1);
            Console.WriteLine("Selection Sort trval: {0} tiků procesoru.", time1_2);
            Console.WriteLine("Počet provedených operací: {0}", f);

            f = 0;
            int[] pole2 = { 2, 9, 1, 7, 6, 4, 5, 6, 7, 9 };
            cas.Reset();
            cas.Start();
            BubbleSort_sestupne(pole2);
            cas.Stop();
            time2 = cas.ElapsedMilliseconds;
            time2_2 = cas.ElapsedTicks;
            Console.WriteLine("\nBubble Sort trval: {0}ms.", time2);
            Console.WriteLine("Bubble Sort trval: {0} tiků procesoru.", time2_2);
            Console.WriteLine("Počet provedených operací: {0}", f);

            Console.ReadLine();
        }
    }
}
