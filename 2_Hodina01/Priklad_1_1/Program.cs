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

namespace Priklad_1_1   // FUNKCE PRO PRÁCI S JEDNOSMĚRNÝM SPOJOVÝM SEZNAMEM CELÝCH ČÍSEL  
{
    class Program
    {
        class Seznam                        /////////////////////////////////////////////////
        {                                   //      NENÍ MOJE TVORBA
            public int data;                //  J.Lánský - Programování, hodina 1.
            public Seznam next;             //
        }                                   //
        static Seznam Create(int n)         //
        {                                   //
            Seznam vys = new Seznam();      //
            vys.data = n;                   //
            vys.next = null;                //
            return vys;                     //
        }                                   //
        static Seznam ConvertArray(int[] pole)
        {                                   //
            int i;                          //
            Seznam vys, akt, tmp;           //
            if (pole.Length == 0) return null;
            vys = akt = null;               //
            for (i = 0; i < pole.Length; i++)
            {                               //
                tmp = Create(pole[i]);      //
                if (vys == null) vys = akt = tmp;
                else akt = akt.next = tmp;  //
            }                               //
            return vys;                     //
        }                                   /////////////////////////////////////////////////
        static void UlozDoTxT(Seznam s)
        // a) Napište funkci, která uloží spojový seznam do textového souboru
        { 
            FileStream novyDokument = new FileStream("..\\..\\..\\spojovySeznam_doTxt.txt", FileMode.Create);
            StreamWriter zapisDoDokumentu = new StreamWriter(novyDokument);            
            Seznam akt = s;
            while (akt != null)
            {
                zapisDoDokumentu.Write(akt.data + ", ");
                akt = akt.next;
            }
            zapisDoDokumentu.WriteLine();
            zapisDoDokumentu.Close();
        }
        static void NactiZTxt()
        // b) Napište funkci, která načte z textového souboru spojový seznam, který byl uložen pomocí funkce z příkladu a)
        {
            StreamReader cteniDokumentu = new StreamReader("..\\..\\..\\spojovySeznam_doTxt.txt");
            string s;
            while ((s = cteniDokumentu.ReadLine()) != null)
            {
                string radekZeSouboru = s;
                Console.WriteLine("Spojový seznam načtený ze souboru: {0}", radekZeSouboru);
            }
            cteniDokumentu.Close();
        }
        static void PocetVyskytuPrvku(Seznam kde, int co)
        // c) Napište funkci, která vrátí počet výskytů zadaného prvku ve spojovém seznamu.
        {
            Seznam pracovni = kde;
            int pocetVyskytu = 0;
            while(pracovni != null)
            {
                if(pracovni.data == co) pocetVyskytu++;
                pracovni = pracovni.next;
            }
            Console.WriteLine("Hledaná hodnota {0} se ve spojovém seznamu vyskytuje {1}x.", co, pocetVyskytu);
        }
        static void OdstranPosledni(Seznam odkud, int co)
        // d) Napište funkci, která ze spojového seznamu odstraní poslední z prvků, jejichž hodnota je shodná se zadanou hodnotou.
        {
            Seznam pracovni = odkud;
            int indexAktualni = -1;
            int indexPosledni = -1;
            while (pracovni != null)
            {
                indexAktualni++;
                if (pracovni.data == co) indexPosledni = indexAktualni;
                
                //Console.Write(pracovni.data + ", ");
                pracovni = pracovni.next;
            }
            Console.WriteLine("Index posledního výskytu hledaného prvku je: {0}", indexPosledni);
        }
        static void OdstranNejvyssiH(Seznam odkud)
        // e) Napište funkci, která ze spojového seznamu odstraní prvek s nejvyšší hodnotou. Pokud má více prvků stejnou hodnotu, odstraní první z nich.
        {
            Seznam pracovni = odkud;
            int nejvyssiHodnota = -1;
            while (pracovni != null)
            {
                if (pracovni.data > nejvyssiHodnota) nejvyssiHodnota = pracovni.data;
                pracovni = pracovni.next;
            }
            Console.WriteLine("Prvek spojového seznamu s nejvyšší hodnotou: {0}", nejvyssiHodnota);
        }
        static void ObratPoradi(Seznam s)
        // f) Napište funkci, která obrátí pořadí prvků ve spojovém seznamu (za použití jednoho průchodu spojovým seznamem)
        {
            Seznam pracovni = s;
            Seznam pracovni2 = s;
            int pocetPrvkuSeznamu = 0;
            while (pracovni != null)
            {
                pocetPrvkuSeznamu++;
                pracovni = pracovni.next;
            }
            int[] novy = new int[pocetPrvkuSeznamu];
            int i = pocetPrvkuSeznamu - 1;
            while(pracovni2 != null)
            {
                novy[i] = pracovni2.data;
                i--;
                pracovni2 = pracovni2.next;
            }
            Seznam noveS = ConvertArray(novy);
            Console.Write("Obrácené pořadí prvků ve spojovém seznamu: ");
            while (noveS != null)
            {
                Console.Write(noveS.data + ", ");
                noveS = noveS.next;
            }
            Console.WriteLine();
        }
        static void SeradSestupne(Seznam s)
        // g) Napište funkci, která prvky spojového seznamu uspořádá sestupně.
        {

        }
        static void ProhodPrvniPosledni(Seznam s)
        // h) Napište funkci, která ve spojovém seznamu prohodí (pomocí odkazů, nikoliv výměnou hodot) první prvek a poslední prvek.
        {
            Seznam pracovni = s;
            Seznam pracovni2 = s;
            int prvni = pracovni.data;
            int posledni = -1;
            while (pracovni != null)
            {
                if (pracovni.next == null) posledni = pracovni.data;
                pracovni = pracovni.next;
            }
            Console.Write("Prohození posledního a prvního prvku spojového seznamu: ");
            pracovni2.data = posledni;
            while (pracovni2 != null)
            {
                if (pracovni2.next == null) pracovni2.data = prvni;
                Console.Write(pracovni2.data + ", ");
                pracovni2 = pracovni2.next;
            }
            Console.WriteLine();
        }
        static void ProhodDruhyPredposledni(Seznam s)
        // i) Napište funkci, která ve spojovém seznamu prohodí druhý a předposlední prvek.
        {
            Seznam pracovni2 = s;
            Seznam pracovni = s;
            int prvni = pracovni.data;
            int druhy = pracovni.next.data;
            int predPosledni = -1;
            int posledni = -1;
            while (pracovni != null)
            {
                if (pracovni.next.next == null)
                {
                    predPosledni = pracovni.data;
                    pracovni = pracovni.next;
                    if (pracovni.next == null) posledni = pracovni.data;
                    break;
                }
                pracovni = pracovni.next;
            }
            Console.Write("Prohození předposledního a druhého prvku spojového seznamu: ");
            pracovni2.next.data = predPosledni;
            pracovni2.data = posledni;
            while (pracovni2 != null)
            {
                if (pracovni2.next.next == null)
                {
                    pracovni2.data = druhy;
                    pracovni2.next.data = prvni;
                    Console.Write(pracovni2.data + ", " + pracovni2.next.data);
                    break;
                }
                Console.Write(pracovni2.data + ", ");
                pracovni2 = pracovni2.next;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] pole = { 2, 13, 48, 97, 2, 11, 2, 61, 235, 154, 452, 875 };
            Seznam x = ConvertArray(pole);
            int hledanyP = 2;                           // <-- patří k příkladu c)


            UlozDoTxT(x);                       // a)
            NactiZTxt();                        // b)
            PocetVyskytuPrvku(x, hledanyP);     // c)
            OdstranPosledni(x, hledanyP);       // d) - dodělat, chybí vymazání prvku (zatím umí jen najít index posledního hledaného prvku)
            OdstranNejvyssiH(x);                // e) - dodělat, chybí vymazání prvku (zatím umí jen vyhledat prvek s nejvyšší hodnotou)
            ObratPoradi(x);                     // f)
            //SeradSestupne(x);                   // g) - zcela chybí
            ProhodPrvniPosledni(x);             // h) 
            ProhodDruhyPredposledni(x);         // i)


            Console.ReadLine();
        }
    }
}
