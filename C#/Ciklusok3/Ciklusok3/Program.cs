using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.rész - TÖMBÖK
            /* Mi is a tömb?
               A tömb egy fix méretű (vagy megadom, vagy megszámolja az elemeket),
               és azonos típusokból (pl egész, valós, szöveg) álló adatok halmaza.

                Mit tudunk?
                Az elemeire egy indexxel (sorszám 0-tól kezdve) hivatkozni
                A tömbre magára pedig a nevével
            */

            //Hogyan hozunk létre tömböket?
            //Az elemeket vesszővel választjuk el!!

            //1.felsorolás
            int[] egesz_szamok = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            double[] valos_szamok = {1.1, 2.2, 3.3, 4.4, 5.5};
            string[] szavak = {"alma", "körte", "szilva", "banán"};

            //2.üres tömb
            int[] ures_egeszek = new int[10];
            //Feltöltés
            ures_egeszek[0] = 2;
            ures_egeszek[1] = 4;
            
            //Feltöltés ciklussal is
            //indexek 0-9ig mennek
            for (int ind = 0; ind < 10; ind++)
            {
                ures_egeszek[ind] = ind * 2 + 1;
            }

            //Feltöltés beolvasással
            Console.Write("Adja meg a 0. elemet: ");
            ures_egeszek[0] = Convert.ToInt32(Console.ReadLine());

            //Feltöltés beolvasással és ciklussal
            for (int ind = 0; ind < 10; ind++)
            {
                Console.Write("Adja meg a {0}.elemet: ",ind);
                ures_egeszek[ind] = Convert.ToInt32(Console.ReadLine());
            }

            //Tömb elemeinek kiiratása ---------------------------------------
            //for ciklussal
            //nem tudom a tömb méretét: tombneve.Length -> a tömb mérete
            //Length -> be: tomb, ki: tomb mérete (egész szám)

            Console.WriteLine("\nA tömb elemei: ");
            for (int ind = 0; ind < ures_egeszek.Length; ind++)
            {
                Console.WriteLine(ures_egeszek[ind]);
            }

            Console.WriteLine("\nA tömb elemei egymás mellett: ");
            for (int ind = 0; ind < ures_egeszek.Length; ind++)
            {
                Console.Write("{0} ",ures_egeszek[ind]);
            }
            
            //Gyors feladat: írassuk ki a tömb elemeit ilyen formában:
            //[0] = érték, [1] = érték........

            Console.WriteLine("A tömb elemei:");
            for (int index = 0; index < ures_egeszek.Length; index++)
            {
                Console.Write("[{0}] = {1} ",index,ures_egeszek[index]);
            }

            //FOREACH ciklus: magától végigmegy egy tömbön
            foreach (int szam in ures_egeszek)
            {
                Console.WriteLine(szam);
            }


            //FELADAT: Legkisebb
            int[] tomb = {10, 40, 25, 64, 94, -41, -78, -54, -20, 1};
            Console.Write("A tömb:");
            for (int index = 0; index < 10; index += 1)
            {
                Console.Write(" {0}",tomb[index]);
            }

            //2.feladatrész
            for (int index = 0; index < tomb.Length; index += 1)
            {
                Console.Write(" [{0}]={1}",index,tomb[index]);
            }

            //PROGRAMOZÁSI TÉTEL: minimum és maximumkeresés
            int minimum = tomb[0];
            for (int index = 0; index < tomb.Length; index++)
            {
                if (tomb[index] < minimum)
                    minimum = tomb[index];
            }

            int maximum = tomb[0];
            for (int index = 0; index < tomb.Length; index++)
            {
                if (tomb[index] > maximum)
                    maximum = tomb[index];
            }

            //Min, max függvények: tömbneve.Min() vagy tömbneve.Max();
            minimum = tomb.Min();
            maximum = tomb.Max();

            //PROGRAMOZÁSI TÉTEL: Összegzés
            int osszeg2 = 0;
            foreach (int szam in tomb)
            {
                osszeg2 += szam;
            }

            //Összeg fgv. SUM: tömbneve.Sum()
            osszeg2 = tomb.Sum();
            

            //PROGRAMOZÁSI TÉTEL: Keresés
            int hol_van = -1;
            int keresett = 9999;

            for (int index = 0; index < tomb.Length; index++)
            {
                if (tomb[index] == keresett)
                {
                    hol_van = index;
                    break;
                }
            }

            //Keresés függvénye
            //Array.IndexOf(tömbneve, keresett elem);
            //Ha benne van: index
            //Ha nincs benne: -1
            hol_van = Array.IndexOf(tomb, keresett);

            Console.WriteLine("\n\nA legkisebb elem: {0}",minimum);
            Console.WriteLine("A legnagyobb elem: {0}", maximum);
            Console.WriteLine("Az elemek összege: {0}",osszeg2);
            
            if (hol_van == -1)
                Console.WriteLine("Nincs ilyen elem a tömbben");
            else
                Console.WriteLine("A(z) {0} keresett elem a {1}. indexu",keresett,hol_van);

            //Ami még elő szokott fordulni vizsgán:
            double[] szamok = {1, 2.2, 3, 4.4, 5, 6.6, 7, 8.8, 9, 10, 55, 67, 87, 98, 234, 45, 3, 2, 3, 56777, 3};
            //Hány eleme van a tömbnek?
            //1.megoldás:
            //PROGRAMOZÁSI TÉTEL: Számlálás
            int szaml = 0;
            for (int index = 0; index < szamok.Length; index++)
            {
                szaml += 1;
            }
            
            //2.megoldás: Beépített függvény
            int hossz = szamok.Length;

            //--------------------------
            //Mennyi az elemek átlaga?
            //1.megoldás: összegzés tétele plussz egy osztás
            double atlag = 0;
            double osszeg = 0;
            for (int index = 0; index < szamok.Length; index++)
            {
                osszeg += szamok[index];
            }

            atlag = osszeg / szamok.Length;

            //2.megoldás: beépített függvény
            //tombneve.Average() DOUBLE típusú átlag
            atlag = szamok.Average();

            //------------------------
            //Hányszor szerepel benne a 64?
            //1.megoldás: számlálás tétele
            int hanyszor = 0;
            for (int index = 0; index < szamok.Length; index++)
            {
                if (szamok[index] == 64)
                    hanyszor += 1;
            }

            //2.megoldás: beépített függvény
            //LUCA KERESS IDE VALAMIT!!!!!!!!!!

            //ELMÉLETI RÉSZ:
            /*Mikor használjunk tömböt?
                - ha több, azonos típusú adatot akarunk tárolni (pl: szavak, számadatok
                - tudjuk, hogy hány ilyen adat lesz
                - beolvasásnál tudjuk, hogy hányszor olvasunk be és el kell tárolni a beolvasott értékeket
                - egyéb kreatív megoldásoknál
            */


            //Egyéb kreatív megoldás
            //Példa: adott egy tömb a megírt dolgozatok jegyeivel
            int[] jegyek =
            {
                1, 2, 3, 4, 5, 1, 2, 2, 3, 1, 5, 4, 5, 5, 5, 2, 3, 1, 2, 1, 3, 4, 2, 3, 4, 2, 3, 4, 1, 3, 3, 3, 4, 5, 2,
                3, 1, 2, 3, 3, 1, 2, 3, 4, 4, 5, 5, 1, 2, 3, 4, 5, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 1, 2, 4, 4
            };

            //Feladat: számoljuk ki hogy melyik jegyből mennyi volt?
            //Ehelyett
            int egyesek_szama = 0;
            int kettesek_szama = 0;
            int harmasok_szama = 0;
            int negyesek_szama = 0;
            int otosok_szama = 0;

            //KREATÍV MEGOLDÁS
            int[] jegy_szamlalo = {0, 0, 0, 0, 0};
            //Ötlet: jegy_szamlalo[0] = egyesek száma, jegy_szamlalo[1] = kettesek száma stb.....
            //0.index 1-esek száma, 1.index - kettesek száma 2.index - hármasok száma
            for (int index = 0; index < jegyek.Length; index++)
            {
                int jegy = jegyek[index];
                int rekesz_szama = jegy - 1;

                jegy_szamlalo[rekesz_szama] += 1;
            }

            Console.WriteLine("\n\nAz egyesek száma: {0}",jegy_szamlalo[0]);
            Console.WriteLine("Az kettesek száma: {0}", jegy_szamlalo[1]);
            Console.WriteLine("Az hármasok száma: {0}", jegy_szamlalo[2]);
            Console.WriteLine("Az négyesek száma: {0}", jegy_szamlalo[3]);
            Console.WriteLine("Az ötösök száma: {0}", jegy_szamlalo[4]);
        }
    }
}
