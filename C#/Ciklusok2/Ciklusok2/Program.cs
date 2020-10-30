// Entry point name must be "Solution"
using System;

public static class Solution
{
    private static void Main()
    {
        /*Mit vettünk eddig?
            - típusok (pl int, string, char, double, bool)
            - elágazások (if... else if... else)
            - ciklusok (for... while... do/while)
        */

        //1.rész - SWITCH ----------------------------------------
        //Példa: Kérj be a felh.tól egy számot 1-7ig és írd ki hogy milyen napnak felel meg pl. 1-hétfő, 2-kedd
        int szam;
        //Ha bekérnénk a felhtól
        szam = Convert.ToInt32(Console.ReadLine());
        //Most manuálisan
        szam = 2;

        /*Eddigi tudásunkkal
        if (szam == 1)
            Console.WriteLine("Hétfő");
        else if (szam == 2)
            Console.WriteLine("Kedd");
            .......*/

        //Mikor használjuk: egy dolgot nagyon sok mindennel összehasonlítunk -> sok if-else helyett
        
        switch (szam)            //Működik kb minden típusra
        {
            //case - mennyivel egyenlő?
            case 1:
                Console.WriteLine("Hétfő");
                break;
            case 2:
                Console.WriteLine("Kedd");
                break;
            case 3:
                Console.WriteLine("Szerda");
                break;
            case 4:
                Console.WriteLine("Csütörtök");
                break;
            case 5:
                Console.WriteLine("Péntek");
                break;
            case 6:
                Console.WriteLine("Szombat");
                break;
            case 7:
                Console.WriteLine("Vasárnap");
                break;
            default:
                Console.WriteLine("Nincs ilyen napja a hétnek");
                break;
        }
        
        //Példa string-re
        
        string mertekegyseg = "kg";
        
        switch (mertekegyseg)
        {
            case "kg":
                Console.WriteLine("Tömeg m.e.");
                break;
            case "m":
                Console.WriteLine("Hosszúság");
                break;
            //...
        }
        

        //2.rész BREAK, CONTINUE -------------------------------------------------------------------------------------
        //Példa: döntsük el egy számról, hogy prím-e?

        int szam2;
        bool prim_e = true; //true - igaz, false - hamis

        //Ha 2 és (szám - 1) között bármi osztja akkor nem lehet prím
        //Terv: próbálgassunk: ossztuk el minden számmal 2 és (szám - 1) között
        for (int oszto = 2; oszto < szam2; oszto += 1)
        {
            if (szam2 % oszto == 0)
                prim_e = false;
        }
        //itt: ha nem változtattuk meg, akkor prim_e igaz maradt

        //Kérdés: 3693 prím-e? -> 2 és 3692 között el kéne osztani a számot.
        //Már a 2. körnél tudtuk, hogy nem prím de attókl még megy tovább
        //Megoldás: BREAK - megszakítja, kilép a ciklusból

        for (int oszto = 2; oszto < szam2; oszto += 1)
        {
            if (szam2 % oszto == 0)
            {
                prim_e = false;
                break;         //Kilép a cilkusból 
            }
        }
        //break után ide ugrik


        //Példa: vannak számok egymás után, ha a szam 20nál nagyobb akkor állapítsd meg róla, hogy oszható-e néggyel

        //1.kérdés: hogyan is néznek ki a számok egymás után?
        //Válasz: ezek tömbben vannak:
        int[] szamok = { 1, 2, 13, 41, 5, 32, 7, 4, 11, 22, 24, 30 };
        //2.kérdés: hogyan tudok hivatkozni mondjuk a 41-re?
        //Válasz: indexeléssel (0-tól kezdjük!!!!!!!!!)
        //szamok[3]

        //CONTINUE: befejezi a kört és új körbe lép -> megy a következőre

        for (int ind = 0; ind < 12; ind += 1)
        {
            //Ide ugrik a continue de már a következő körben
            if (szamok[ind] <= 20)
                continue;

            //Ez alatt már nem fut le az aktuális körben, ha volt continue
            if (szamok[ind] % 4 == 0)
                Console.WriteLine("Osztható 4-gyel");
            else
                Console.WriteLine("Nem osztható");
        }

        //3. rész tömbök --------------------------------------------------------------
        //Mikor használunk tömböt? 
        //Ha sok, u.olyan típusú adattal kell dolgozni pl. sok egész szám, sok szó
        //Általánosan: típus[] változónév = {..felsorolás...};

        //Példa: egész számok tömbje
        int[] tomb = { 1, 2, 3, 4, 5, 6, 7, 8};
        //Példa: stringek tömbje
        string[] szavak = { "alma", "körte", "szilva", "kakaós csiga" };
        //Példa: valós számok tömbje
        double[] szamok = {1.2, 3.14, 5.6, 7.8, 8.1};

        //Példa: osztály átlagai tanulónként
        double[] atlagok = {3.4, 4.5, 3.3, 2.9, 4.1};


        //Hivatkozás az elemekre
        //0-tól kezdjük!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //tomb_neve[hanyadik_elem-1]
        double[] szamok = {1.2, 3.14, 5.6, 7.8, 8.1};

        //Mennyi a 3. szám?
        double mennyi = szamok[2];
        //Adjunk a 2.elemhez 5-öt
        szamok[1] += 5;


        //Példa: mennyi a számok összege? (Programozási tétel: Összegzés)
        double osszeg = 0;
        for (int ind = 0; ind < 5; ind += 1)
        {
            osszeg += szamok[ind];
        }
    }
}
