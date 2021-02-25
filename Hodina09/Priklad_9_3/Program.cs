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
using System.IO;

namespace Priklad_9_3   // ASCII Art
// Pomocí znaků hvězdičky "*" a mezery " " vytvořte následující obrazce...

// ENG
// By using symbol of star "*" and white space " " create following pictures...

{
    class Program
    {
        static void ObrazecH(int x)
        {
            int i, j;
            char[,] ctverec = new char[x, x];

            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    if ((i == 0) || (i == x - 1) || (j == 0) || (j == x - 1) || (i % 2 == 0) || (j % 2 == 0)) ctverec[i, j] = '*';
                    else ctverec[i, j] = ' ';
                    Console.Write("{0}", ctverec[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ObrazecG(int x)
        {
            int i, j;
            char[,] ctverec = new char[x, x];

            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    if ((i == 0) || (i == x - 1) || (j == 0) || (j == x - 1) || (i % 2 == 0)) ctverec[i, j] = '*';
                    else ctverec[i, j] = ' ';
                    Console.Write("{0}", ctverec[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ObrazecF(int x)
        {
            int i, j;
            char[,] ctverec = new char[x, x];

            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    if ((i == 0) || (i == x - 1) || (j == 0) || (j == x - 1) || (j == x / 2) || (i == x / 2) || (j == x - 1 - i) || (i == x - 1 - j) || (j == x - 1) || (i == x - 1) || (j == i)) ctverec[i, j] = '*';
                    else ctverec[i, j] = ' ';
                    Console.Write("{0}", ctverec[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ObrazecE(int x)
        {
            int i, j;
            char[,] ctverec = new char[x, x];

            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    if ((i == 0) || (i == x - 1) || (j == 0) || (j == x - 1) || (j == x / 2) || (i == x / 2)) ctverec[i, j] = '*';
                    else ctverec[i, j] = ' ';
                    Console.Write("{0}", ctverec[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ObrazecD(int x)
        {
            int i, j;
            char[,] ctverec = new char[x, x];

            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    if ((i == 0) || (i == x - 1) || (j == 0) || (j == x - 1) || (j == i) || (j == x - 1 - i) || (i == x - 1 - j)) ctverec[i, j] = '*';
                    else ctverec[i, j] = ' ';
                    Console.Write("{0}", ctverec[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ObrazecC(int x)
        {
            int i, j;
            char[,] ctverec = new char[x, x];

            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    if ((i == 0) || (i == x - 1) || (j == 0) || (j == x - 1) || (j == i)) ctverec[i, j] = '*';
                    else ctverec[i, j] = ' ';
                    Console.Write("{0}", ctverec[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ObrazecB(int x)
        {
            int i, j;
            char[,] ctverec = new char[x, x];

            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    if ((i == 0) || (i == x - 1) || (j == 0) || (j == x - 1) || (j == x / 2)) ctverec[i, j] = '*';
                    else ctverec[i, j] = ' ';
                    Console.Write("{0}", ctverec[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void ObrazecA(int x)
        {
            int i, j;
            char[,] ctverec = new char[x, x];

            for (i = 0; i < x; i++)
            {
                for (j = 0; j < x; j++)
                {
                    if ((i == 0) || (i == x - 1) || (j == 0) || (j == x - 1)) ctverec[i, j] = '*';
                    else ctverec[i, j] = ' ';
                    Console.Write("{0}", ctverec[i, j]);
                }
                Console.WriteLine();
            }
        }
        static char[,] ObrazecI(int x)                                      ////////////////////////////////
        {                                                                   //  NENÍ MOJE TVORBA
            int i, j, min1, min2;
            char[,] obr = new char[x, x];

            for(i = 0; i < obr.GetLength(0); i++)
            {
                for (j = 0; j < obr.GetLength(1); j++)
                {
                    min1 = Math.Min(i, j);
                    min2 = Math.Min(x - 1 - i, x - 1 - j);
                    if (Math.Min(min1, min2) % 2 == 0) obr[i, j] = '*';
                    else obr[i, j] = ' ';
                    Console.Write("{0}", obr[i, j]);
                }
                Console.WriteLine();
            }

            return obr;
        }                                                                   ////////////////////////////////
        static void Main(string[] args)
        {
            int velikostObrazce = 25;

            Console.WriteLine("Obrazec I");
            ObrazecI(velikostObrazce);

            Console.WriteLine("\nObrazec A");
            ObrazecA(velikostObrazce);

            Console.WriteLine("\nObrazec B");
            ObrazecB(velikostObrazce);

            Console.WriteLine("\nObrazec C");
            ObrazecC(velikostObrazce);

            Console.WriteLine("\nObrazec D");
            ObrazecD(velikostObrazce);

            Console.WriteLine("\nObrazec E");
            ObrazecE(velikostObrazce);

            Console.WriteLine("\nObrazec F");
            ObrazecF(velikostObrazce);

            Console.WriteLine("\nObrazec G");
            ObrazecG(velikostObrazce);

            Console.WriteLine("\nObrazec H");
            ObrazecH(velikostObrazce);

            Console.ReadLine();
        }
    }
}
