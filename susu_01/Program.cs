using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alapok1
{
    internal class Program
    {

        //függvény = van visszatérő érték
        //eljárás = nincs visszatérő érték


        static void feladat1()
        {
            Console.Write("Elsőszám: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Második szám: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int osszeg = a + b;

            Console.WriteLine($"A két szám összege: {osszeg}");
        }


        static void feladat2()
        {

            Console.Write("Hosszúság: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Szélesség: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Terület: {a * b}");
            Console.WriteLine($"Kerület: {(a * 2) + (b * 2)}");

        }


        static void feladat3(int eddig)
        {
            List<int> list = feladat5(eddig, "szám");

            Console.Write("A megadott számok: ");
            foreach (int item in list)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.Write("\n");
            Console.WriteLine($"Összegük: {list.Sum()}");
        }


        static void feladat4()
        {
            Console.Write("Hány számot szeretne megadni: ");
            int a = int.Parse(Console.ReadLine());
            int nulla = 0;
            while (nulla < a)
            {
                Console.WriteLine($"{nulla + 1} ");
                nulla++;
            }

            /* vagy


            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"{i + 1} ");
            }
         

            */
        }

        static List<int> feladat5(int eddig, string szoveg)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < eddig; i++)
            {
                Console.Write($"{i + 1}. {szoveg}: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            return list;
        }


        static void feladat6(int eddig)
        {
            List<int> list = feladat5(eddig, "szám");

            Console.Write("A megadott számok: ");
            foreach (int item in list)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.Write("\n");
            Console.WriteLine($"Összegük: {list.Sum()}");
        }


        static void Main(string[] args)
        {
            #region 1.feladat
            //feladat1();
            #endregion

            #region 2.feladat
            //feladat2();
            #endregion

            #region 3.feladat
            //Console.Write("Hány számot szeretne megadni?: ");
            //int db = Convert.ToInt32(Console.ReadLine());
            //feladat3(db);
            #endregion

            #region 4.feladat
            //feladat4();
            #endregion

            #region 5.feladat
            //Console.Write("Hány jegyet szeretne megadni: ");
            //int jegyekszáma = int.Parse(Console.ReadLine());
            //List<int> jegyek = feladat5(jegyekszáma, "jegy");

            //Console.WriteLine($"A jegyek száma:{jegyekszáma}");

            //int osszeg = 0;
            //foreach (int item in jegyek)
            //{
            //    osszeg += item;
            //}

            //Console.WriteLine($"Az összeg: {osszeg}");

            //double átlag = (double)osszeg / (double)jegyekszáma;
            //Console.WriteLine($"Átlag: {átlag:0.000}");
            #endregion

            #region 6. feladat
            // kérjünk be 5 egész számot amit késöbb meglehet változtatni,
            // írja ki az 5 szám közül a legnagyobbat és az átlahgukat (2 tizedesjegyig)
            #endregion



            // HáziFeladat:

            // 1. feladat: Magyarország megyéinek számának meghatározása. Kérje be a program és tárolja el a megyék neveit, ezek után kérje
            // be a megyék lakosainak számát majd írja ki a legtöbb lakosú megye nevét és lakosainak számát.
            // 2.feladat: Írja ki a megyék átlagos lakosságát,és írja ki azon megyék neveit és írja ki azoknak a megyéknek a nevét ahol az átlagnál kevesebben élnek


            #region Házi 1.feladat
            Console.Write("Hány db megyénk van?: ");
            int db = Convert.ToInt32(Console.ReadLine());
            List<string> Megyék = new List<string>();
            List<long> Lakosság = new List<long>();
            List<string> Átlag = new List<string>();

            for (int i = 0; i < db; i++)
            {
                Console.Write("Megye neve:");
                Megyék.Add(Console.ReadLine());
                Console.Write("Lakosság:");
                Lakosság.Add(Convert.ToInt64(Console.ReadLine()));
            }

            long max_lakossago = Lakosság.Max();
            Console.WriteLine($"A legtöbb lakossal rendelkező megye: {Megyék[Lakosság.IndexOf(max_lakossago)]}, lakosainak száma: {max_lakossago}");
            #endregion

            #region Házi 2.feladat
            long átlag = (long)Lakosság.Average();
            Console.WriteLine($"Az átlagos lakosság: {átlag}");
            foreach (long item in Lakosság)
            {
                if (item < átlag)
                {
                    Átlag.Add(Megyék[Lakosság.IndexOf(item)]);
                }
            }

            Console.WriteLine($"Azok a megyék ahol átlag alatti a lakosság: {string.Join(", ", Átlag)}");

            #endregion
        }
    }
}