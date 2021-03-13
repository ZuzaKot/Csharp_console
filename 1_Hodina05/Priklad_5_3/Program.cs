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

namespace Priklad_5_3   // SESTUPNÉ TŘÍDĚNÍ
{
    class Program
    {
        static void CountingSort_sestupne(int[] pole)                       ////////musím vymyslet
        {
            int i, j, max = -1;
            Console.Write("\nCounting Sort (sestupně): ");
            int[] hodnoty;

            for (i = 0; i < pole.Length; i++)
                if (pole[i] > max) max = pole[i];

            hodnoty = new int[max + 1];
            for (i = 0; i < pole.Length; i++)
                hodnoty[pole[i]]++;

            i = 0; j = 0;
            while (i < pole.Length)
            {
                if (hodnoty[j] > 0)
                {
                    hodnoty[j]--;
                    pole[i] = j;
                    i++;
                }
                else j++;
            }
            for (i = 0; i < pole.Length; i++) Console.Write("{0}, ", pole[i]);
        }
        static void CountingSort_vzestupne(int[] pole)                          /////////////////////////////////
        {                                                                       // NENÍ MOJE TVORBA
            int i, j, max = -1;                                                 //
            Console.Write("\nCounting Sort (vzestupně): ");                    // Zdroj: výukové materiály
            int[] hodnoty;                                                      // Jan Lánský, Úvod do programování 5. hodina
                                                                                // str. 17
            for (i = 0; i < pole.Length; i++)
                if (pole[i] > max) max = pole[i];

            hodnoty = new int[max + 1];
            for (i = 0; i < pole.Length; i++)
                hodnoty[pole[i]]++;

            i = 0; j = 0;
            while (i < pole.Length)
            {
                if (hodnoty[j] > 0)
                {
                    hodnoty[j]--;
                    pole[i] = j;
                    i++;
                }
                else j++;
            }
            for (i = 0; i < pole.Length; i++) Console.Write("{0}, ", pole[i]);
        }                                                                       /////////////////////////////////
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
            }
            for (i = 0; i < pole.Length; i++) Console.Write("{0}, ", pole[i]);
        }
        static void BubbleSort_vzestupne(int[] pole)                            /////////////////////////////////
        {                                                                       // NENÍ MOJE TVORBA
            int i;                                                              // Zdroj: výukové materiály
            bool vymena = true;                                                 //
            Console.Write("\nBubble Sort (vzestupně): ");                       // Jan Lánský, Úvod do programování 5. hodina
            while (vymena)                                                      // str. 14
            {                                                                   //
                vymena = false;                                                 //
                for (i = 1; i < pole.Length; i++)                               //
                    if (pole[i] < pole[i - 1])                                  //
                    {                                                           //
                        Vymena(ref pole[i], ref pole[i - 1]);                   //
                        vymena = true;                                          //
                    }                                                           //
            }                                                                   //
            for (i = 0; i < pole.Length; i++) Console.Write("{0}, ", pole[i]);  //
        }                                                                       /////////////////////////////////
        static void InsertionSort_sestupne(int[] pole)                         
        {                                                                       
            int i, j, akt;                                                      
            Console.Write("\nInsertion Sort (sestupně): ");                    
            //////////////// MUSÍM VYMYSLET
            
            for (i = 0; i < pole.Length; i++) Console.Write("{0}, ", pole[i]);
        }
        static void InsertionSort_vzestupne(int[] pole)                         /////////////////////////////////
        {                                                                       // NENÍ MOJE TVORBA
            int i, j, akt;                                                      // Zdroj: výukové materiály
            Console.Write("\nInsertion Sort (vzestupně): ");                    // Jan Lánský, Úvod do programování 5. hodina
            for (i = 1; i < pole.Length; i++)                                   // str. 11
            {                                                                   //
                akt = pole[i];                                                  //
                for (j = i; (j > 0) && pole[j - 1] > akt; j--) pole[j] = pole[j - 1];//
                pole[j] = akt;                                                  //
            }                                                                   /////////////////////////////////
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
            }                                                                   
            for (i = 0; i < pole.Length; i++) Console.Write("{0}, ", pole[i]); 
        }
        static void SelectionSort_vzestupne(int[] pole)                         /////////////////////////////////
        {                                                                       // NENÍ MOJE TVORBA
            int i, j, min;                                                      // Zdroj: výukové materiály    
            Console.Write("\nSelection Sort (vzestupně): ");                    // Jan Lánský, Úvod do programování 5. hodina
            for (i = 0; i < pole.Length; i++)                                   // str. 7 - 9
            {                                                                   //
                min = i;                                                        //
                for (j = i; j < pole.Length; j++)                               //
                {                                                               //
                    if (pole[j] < pole[min]) min = j;                           //
                }                                                               //
                Vymena(ref pole[min], ref pole[i]);                             //
            }                                                                   //
            for (i = 0;  i < pole.Length; i++) Console.Write("{0}, ", pole[i]); //
        }                                                                       //
        static void Vymena(ref int x, ref int y)                                //
        {                                                                       //
            int tmp = x;                                                        //
            x = y;                                                              //
            y = tmp;                                                            //
        }                                                                       ///////////////////////////////
        static void Main(string[] args)
        {
            int[] pole = { 2, 9, 1, 7, 6, 4, 5, 6, 7, 9};
            Console.Write("Zadané hodnoty: ");
            int i;
            for (i = 0; i < pole.Length; i++) Console.Write("{0}, ", pole[i]);
            Console.WriteLine("\n");

            SelectionSort_vzestupne(pole);
            SelectionSort_sestupne(pole);                       // splněno

            //InsertionSort_vzestupne(pole);
            //InsertionSort_sestupne(pole);                     // zatím nic

            BubbleSort_vzestupne(pole);
            BubbleSort_sestupne(pole);                          // splněno

            //CountingSort_vzestupne(pole);
            //CountingSort_sestupne(pole);                        // zatím nic

            Console.ReadLine();
        }
    }
}
