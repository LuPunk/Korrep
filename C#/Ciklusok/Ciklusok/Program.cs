using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Add meg a-t: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg b-t: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg c-t: ");
            double c = Convert.ToDouble(Console.ReadLine());

            //Megoldóképlet
            //(-b +- sqrt(b*b - 4*a*c) / 2*a
            //Megoldása akkor van, ha b*b - 4*a*c > 0

            if ((b * b - 4 * a * c) > 0)
            {
                //sqrt - square root -> négyzetgyök
                double meg_1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                double meg_2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

                Console.WriteLine("Az első megoldás: {0}, második: {1}",meg_1,meg_2);
            }
            else
                Console.WriteLine("Ennek az egyenletnek nincs megoldása");
            

            //Feladat: írd ki 500x konzolra, hogy alma
            //1. FOR (ismételd meg x-szer)
            /*Felépítese for(int i = 1; i <= 500; i += 1)
             { }
            */

            //írd ki 5x hogy alma
            for (int i = 0; i < 5; i += 1)
            {
                Console.WriteLine("alma");
            }

            //Feladat: Kérj be a felh. számokat addig amíg -1-et nem ír be
            //2. WHILE (ismételd addig... (feltétel)) - elöltesztelő ciklus
            /*Felépítése
             while (feltétel)
            { mit csinálunk }
            */

            int szam = -1;

            
            while (szam != -1)
            {
                Console.Write("Kérlek adj meg egy számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }

            //3. Do .. While - hátultesztelő ciklus
            
            do
            {
                Console.Write("Kérlek adj meg egy számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            } while (szam != -1);

            //--------------------------------------------------------------
            //Négyzetszámok

            Console.Write("Add meg n értékét: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int szam = 1; szam <= n; szam += 1)
            {
                Console.WriteLine("{0} négyzete: {1}",szam,szam*szam);
            }

            //b feladatrész 1. megoldás
            int szamlalo = 1;
            while (szamlalo < n)
            {
                Console.WriteLine("{0} négyzete: {1}", szamlalo, szamlalo*szamlalo);
                szamlalo += 1;
            }

            //b feladatrész 2. megoldás
            for (int szam = 1; szam < n; szam += 1)
            {
                Console.WriteLine("{0} négyzete: {1}", szamlalo, szamlalo * szamlalo);
            }

            //Feladat: Kérj be felh. két számot elsőre kisebb, majd nagyobb és írd ki az összes számot közöttük
            Console.Write("Kérem a nagyobb számot: ");
            int nagy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a kisebb számot: ");
            int kicsi = Convert.ToInt32(Console.ReadLine());

            //Hibakezelés 
            if (kicsi > nagy)
            {
                Console.WriteLine("Rosszul adtad meg a számokat :(, de én kijavítottam :)");
                
                //Változócsere
                int ideiglenes = kicsi;
                kicsi = nagy;
                nagy = ideiglenes;
            }

            int seged = kicsi;

            while (seged <= nagy)
            {
                Console.WriteLine("{0}", seged);
                seged += 1;
            }
            

            //Osztók
            Console.Write("Kérek egy számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A(z) {0} osztói: ",szam);
            for (int oszto = 1; oszto <= szam; oszto += 1)
            {
                if (szam % oszto == 0)
                    Console.WriteLine(oszto);

            }

            //Számtani sorozat
            Console.Write("Kérem a kisebb számot: ");
            double kisebb = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a nagyobb számot: ");
            double nagyobb = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a lépésközt: ");
            double lepeskoz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Számok {0} és {1} között {2} lépésközzel: ",kisebb,nagyobb,lepeskoz);
            int szaml = 1;
            for (double szamtani = kisebb; nagyobb >= szamtani; szamtani += lepeskoz)
            {
                Console.WriteLine("{0}.elem {1}",szaml,szamtani);
                szaml += 1;
            }

            //Csökkenő
            Console.Write("Kérem a kisebb számot: ");
            double kisebb = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a nagyobb számot: ");
            double nagyobb = Convert.ToDouble(Console.ReadLine());

            Console.Write("Add meg a lépésközt: ");
            double lepeskoz = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Számok {0} és {1} között -{2} lépésközzel: ", nagyobb, kisebb, lepeskoz);
            for (double szamtani = nagyobb; kisebb <= szamtani; szamtani -= lepeskoz)
                Console.Write("{0} ",szamtani);
            

            //Háromszög 
            Console.Write("Adj meg egy számot: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int sor = 1; sor <= n; sor += 1)
            {
                //Rajzolás menete n-szer fog megtörténni
                for (int kor = 1; kor <= sor; kor += 1)
                {
                    //o betű kiírása sor-szor fog megtörténni
                    Console.Write("o");
                }

                Console.WriteLine();
            }
        }
    }
}
