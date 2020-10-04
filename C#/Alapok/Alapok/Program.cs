using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Változók - Tárolók, értékeket tárolnak
              Típusok (alapok):
                - int (integer) - egész számok
                - double (u.a) - tört számok (tizedes ponttal elválasztva)
                - string - szöveges adatok ("" közé kell tenni)
                - char (character) - egy karakter ('' közé kell tenni)
                - bool (boolean) - értéke igaz vagy hamis (true/false)
              
              Hogyan használjunk változót:
                - létrehozás (deklarálás) -> <típus> <v.név>
                    pl: int szam; vagy string szoveg; char betu;
                - változónevekről
                    - tartalmazhat: betűket (kis/nagybetű különböző), számokat, alulvonást
                    - mit szabad?
                        - v.név betűvel vagy alulvonással kell kezdődnie pl. int alma/string Korte/char _cica
                        - nem szabad space-t használni: osszetettSzo, osszetetett_szo
                        - kis/nagybetű különböző pl: alma != Alma
                        - v.név nem kulcsszó pl. int int nem lehet, string int sem, char console
                - értékadás (lehet a deklarációval együtt):
                    pl. int szam = 5; string alma = "korte"; szam = 6; alma = "nem alma"
                    - fontos hogy típust csak a létrehozásnál adjuk meg 
                        pl: ha már van int szam; akkor csak szam = valami-t tudsz használni
                    - számoknál műveletek érvényesek:
                        pl: szam = 1 + 5; szam = 3 * 4; szam = szam + 1; szam += 1 (szam értékét megnöveli 1-el);

              Műveletek: 
                - operátorokkal tudjuk jelezni:
                    - +: összeadás
                    - -: kivonás
                    - *: szorzás
                    - /: osztás
                    - %: maradékos osztás (a % b megmondja, hogy a-t b-vel osztva mennyi maradékot ad)
                    - =: CSAK értékadás
                    - ==: egyenlőség vizsgálat (pl szam == 2 ?)

              Megjegyzések:
                // - egysoron megjegyzés
                per csillag - csillag (*) per (/) - többsoros megjegyzés

              Speciális karakterek:
                - escape karakter: \", \', \\
                - pár speciális: \n, \t
             */

            //Első programunk: Hello világ--------------------------------------------
            Console.WriteLine("Hello világ!");

            //Kiiratással kapcsolatos dolgok
            //1. Write/WriteLine-------------------------------------------------------
            Console.Write("Hello világ! ");
            Console.Write("Most a write-ot használom");

            Console.WriteLine("\n");

            Console.WriteLine("Hello világ! ");
            Console.WriteLine("Most a writeline-t használom\n");

            //2.Változók és a kiiratás------------------------------------------------------
            string nev = "Robi";

            //1.módszer: összefűzés (+)
            Console.WriteLine("Szia " + nev + "!");

            nev = "Luca";           //Itt megváltoztattuk a változó értékét
            Console.WriteLine("Szia " + nev + "!");

            //2.módszer: behelyettesítés ({sorszám})
            Console.WriteLine("Szia {0}!",nev);

            //Néhány vátozó értékkel
            string varos = "Szolnok";
            int kor = 21;
            string nem = "lány";

            //Írjuk ki a változó értékét
            Console.WriteLine(varos);
            Console.WriteLine(kor);

            //írjuk ki azt a szöveget: "Szia <név>! Te egy <kor> éves <nem> vagy."
            //1.módszer: összefűzés
            Console.WriteLine("Szia " + nev + "! Te egy " + kor + " éves " + nem + " vagy.");
            
            //2.módszer: behelyettesítés
            Console.WriteLine("Szia {0}! Te egy {1} éves {2} vagy.",nev,kor,nem);
            Console.WriteLine("Szia {0}! Te egy {1} éves {2} vagy. Szerintem {3} nagyon szép hely",nev,kor,nem,varos);

            //3.Beolvasás konzolról: adatot kérünk a felhasználótól----------------------------
            //Példa feladat: Kérd be a felh. nevét, és köszönj neki!

            //Tudjuk, hogy el kell tárolni a nevet:
            string nev2;  //Azért nev2 mert fent már van nev

            //Mondjuk meg a felh.-nak mit szeretnénk
            Console.Write("Kérlek, add meg a neved: ");

            //Adjuk értéknek a nev2-nek amit a felh. beírt
            nev2 = Console.ReadLine();

            //Köszönjünk a felh-nak
            Console.WriteLine("Szia {0}!", nev2);
        }
    }
}
