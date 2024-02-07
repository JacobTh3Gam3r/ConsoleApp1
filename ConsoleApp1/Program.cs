using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*byte pocetDevri = 11;
            pocetDevri = 11;
            int pocetObyvatel = 28412561;
            float delkaDesky = 6.4F;
            string nazevMesta = "Olomouc";
            viceradkovi
                kometar
            const float koeficient = 4.16F;
            bool prsi = false;
            char znak = '?';
            konverze mezi dat. typy, retezec na cislo
            string pocetBodu = "654";
            int pocedBodu1 = int.Parse(pocetBodu);
            cislo na retezec
            int hodnota = -500000;
            string y = hodnota.ToString();
            float protokol = 12.87F;
            int protoko2 = Convert.ToInt32(protokol);
            Console.WriteLine(protoko2);
            Console.ReadKey(); */
            /*
            //1.
            long hodnota = -12000000000;
            //2.
            string t = Convert.ToString(hodnota);
            Console.WriteLine(t);
            //3.
            string maleCislo = "3,71";
            //4.
            float r = float.Parse(maleCislo);
            Console.WriteLine(r);
            //5.
            char pismeno = 'g';
            //6.
            int pismeno1 = pismeno;
            Console.WriteLine(pismeno1);
            //7.
            bool rozhodnuti = true;
            //8.
            float sirka = 4.51F;
            //9.
            int sirka_cela = Convert.ToInt32(sirka);
            Console.WriteLine(sirka_cela);
            //10.
            char bod = (char)97;
            Console.WriteLine(bod);
            //nebo
            char bod1 = Convert.ToChar(97);
            Console.WriteLine(bod1);
            //11.
            const float mena = 9.51f;
            Console.WriteLine(mena);


            Console.ReadKey();
            
            char deska = '*';
            Console.WriteLine(deska);
            char stul = (char)106;
            Console.WriteLine(stul);
            bool dvere;

            dvere = false;
            Console.WriteLine(dvere);

            long velka_castka = 300000000;
            Console.WriteLine(velka_castka);
            int dluh = -200000;

            string dluh2 = Convert.ToString(dluh);
            Console.WriteLine(dluh2);
            float okno = 1.164f;

            int okno2 = Convert.ToInt32(okno);
            Console.WriteLine(okno2);
            string vypocet = "41,6";
         

            float vypocet2 = float.Parse(vypocet);
            Console.WriteLine(vypocet2);

            const float prah = 6.11f;
            Console.WriteLine(prah);
            
            int penize = 600;
            Console.WriteLine(" " + penize + " " + "Kč");
            Console.WriteLine(" {0} Kč", penize);
            Console.WriteLine();
            int m1 = 6;
            int m2 = 60;
            int vysledek = m1 + m2;
            //1.
            Console.WriteLine(m1 + "+" + m2 + "=" + vysledek);
            //2.
            Console.WriteLine("{0}+{1}={2}", m1, m2, vysledek);
            //"\n" - odradkovani
            //"\t" - odsazeni
            Console.WriteLine("\nPocasi\n\n");
            Console.WriteLine("\t\tKomin");
            Console.WriteLine("Pondeli\n\tUtery\n\t\tStreda\n\t\t\tCtvrtek\n\t\t\t\tPatek\n");
            
            // Výpis znaků \ ", změna barev výxtupu na konzoli
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Panelák\n");
            Console.ResetColor();
            Console.WriteLine("Strom\n");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Letadlo\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("topol\tbříza\nakát\tjasmín");
            Console.ResetColor();
            int vaha = 20;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Váha: {0} kg", vaha);
            Console.ResetColor();
            */
            /*
            // 1.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("zima\n\tjaro\n\t\tléto\n\t\t\tpodzim");
            // 2.
            double vyska = 180;
            Console.WriteLine("Výška: {0} cm", vyska);
            // 3.
            string nazev = "Ovoce";
            string spolecnost = "s.r.o.";
            string zamereni = "dovoz jižního ovoce";
            Byte doba = 15;

            Console.WriteLine("Jm. firmy:\t{0}, {1}\nČinnost:\t{2}\nNa trhu:\t{3} let", nazev, spolecnost, zamereni, doba);

            // 4.
            Console.WriteLine("Dnes se již neobejdeme bez \"moderních technologií\".");

            // 5.
            Console.Write("Barevný televizor značky ");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("L");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("G");
            Console.ResetColor();
            */
            /*
            Console.WriteLine("Program secte a odecte 2 desetina cisla");
            
            //definovani
            Console.Write("Zadej 1. desetine cislo: ");
            float InpOne = float.Parse(Console.ReadLine());
            Console.Write("Zadej 2. desetine cislo: ");
            float InpTwo = float.Parse(Console.ReadLine());
            //vypocet
            float OutP = InpOne + InpTwo;
            float OutM = InpTwo - InpOne;
            Console.WriteLine("Soucet = {0}\nRoydil = {1}", OutP, OutM);
            
            //2.
            Console.WriteLine("Vypocet hodnoty linearni funkce y = 6 * x -5");
            Console.Write("Zadejte cislo x: ");
            double x = double.Parse(Console.ReadLine());
            double y = 6 * x - 5;
            Console.WriteLine("y = {0}", y);
            
            //3.
            int a = 30;
            int b = 408;
            Console.WriteLine("a: {0}, b: {1}", a, b);

            (a, b) = (b, a);
            Console.WriteLine("a: {0}, b: {1}", a, b);

            Console.Write("Zadej velikost polomeru kruhu (cm): ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Zadej pocet desetinych mist vysledku: ");
            int des_mist = int.Parse(Console.ReadLine());
            double obvod = 2 * Math.PI * r;
            double obsah = Math.PI * r * r;
            obvod = Math.Round(obvod, des_mist);
            obsah = Math.Round(obsah, des_mist);
            Console.WriteLine("Obvod = {0} cm\nObsah = {1} cm²", obvod, obsah);
            
            Console.Write("zadejte 1. celé číslo: ");
            int delenec = int.Parse(Console.ReadLine());
            Console.Write("zadejte 2. celé číslo: ");
            int delitel = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (delitel == 0)
            {
                Console.WriteLine("Nulou dělit nelze.");
            }
            else
            {
                Console.Write("Zadej pocet desetinych mist vysledku: ");
                int des_mist = int.Parse(Console.ReadLine());
                double podil = (double)delenec / (double)delitel;
                podil = Math.Round(podil, des_mist);
                Console.WriteLine("Výsledek dělení je: {0}", podil);
            }
            
            Console.Write("zadejte délku strany a v cm: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("zadejte délku strany b v cm: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("zadejte délku strany c v cm: ");
            double c = double.Parse(Console.ReadLine());

            double objem = a * b * c;
            Console.WriteLine("Objem kvádru je: {0} cm^3", objem);
            double povrch = 2 * (a * b + a * c + b * c);
            Console.WriteLine("Povrch kvádru je: {0} cm^2", povrch);
            */

            //větvení
            /*
            Console.Write("zadejte 1. celé číslo (dělenec): ");
            int delenec = int.Parse(Console.ReadLine());
            Console.Write("zadejte 2. celé číslo (dělitel): ");
            int delitel = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (delitel == 0)
            {
                Console.WriteLine("Nulou dělit nelze.");
            }
            else
            {
                Console.Write("Zadej počet desetiných míst výsledku: ");
                int des_mist = int.Parse(Console.ReadLine());
                double podil = (double)delenec / (double)delitel;
                podil = Math.Round(podil, des_mist);
                Console.WriteLine("Výsledek dělení je: {0}", podil);
            }
            
            //diagnostika čísla
            Console.Write("Zadej lib. cele cislo: ");
            int x = int.Parse(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine("Cislo je kladne.");
            }
            else if (x < 0)
            {
                Console.WriteLine("Cislo je zaporne.");
            }
            else
            {
                Console.WriteLine("Cislo je nula.");
            }
            if (x % 2 == 0)
            {
                Console.WriteLine("Cislo je sude.");
            }
            else
            {
                Console.WriteLine("Cislo je liche.");
            }
            int ax = Math.Abs(x);
            Console.WriteLine("Absolutni hodnota zadaneho cislo je {0}", ax);

            Console.Write("Zadej dalsi cele cislo: ");
            int y = int.Parse(Console.ReadLine());
            double proc = (double)x/y;
            */
            /*
            Console.Write("zadejte 1. celé číslo (dělenec): ");
            int delenec = int.Parse(Console.ReadLine());
            Console.Write("zadejte 2. celé číslo (dělitel): ");
            int delitel = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (delitel != 0) {
                Console.WriteLine("Vyberte metodu pro výpočet: \n\ta) klas. dělení \n\tb) celočíselné dělení \nVáš výběr:");
                char vyber = char.Parse(Console.ReadLine());
                if (vyber == 'a') {
                    Console.Write("Zadej pocet desetinych mist vysledku: ");
                    int des_mist = int.Parse(Console.ReadLine());
                    double podil = (double)delenec / (double)delitel;
                    podil = Math.Round(podil, des_mist);
                    Console.WriteLine("Výsledek dělení je: {0}", podil);
                }
                else if (vyber == 'b') {
                    int cel_podil = delenec / delitel;
                    int zbytek = delenec % delitel;
                    Console.WriteLine("Celočíselný podíl: {0}, zbytek {1}", cel_podil, zbytek);
                }
                else {
                    Console.WriteLine("Chybně vybráno.\n Program bude ukončen.");
                }
            }
            else {
                Console.WriteLine("Nulou dělit nelze.\nProgram bude ukončen"); 
            }
            */
            /*
            Random random = new Random();
            int a = random.Next(0, 201);
            int b = random.Next(0, 201);
            int c = random.Next(0, 201);
            int d = random.Next(0, 201);
            int e = random.Next(0, 201);
            int f = random.Next(0, 201);
            int g = random.Next(0, 201);
            int h = random.Next(0, 201);
            int i = random.Next(0, 201);
            int[] cisla = { a, b, c, d, e, f, g, h, i };
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {0}, e = {1}, f = {2} ,g = {0}, h = {1}, i = {2}", a, b, c, d, e, f, g, h, i);
            Array.Sort(cisla);
            Console.WriteLine("Seřazená čísla: " + String.Join(", ",cisla));
            */
            
            //př. 1
            double ucet = 20000;
            Console.Write("Zadejte cenu zboží: ");
            double cena_zbozi = double.Parse(Console.ReadLine());
            if (cena_zbozi <= ucet)
            {
                double rozdil = ucet - cena_zbozi;
                Console.WriteLine("OK, zustatek: {0}", rozdil);
            }
            else
            {
                Console.WriteLine("Transakce nebyla provedena!");
            }
            //př. 2
            Console.Write("Zadejte cenu zakázky: ");
            double cena_zakazky = double.Parse(Console.ReadLine());
            if (cena_zakazky < 50000)
            {
                Console.WriteLine("Nebyla poskytnuta sleva");
                Console.WriteLine("Cena zakazky je: {0}", cena_zakazky);
            }
            else if (cena_zakazky >= 50000 && cena_zakazky < 150000)
            {
                double cena_po_sleve = cena_zakazky - 5000;
                Console.WriteLine("Aplikovana sleva 5000 Kč");
                Console.WriteLine("Cena zakazky po aplikovani slevy je: {0}", cena_po_sleve);
            }
            else
            {
                double cena_po_sleve = cena_zakazky * 0.97;
                Console.WriteLine("Aplikovana sleva 3%");
                Console.WriteLine("Cena zakazky po aplikovani slevy je: {0}", cena_po_sleve);
            }


            Console.ReadKey();







        }
    }
}
