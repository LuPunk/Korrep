using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Elagazasok
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat 
            Console.Write("Add meg mennyi 100as van: ");
            int db_szaz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg mennyi 200as van: ");
            int db_ketszaz = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg mennyi 500as van: ");
            int db_otszaz = Convert.ToInt32(Console.ReadLine());

            int osszeg = db_otszaz * 500 + db_ketszaz * 200 + db_szaz * 100;
            Console.WriteLine("Az összeg: {0}",osszeg);
            

            //2.feladat
            Console.Write("Add meg hány fok van: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            //F = Celsius * 1.8 + 32
            double fahr = celsius * 1.8 + 32;
            Console.WriteLine("Fahrenheit értéke = {0}",fahr);

            //Időtartam
            Console.Write("Add meg az első időpontot (óra): ");
            int id1_ora = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg az első időpontot (perc): ");
            int id1_perc = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg az első időpontot (mp): ");
            int id1_sec = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a második időpontot (óra): ");
            int id2_ora = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a második időpontot (perc): ");
            int id2_perc = Convert.ToInt32(Console.ReadLine());

            Console.Write("Add meg a második időpontot (mp): ");
            int id2_sec = Convert.ToInt32(Console.ReadLine());

            int id1 = id1_ora * 3600 + id1_perc * 60 + id1_sec;
            int id2 = id2_ora * 3600 + id2_perc * 60 + id2_sec;

            int eredmeny = id2 - id1;
            Console.WriteLine("Eredmény: {0}",eredmeny);
            

            //4.feladat
            //Kerülete: a + b + c 
            //Területe: (a * ma) / 2
            
            Console.Write("a oldal: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b oldal: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c oldal: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("magassag: ");
            double ma = Convert.ToDouble(Console.ReadLine());

            double kerulet = a + b + c;
            double terulet = (a * ma) / 2;

            Console.WriteLine("Kerület: {0}, Terület: {1}",kerulet,terulet);
            

            //Pozitív, negatív, nulla
            Console.Write("Adj meg egy számot: ");
            double szam = Convert.ToDouble(Console.ReadLine());

            if (szam > 0)
            {
                Console.WriteLine("A szám pozitív");
            }
            else if (szam < 0)
            {
                Console.WriteLine("A szám negatív");
            }
            else
            {
                Console.WriteLine("A szám nulla");
            }
            

            //Fizetés
            Console.Write("Add meg a fizetésed: ");
            int fizetes = Convert.ToInt32(Console.ReadLine());

            if (fizetes > 150000)
            {
                Console.WriteLine("A te fizetésed magas");
            }
            else if (fizetes < 150000)
            {
                Console.WriteLine("A fizetésed alacsony");
            }
            else
            {
                Console.WriteLine("A fizetésed pont jó");
            }
            

            //Turi
            Console.Write("Hány pólót veszel?: ");
            int polo_szam = Convert.ToInt32(Console.ReadLine());
            int fizetni = 0;

            if (polo_szam >= 3)
            {
                fizetni = (polo_szam - 2) * 400 + 450 + 500;
            }
            else if (polo_szam == 2)
            {
                fizetni = 500 + 450;
            }
            else
            {
                fizetni = 500;
            }

            Console.WriteLine("Neked {0}Ft-ot kell fizetni.",fizetni);
        }
    }
}
