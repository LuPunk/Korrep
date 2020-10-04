using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Alapok2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ismétlés
                Számok:
                    int - egész; (lehet negatív is)
                    double - tört/valós; (lehet negatív is, tizedespontot kell használni pl. 3.14)
                Szöveg:
                    string - szöveg/szavak stb.
                    char - 1db karakter (1 betű, 1 szám, stb.)
                Logikai:
                    bool - vagy igaz vagy hamis
             */

            string nev = "Robi";

            //Kiiratás
            Console.WriteLine(nev);
            Console.WriteLine("Szia kedves {0}",nev);

            //Adatok beolvasása a konzolról
            //!!!! A Console.ReadLine() az MINDIG string típusú !!!!!
            
            //Példa: Kérdezzük meg a felh. melyik városban született
            string varos;

            Console.Write("Kedves felh., hol születttél?: ");
            varos = Console.ReadLine();

            //Mi van akkor ha én számokat akarok bekérni?
            //Példa: Hány éves vagy?

            int kor;
            Console.Write("Hány éves vagy?: ");
            //HIBÁS: string típusú értéket nem adhatunk egy int típusú változónak
            //kor = Console.ReadLine();

            //HELYES: konvertáljunk
            kor = Convert.ToInt32(Console.ReadLine());

            
            //Példa feladat: Kérd be a felhasználótól a 12.osztályos átlagát
            double atlag;

            Console.Write("Mennyi az átlagod?: ");
            atlag = Convert.ToDouble(Console.ReadLine());


            //Visszajelzés/Kiiratás
            Console.WriteLine("Amit eddig tudunk: {0} városában születtél, {1} éves vagy, és az átlagod {2}",varos,kor,atlag);

            /*ÚJ ELEM: Ha függvény - if/else if/else
            if (állitás) - ha igaz az állítás
                ...akkor csinálok vmit, a többit meg se nézem.
            else if (állítás2) - ha állítás1 nem igaz, de állítás2 igen
                ...akkor csinálok vmit, a többit meg se nézem.
            else
                ...ha egyik sem igaz, akkor csinálok valamit.
             */

            //Példa feladat: Tábor: 16 év alatt nem lehet menni, 16-18 év között szülői engedéllyel, 18 év felett mehetsz
            int eletkor;

            Console.Write("Hány éves vagy?: ");
            eletkor = Convert.ToInt32(Console.ReadLine());

            if (eletkor < 16)
            {
                Console.WriteLine("Te sajnos nem mehetsz a táborba");
            }
            else if (eletkor < 18)
            {
                Console.WriteLine("Te csak szülői engedéllyel jöhetsz");
            }
            else
            {
                Console.WriteLine("Te minden engedély nélkül jöhetsz.");
            }

            //IDE UGRIK*/

            //Példa feladat: Kérjünk be egy számot, és írjuk páros vagy páratlan
            int szam;

            Console.Write("Kérlek adj meg egy számot: ");
            szam = Convert.ToInt32(Console.ReadLine());

            //Párosság vizsgálat: mennyi maradékot ad 2-vel osztva?
            //Ha 2-vel osztva 0 a maradék: páros, egyébként páratlan

            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros");
            }
            else
            {
                Console.WriteLine("A szám páratlan");
            }

            //Példa feladat: Kérjünk be egy számot
            //Ha 5-el osztható: írjuk ki kacsa
            //Ha 3-al ostható: írjuk ki alma
            //Ha egyikkel sem: írjuk ki :(


            // && logikai és: mindkét állítás igaz
            // || logikai vagy: az egyik állítás igaz
            if (szam % 3 == 0 && szam % 5 == 0)
            {
                Console.WriteLine("almakacsa");
            }
            else if (szam % 3 == 0)
            {
                Console.WriteLine("alma");
            }
            else if (szam % 5 == 0)
            {
                Console.WriteLine("kacsa");
            }
            else
            {
                Console.WriteLine(":(");
            }

            //NAGYON NAGYON ROSSZ MEGOLDÁS
            /*
             Példa szam = 15...

             if (szam % 3 == 0)
                    ...
             else if (szam % 5 == 0)
                    ...
             else if (szam % 3 == 0 && szam % 5 == 0)
                    ...
             else
                    ...
             */

            //Telefonszámos példa: Hogy tárolnánk a telefonszámokat?
            /*1. +36......
             Igaz, hogy telefonszám számokból áll, DE ott a plussz jel ami egy olyan karakter ami nem szám, ezért szövegként kell tárolni
            2. 06......
             Igaz, hogy csak számok, DE 
                pl. 0630444555 ha számként tárolod -> 630444555
             ezért ezt is szövegként tároljuk :)
             */

            //Karakterekkel fun: 
            /*
             * char c = 'a';
             * megvizsgálhatjuk c > 65, mivel a 'a'-t úgy tárolja mint 97
             */
        }
    }
}
