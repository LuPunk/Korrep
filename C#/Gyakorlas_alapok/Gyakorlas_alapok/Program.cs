using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_alapok
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adatszerkezetek
            /*Amit eddig tudtunk azok változók (és azok típusai pl. int, string, char, double)
              Ha több azonos típusú adatot tároltunk: tömb (pl. int[], char[], string[])
              Tömböt mikor használunk? 
                - Tudjuk, hogy adat van - de nem mindig tudjuk? 
            
              Megoldás: ha lenne egy dinamikusan változó
              Jó hír van ilyen: lista

              Lista vs tömb
                - Ha tudjuk mennyi adat van -> tömb
                - Ha nem tudjuk (pl fájlból beolvasás) -> lista
            */
            
            //Listák használata
            //Üres listák
            //Egész számok listája
            List<int> szamok = new List<int> { };
            //Szavak listája
            List<string> szavak = new List<string> { };
            //Valós számok listája
            List<double> valos = new List<double> { };

            //Van benne kezdeti elem
            List<int> szamok_kezd = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Hogyan töltjük fel?
            int adat = 5;
            //listaneve.Add(vmilyen adat) a lista végéhez fűzi
            szamok.Add(adat);
            szamok.Add(67);

            szavak.Add("alma");
            szavak.Add("körte");

            valos.Add(3.4);
            valos.Add(2.3);

            //Elemek eltávolítása
            //listaneve.Remove(vmi adat) az az első előfordulását kiszedi
            szamok.Remove(5);
            //listaneve.RemoveAll(lambda) kiszedi az összeset ami a feltételnek megfelel
            //lambda: szam => szam == 1        szam legyen azon számok halmaza melyek egyenlőek 1-gyel
            //szam => szam % 2 != 1            szam legyen azon számok halmaza melyek páratlanok
            szamok.RemoveAll(x => x == 1);

            //Mennyi elemet tartalmaz a lista?
            int elemek_szama = szamok.Count;

            //Rendezés
            //listaneve.Sort(); 
            //számoknál növekvő sorrend
            //szavaknál abc sorrendbe rakja az elemeket
            szamok.Sort();

            //Keresés a listában:
            szamok.Find(x => x == 1);
            //Számokra Min, Max és Avg
            int max = szamok.Max();
            int min = szamok.Min();
            double atlag = szamok.Average();


            //Hivatkozás az elemekre: ua. mint amit eddig tanultunk
            int szam3 = szamok[2];
            szamok[1] += 1;

            //A lista bejárása: foreach ciklus
            foreach (int szam2 in szamok)
            {
                Console.WriteLine(szam2);
            }
            

            //Példa feladat: Kérjünk be a felhasználótól addig egész számokat amíg -1-et nem ír be
            List<int> bemenet = new List<int> { };
            int szam_be = 7;

            do
            {
                Console.Write("Kedves felhasználó, adj meg egy számot: ");
                szam_be = Convert.ToInt32(Console.ReadLine());
                bemenet.Add(szam_be);
            } while (szam_be != -1);

            //Lista elemeinek kiírása:
            Console.WriteLine("\nA lista elemei: \n");
            foreach(int elem in bemenet)
            {
                Console.Write("{0} ",elem);
            }

            //-1 végjel: egy olyan érték ami jelzi hogy vége a bemenetnek
            //Hogy küszöböljük ki hogy a végjel benne legyen?
            //1.megoldás: do.. while helyett while-t használunk de a változónak adunk egy kezdeti értéket
            while (szam_be != -1)
            {
                Console.Write("Kedves felhasználó, adj meg egy számot: ");
                szam_be = Convert.ToInt32(Console.ReadLine());
                bemenet.Add(szam_be);
            }

            //2.megoldás: ha do... while-t használtunk, akkor a ciklus után vegyük ki a végjelet
            do
            {
                Console.Write("Kedves felhasználó, adj meg egy számot: ");
                szam_be = Convert.ToInt32(Console.ReadLine());
                bemenet.Add(szam_be);
            } while (szam_be != -1);
            bemenet.Remove(-1);

            Console.WriteLine("\nA lista elemei: ");
            foreach (int elem in bemenet)
            {
                Console.Write("{0} ", elem);
            }

            Console.WriteLine("\n");
            //Feldat 1: Jelenítsd meg a konzolon, hogy hány számot kértünk be a felhasználótól
            //1.megoldás (beépített fgv: .Count):
            Console.WriteLine("Lista elemeinek száma: {0}",bemenet.Count);
            //2.megoldás számlálás tétetle:
            int szamlalo = 0;
            foreach (int elem in bemenet)
            {
                szamlalo += 1;
            }
            Console.WriteLine("Lista elemeinek száma: {0}", szamlalo);

            //Számold meg, hogy hány darab páros számot adott meg a felh. és írd és ki ezeket!
            //1.megoldás
            int paros_db = 0;
            Console.WriteLine("Páros számok: ");
            foreach (int elem in bemenet)
            {
                if (elem % 2 == 0)
                {
                    paros_db += 1;
                    Console.Write("{0} ", elem);
                }
            }
            Console.WriteLine("\nÖsszesen {0}db páros szám volt", paros_db);
            //1.5 megoldás: a páros számok darabszámának megszámolására: .Count(lambda)
            Console.WriteLine("Összesen {0}db páros szám volt", bemenet.Count(x => x % 2 == 0));

            //Írja ki a felh. által megadott számok közül a legkisebbet, a legnagyobbat!
            //1.megoldás: min/max progtétel
            int min_szam = bemenet[0];
            int max_szam = bemenet[0];

            foreach (int szam in bemenet)
            {
                //Megvizsgáljuk, hogy kisebb-e mint amit mi a legkisebbnek hiszünk
                if (szam < min_szam)
                    min_szam = szam;

                //Megvizsgáljuk, hogy nagyobb-e mint amit mi a legnagyobbnak hiszünk
                if (szam > max_szam)
                    max_szam = szam;
            }
            Console.WriteLine("\nA legkisebb szám: {0}, a legnagyobb {1}",min_szam,max_szam);
            //2.megoldás: beépített függvénnyel
            Console.WriteLine("A legkisebb szám: {0}, a legnagyobb {1}", bemenet.Min(), bemenet.Max());

            //Írja ki a felh. által megadott számokat növekvő sorrendben
            //lista.Sort() -> ÁTRENDEZI A LISTÁT! NEM AZ EREDETI (MEGADÁS SORRENDJÉBEN) LESZNEK A SZÁMOK
            //1.eset: nem baj, ha átrendeződik a lista
            bemenet.Sort();
            Console.WriteLine("\nA rendezett lista: "); 
            foreach (int szam in bemenet)
            {
                Console.Write("{0} ",szam);
            }

            //2.eset: ha baj, hogy átrendezzük
            //Készítettünk egy másolatot
            List<int> bemenet_masolat = new List<int> { };
            foreach (int szam in bemenet)
            {
                bemenet_masolat.Add(szam);
            }

            bemenet_masolat.Sort();
            Console.WriteLine("\nA rendezett lista: ");
            foreach (int szam in bemenet_masolat)
            {
                Console.Write("{0} ", szam);
            }

            //Megadta-e a felh. a 345 számot? Írja ki, hogy igen vagy nem!
            //1.megoldás: keresés progtétel
            bool talalat = false;
            foreach (int szam in bemenet)
            {
                if (szam == 345)
                {
                    talalat = true;
                    break;
                }
            }
            if (talalat == false)
                Console.WriteLine("\nNem volt benne a 345");
            else
                Console.WriteLine("\nBenne volt a 345");

            //2.megoldás: fgv-ek
            //listaneve.Contains(adat) -> igazat ad vissza ha benne van, hamisat ha nincs benne
            talalat = bemenet.Contains(345);
            if (talalat == false)
                Console.WriteLine("Nem volt benne a 345");
            else
                Console.WriteLine("Benne volt a 345");
        }
    }
}
