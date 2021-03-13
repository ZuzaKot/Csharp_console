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

namespace Priklad_3_6   // KÁMEN, NŮŽKY, PAPÍR
{
    class Program
    {
        enum Moznosti
        {
            kámen = 0,
            nůžky = 1,
            papír = 2
        }
        static void Pocitac(int x)
        {
            switch (x)
            {
                case 0: Console.WriteLine("PC: kámen."); break;
                case 1: Console.WriteLine("PC: nůžky."); break;
                case 2: Console.WriteLine("PC: papír."); break;
            }
        }
        static void Main(string[] args) // HURÁ! POVEDLO SE! :-) Pojďte si zahrát!
        {
            int x = -1;
            Random p = new Random();
            int pocitac = p.Next(0, 3);
            
            int vyhryPC = 0;
            int vyhryHrac = 0;

            if (x == -1) //ještě jsme nezačali hrát
            {
                Console.WriteLine("Kámen, nůžky, papír!");
                x = (int) Enum.Parse(typeof(Moznosti), Console.ReadLine(), true);
                //x = Convert.ToInt32(Console.ReadLine());
            }
            while ((vyhryPC < 2) && (vyhryHrac < 2))
            {
                if (x != pocitac)
                {   
                    if ((x > pocitac) && ((x - pocitac) != 2)) //vyhrál počítač
                    {
                        vyhryPC++;
                        if (vyhryPC < 2)
                        {
                            Pocitac(pocitac);
                            Console.WriteLine("Vyhrál počítač!\nJeště jednou!\n\nKámen, nůžky, papír!");

                            x = (int)Enum.Parse(typeof(Moznosti), Console.ReadLine(), true);
                            //x = Convert.ToInt32(Console.ReadLine());
                            pocitac = p.Next(0, 3);
                        }
                    }
                    else if ((pocitac > x) && ((pocitac - x) != 2)) //vyhrál hráč
                    {
                        vyhryHrac++;
                        if (vyhryHrac < 2)
                        {
                            Pocitac(pocitac);
                            Console.WriteLine("SKVĚLÉ!\nJeště jednou!\n\nKámen, nůžky, papír!");

                            x = (int)Enum.Parse(typeof(Moznosti), Console.ReadLine(), true);
                            //x = Convert.ToInt32(Console.ReadLine());
                            pocitac = p.Next(0, 3);
                        }
                    }
                    else if ((pocitac - x) == 2)//vyhrál počítač
                    {
                        vyhryPC++;
                        if (vyhryPC < 2)
                        {
                            Pocitac(pocitac);
                            Console.WriteLine("Vyhrál počítač!\nJeště jednou!\n\nKámen, nůžky, papír!");

                            x = (int)Enum.Parse(typeof(Moznosti), Console.ReadLine(), true);
                            //x = Convert.ToInt32(Console.ReadLine());
                            pocitac = p.Next(0, 3);
                        }
                    }
                    else if ((x - pocitac) == 2)//vyhrál hráč
                    {
                        vyhryHrac++;
                        if (vyhryHrac < 2)
                        {
                            Pocitac(pocitac);
                            Console.WriteLine("SKVĚLÉ!\nJeště jednou!\n\nKámen, nůžky, papír!");

                            x = (int)Enum.Parse(typeof(Moznosti), Console.ReadLine(), true);
                            //x = Convert.ToInt32(Console.ReadLine());
                            pocitac = p.Next(0, 3);
                        }
                    }
                }
                else if (x == pocitac)
                {
                    Pocitac(pocitac);
                    Console.WriteLine("Remíza!\n\nKámen, nůžky, papír!");

                    x = (int)Enum.Parse(typeof(Moznosti), Console.ReadLine(), true);
                    //x = Convert.ToInt32(Console.ReadLine());
                    pocitac = p.Next(0, 3);
                }
            }
            if (vyhryPC == 2)
            {
                Pocitac(pocitac);
                Console.WriteLine("\nKONEC\nVyhrál počítač!\nskóre: {0}:{1}", vyhryPC, vyhryHrac);
            }
            else if (vyhryHrac == 2)
            {
                Pocitac(pocitac);
                Console.WriteLine("\nKONEC\nGratuluji! Vyhrál jsi!\nskóre: {0}:{1}", vyhryHrac, vyhryPC);
            }

            Console.ReadLine();
        }
    }
}
