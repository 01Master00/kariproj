using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kariproj
{
    internal class Program
    {
        static List<Ajandek> ajandekok = new List<Ajandek>();
        static List<string> kat = new List<string>();
        static int keret;
        static bool t;
        static void Main(string[] args)
        {
 
            t = true;  // KERET
            while (t)
            {
                try
                {
                    Console.Write("kérem adja meg az ajándékokra szánt keretet: ");
                    keret = Convert.ToInt32(Console.ReadLine());

                    if (keret <= 0)
                    {
                        throw new Exception("A keret nem lehet negatív!");
                    }
                    t = false;

                }
                catch (StackOverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("az érték túl ment a kereten!\n");
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Kérem hogy egy számot adjon meg!\n");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Clear();

            int menu = 0;
            do
            {
                t = true;  // MENU
                while (t) {
                    try
                    {
                        Console.Write("1. ajándéklista kezelése(hozzáadás, kivonás, szerkesztés)\n2. ajándékokra szánt keret kezelése\n3. ajándékok megtekintése(kategorizáltan)\n4. statisztikák megtekintése(kosár, legolcsóbb-drágább termék)\n5. kilépés\nkérem válasszon egy opciót: ");
                        menu = Convert.ToInt32(Console.ReadLine());
                        t = false;
                    }
                    catch (StackOverflowException)
                    {
                        Console.Clear();
                        Console.WriteLine("az érték túl ment a kereten!\n");
                    }
                    catch (FormatException) 
                    {
                        Console.Clear();
                        Console.WriteLine("Kérem hogy egy számot adjon meg!\n");
                    }
                }
                
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        c1();
                        break;
                    case 2:
                        Console.Clear();
                        print();
                        break;
                    case 3:
                        Console.Clear();
                        orgprint(); 
                        break;
                    case 4:
                        Console.Clear();

                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("ön a kilépést választotta, Viszlát!");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Kérem válasszon az alábbi opciók közül!!!\n");
                        break;
                }

            }
            while (menu != 6);




        }

        static void c1()
        {
            int menu = 0;
            do
            {
                t = true;
                while (t)
                {
                    try
                    {
                        Console.Write("1. ajándékok hozzáadása\n2. ajándékok kivonása\n3. ajándékok módosítása\nkérem válasszon: ");
                        menu = Convert.ToInt32(Console.ReadLine());
                        if (menu < 1 & menu > 3)
                        {
                            throw new Exception("kérem az egyik opciót válassza!");
                        }

                        t = false;
                    }
                    catch (StackOverflowException)
                    {
                        Console.Clear();
                        Console.WriteLine("az érték túl ment a kereten!\n");
                    }
                    catch (FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Kérem hogy egy számot adjon meg!\n");
                    }
                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                    }
                }

                switch (menu)
                {
                    case 1:
                        Hozzaadas();
                        break;
                    case 2:
                        kivon();
                        break;
                    case 3:
                        mod();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("kérem válasszon az alábbiak körül\n");
                        break;
                }
            } while (menu > 4 & menu < 0);
        }
        static void Hozzaadas()
        {
            string nev = "";
            t = true; // NÉV
            while (t)
            {
                try
                {

                    Console.Write("Nev: ");
                    nev = Console.ReadLine();

                    if (nev == "" || nev == " ")
                    {
                        throw new Exception("A név nem lehet semmi");
                    }
                    t = false;

                }
                catch (StackOverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("az érték túl ment a kereten!\n");
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Kérem hogy egy számot adjon meg!\n");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }

            if (kat.Count > 0)
            {
                Console.Write($"az eléhető kategóriák: ");
                foreach (var item in kat)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }

            string kategoria = "";
            t = true; // KATEGÓRIA
            while (t)
            {
                try
                {

                    Console.Write("kategoria: ");
                    kategoria = Console.ReadLine();


                    if (kategoria == "" || kategoria == " ")
                    {
                        throw new Exception("A kategória nem lehet semmi");
                    }
                    t = false;

                }
                catch (StackOverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("az érték túl ment a kereten!\n");
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Kérem hogy egy számot adjon meg!\n");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }

            int ar = 1;
            t = true; // ÁR
            while (t)
            {
                try
                {

            Console.Write("Ar: ");
            ar = Convert.ToInt32(Console.ReadLine());


                    if (ar < 0)
                    {
                        throw new Exception("Az ár nem lehet negatív!!!");
                    }
                    t = false;

                }
                catch (StackOverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("az érték túl ment a kereten!\n");
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Kérem hogy egy számot adjon meg!\n");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }

            ajandekok.Add(new Ajandek(nev, ar, kategoria));
            Ossz();
            detect();
        }
        static void Ossz()
        {
            int s = 0;
            foreach (var item in ajandekok)
            {
                s += item.Ar;
            }
            if (s < keret)
            {
                Console.WriteLine($"A vásárlás nem lépi túl a keretet, a maradék keret összesen {keret-s}Ft\n");
            }
            else
            {
                Console.WriteLine($"A vásárolt termékek összege túllépte a keretet {s - keret}Ft\n");
            }
        }
        static void kivon()
        {
            if (kat.Count < 0)
            {
                Console.WriteLine("még nincs elem a listában!");
                return;
            }

            Console.Clear() ;   
            print();
            int menu = 0, y = -1;
            t = true;
            while (t)
            {
                try
                {
                    Console.Write("kérem válassza ki a számát a terméknek vagy írjon 0-t ha ki akar lépni: ");
                    menu = Convert.ToInt32(Console.ReadLine());

                    if (menu == 0)
                    {
                        return;
                    }
                    if (menu < 0 & menu > ajandekok.Count())
                    {
                        throw new Exception("kérem az egyik opciót válassza!");
                    }
                    Console.Write($"{ajandekok[menu-1]} ez az elem amit törölni akar? (0 nem / 1 igen): ");
                    y = Convert.ToInt32(Console.ReadLine());
                    if (y != 1)
                    {
                        throw new Exception("ez egy nem!");
                    }
                    else
                    {
                        ajandekok.RemoveAt(menu - 1);
                    }

                    t = false;
                }
                catch (StackOverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("az érték túl ment a kereten!\n");
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Kérem hogy egy számot adjon meg!\n");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("nincs ilyen elem a listában!");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
            


        }
        static void mod()
        {
            if (kat.Count < 0)
            {
                Console.WriteLine("még nincs elem a listában!");
                return;
            }
            print();
            int menu = 0, y = -1;
            string ertek = "";
            t = true;
            while (t)
            {
                try
                {
                    Console.Write("kérem válassza ki a számát a terméknek vagy írjon 0-t ha ki akar lépni: ");
                    menu = Convert.ToInt32(Console.ReadLine());

                    if (menu == 0)
                    {
                        return;
                    }
                    if (menu < 0 & menu > ajandekok.Count())
                    {
                        throw new Exception("kérem az egyik opciót válassza!");
                    }
                    Console.Write($"{ajandekok[menu - 1]} ez az elem amit módosítani akar? (0 nem / 1 igen): ");
                    y = Convert.ToInt32(Console.ReadLine());
                    if (y != 1)
                    {
                        throw new Exception("ez egy nem!");
                    }
                    else
                    {
                        modfunct(menu);
                    }

                    t = false;
                }
                catch (StackOverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("az érték túl ment a kereten!\n");
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Kérem hogy egy számot adjon meg!\n");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("nincs ilyen elem a listában!");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void modfunct(int menu)
        {
            int y = -1;
            string ertek = "";
            t = true;
            while (t)
            {
                try
                {
                    
                    Console.Write($"1. {ajandekok[menu - 1].Nev}\n2. {ajandekok[menu - 1].Kategoria}\n3. {ajandekok[menu - 1].Ar}");
                    y = Convert.ToInt32(Console.ReadLine());
                    if (y > 3 & y < 1)
                    {
                        throw new Exception("Kérem értelmes értéket adjon meg!");
                    }
                    switch (y)
                    {
                        case 1:
                            Console.Write($"mivé szeretné változtatni a nevét: ");
                            ertek = Console.ReadLine();
                            if (ertek == "" || ertek == " ")
                            {
                                throw new Exception("A kategória nem lehet semmi");
                            }
                            ajandekok[menu - 1].Nev = ertek;
                            Console.WriteLine("Sikeres volt!");
                            break;
                        case 2:
                            if (kat.Count > 0)
                            {
                                Console.Write($"az eléhető kategóriák: ");
                                foreach (var item in kat)
                                {
                                    Console.Write(item + " ");
                                }
                                Console.WriteLine();
                            }

                            Console.Write($"mivé szeretné változtatni a kategóriát: ");
                            ertek = Console.ReadLine();
                            if (ertek == "" || ertek == " ")
                            {
                                throw new Exception("A kategória nem lehet semmi");
                            }
                            ajandekok[menu - 1].Kategoria = ertek;
                            Console.WriteLine("Sikeres volt!");
                            break;
                        case 3:
                            Console.Write($"mivé szeretné változtatni az árát: ");
                            y = Convert.ToInt32(Console.ReadLine());
                            if (y < 0)
                            {
                                throw new Exception("az ár nem lehet kisebb 0-nál");
                            }
                            ajandekok[menu - 1].Ar = y;
                            Console.WriteLine("Sikeres volt!");
                            break;
                    }
                    t = false;
                }
                catch (StackOverflowException)
                {
                    Console.Clear();
                    Console.WriteLine("az érték túl ment a kereten!\n");
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Kérem hogy egy számot adjon meg!\n");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("nincs ilyen elem a listában!");
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }
        }








        static void detect()
        {
            foreach (var item in ajandekok)
            {
                if (!kat.Contains(item.Kategoria))
                {
                    kat.Add(item.Kategoria);
                }
            }
        }
        static void orgprint()
        {
            detect();

            foreach (var item in kat)
            {
                foreach (var j in ajandekok)
                {
                    if (item == j.Kategoria)
                    {
                        Console.WriteLine($"{j.Kategoria} {j.Nev} {j.Ar}");
                    }
                }
                Console.WriteLine();
            }


        }
        static void print()
        {
            int i = 0;
            foreach (var item in ajandekok)
            {
                i++;
                Console.WriteLine($"{i}. {item.Nev} {item.Ar} {item.Kategoria}");
            }
        }
    }
}
