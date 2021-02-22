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

namespace Priklad_9_1   // MATICE                               vyhotovené body a)-g) + i)                      
{                                                                
    class Program                                                
    {
        static bool JeJednotkovaMatice(long[,] J)
        {
            int i, j;
            bool je = false;
            int radky = J.GetLength(0);
            int sloupce = J.GetLength(1);
            for(i = 0; i < radky; i++)
            {
                for(j = 0; j < sloupce; j++)
                {
                    if (i == j)
                    {
                        if (J[i, j] == 1)
                        {
                            je = true;
                            continue;
                        }
                        else
                        {
                            je = false;
                            break;
                        }
                    }
                    else
                    {
                        if (J[i, j] == 0)
                        {
                            je = true;
                            continue;
                        }
                        else
                        {
                            je = false;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(je);
            return je;
        }                                   
        static bool JeHorniTrojuhelnikova(long[,] H)
        {
            int i, j;
            bool je = false;
            int radky = H.GetLength(0);
            int sloupce = H.GetLength(1);
            if (radky == sloupce)                       // je čtvercová
            {
                for (i = 0; i < radky; i++)             // řádky
                {
                    for (j = 0; j < sloupce; j++)       // sloupce
                    {
                        if (i <= j) continue;           // diagonála je i == j, horní trojúhelník je i < j      // my chceme textovat ten zbytek
                        else if (H[i, j] == 0) je = true;
                        else break;
                    }
                }
            }
            Console.WriteLine(je);
            return je;
        }
        static long[] Diagonala(long[,] D)
        {
            long[] cislaNaDiagonale = new long[D.GetLength(0)];
            int i, j;
            for(i = 0; i < D.GetLength(0); i++)
            {
                for (j = 0; j < D.GetLength(1); j++)
                {
                    long cislo = D[i, j];
                    if (i == j)
                    {
                        Console.Write("{0} ", cislo);
                        cislaNaDiagonale[i] = cislo;
                    }
                }
            }
            return cislaNaDiagonale;
        }
        static bool JeMaticeSymetricka(long[,] S)
        {
            bool symetrie = false;
            int i, j;
            for (i = 0; i < S.GetLength(0); i++)
            {
                for (j = 0; j < S.GetLength(1); j++)
                {
                    long prvni = S[i, j];
                    long druhy = S[j, i];
                    if (prvni == druhy) symetrie = true;
                    else
                    {
                        symetrie = false;
                        break;
                    }
                }
            }
            Console.WriteLine(symetrie);                
            return symetrie;
        }
        static long[,] TransponovanaMatice(long[,] T)
        {
            int M_matT = T.GetLength(0);
            int N_matT = T.GetLength(1);
            long[,] transpT = new long[N_matT, M_matT];     // zaměňujeme řádky za sloupce
            for(int i = 0; i < M_matT; i++)
            {
                for (int j = 0; j < N_matT; j++)
                {
                    transpT[i, j] = T[j, i];
                    Console.Write("{0} ", transpT[i, j]);
                }
                Console.WriteLine();
            }
            return transpT;
        }
        static void PrectiMaticiZeSouboru()
        {
            string soubor = @"..\\..\\..\\matice_doTxt.txt";
            StreamReader prectiSoubor = new StreamReader(soubor);
            string s;
            while((s = prectiSoubor.ReadLine()) != null)
            {
                string radekZeSouboru = s;
                Console.WriteLine(radekZeSouboru);
            }
            prectiSoubor.Close();
        }
        static void ZapisMaticiDoTxT(long[,] C)
        {
            FileStream novyDokument = new FileStream("..\\..\\..\\matice_doTxt.txt", FileMode.Create);
            StreamWriter zapisDoDokumentu = new StreamWriter(novyDokument);
            int M_matC = C.GetLength(0);
            int N_matC = C.GetLength(1);
            zapisDoDokumentu.WriteLine("Typ matice: [{0}, {1}]\nMatice C (A + B):\n", M_matC, N_matC);
            int i, j;
            for (i = 0; i < M_matC; i++)
            {
                for (j = 0; j < N_matC; j++) zapisDoDokumentu.Write("{0} ", C[i, j]);
                zapisDoDokumentu.WriteLine();
            }
            zapisDoDokumentu.Close();
        }
        static long[,] SoucetMatic(long[,] A, long[,] B)                       
        {
            int typM_prvniMatice = A.GetLength(0);    //typ[M, N] = [0, 1]
            int typM_druheMatice = B.GetLength(0);
            int typN_prvniMatice = A.GetLength(1);
            int typN_druheMatice = B.GetLength(1);

            long[,] novaMatice = new long[0, 0];      //typ[M, N]
            if (typM_prvniMatice != typM_druheMatice) return novaMatice; 
            if (typN_prvniMatice != typN_druheMatice) return novaMatice; 

            int i, j;
            long vysledne_cislo, cislo_prvni, cislo_druhe;

            novaMatice = new long[typM_prvniMatice, typN_prvniMatice];   // typ[M, N]

            for (i = 0; i < typM_prvniMatice; i++)                      
            {                                                                           
                for (j = 0; j < typN_prvniMatice; j++)                            
                {   
                    cislo_prvni = A[i, j];     
                    cislo_druhe = B[i, j];
                    vysledne_cislo = cislo_prvni + cislo_druhe;
                    novaMatice[i, j] = vysledne_cislo;
                    Console.Write("{0} ", vysledne_cislo);
                }                               
                Console.WriteLine(); // odděluje čísla matice po řádcích
            }
            return novaMatice;
            
        }                                                                   
        static long X()          // volá náhodné číslo z intervalu [-4, +4]
        {   
            Random nahodneCislo = new Random();
            long nove = nahodneCislo.Next(-4, 5);
            System.Threading.Thread.Sleep(1);       // !!! NUTNÉ!!! JINAK GENERUJE STEJNÁ ČÍSLA
            return nove;                            // musí se vlákno uspat aspoň na (1) tik procesoru, protože Random() počítá se systémovým časem
        }                                           
        static void Main(string[] args)
        {
            long[,] matice = { { X(), X(), X() }, { X(), X(), X() }, { X(), X(), X() } };    
            long[,] matice2 = { { X(), X(), X() }, { X(), X(), X() }, { X(), X(), X() } };

            long[,] maticeJednotkova = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            long[,] maticeTrojuhelnikova = { { 3, 7, 8 }, { 0, 1, 5 }, { 0, 0, 3 } };


            Console.WriteLine("\nPrvní matice:\n");
            Console.WriteLine("{0} {1} {2}", matice[0, 0], matice[0, 1], matice[0, 2]);
            Console.WriteLine("{0} {1} {2}", matice[1, 0], matice[1, 1], matice[1, 2]);
            Console.WriteLine("{0} {1} {2}", matice[2, 0], matice[2, 1], matice[2, 2]);

            Console.WriteLine("\nDruhá matice:\n");
            Console.WriteLine("{0} {1} {2}", matice2[0, 0], matice2[0, 1], matice2[0, 2]);
            Console.WriteLine("{0} {1} {2}", matice2[1, 0], matice2[1, 1], matice2[1, 2]);
            Console.WriteLine("{0} {1} {2}", matice2[2, 0], matice2[2, 1], matice2[2, 2]);
            
            Console.WriteLine("\nSoučet matic:\n");
            ZapisMaticiDoTxT(SoucetMatic(matice, matice2));

            Console.WriteLine("\nText ze souboru:\n");
            PrectiMaticiZeSouboru();

            Console.WriteLine("\nTransponovaná matice:\n");
            TransponovanaMatice(matice);

            Console.WriteLine("\nJe matice symetrická?:\n");
            JeMaticeSymetricka(matice);

            Console.WriteLine("\nDiagonála:\n");
            Diagonala(matice);

            Console.WriteLine("\n\nJe horní trojúhelníková matice horní trojúhelníková?:\n");
            JeHorniTrojuhelnikova(maticeTrojuhelnikova);

            Console.WriteLine("\n\nJe první matice horní trojúhelníková?:\n");
            JeHorniTrojuhelnikova(matice);

            Console.WriteLine("\nJe jednotková matice jednotková?:\n");
            JeJednotkovaMatice(maticeJednotkova);

            Console.WriteLine("\nJe první matice jednotková?:\n");
            JeJednotkovaMatice(matice);

            Console.ReadLine();

        }
    }
}
