using System;
using System.Security.Cryptography;

namespace Zadanie
{
    class prostokat
    {
        private int dlugosc { get; set; }
        private int szerokosc { get; set; }
        public prostokat(int a, int b)
        {
            dlugosc = a;
            szerokosc = b;
        }
        private double powierzchnia(int dlugosc, int szerokosc)
        {
            return dlugosc * szerokosc;
        }
        private double obwod(int dlugosc, int szerokosc)
        {
            return dlugosc * 2 + szerokosc * 2;
        }
        public void Prezentuj()
        {
            Console.WriteLine("Powierzchnia wynosi:{0}", powierzchnia(dlugosc, szerokosc));
            Console.WriteLine("Obwod wynosi:{0}", obwod(dlugosc, szerokosc));
        }
        public static void Najwiekszy(prostokat[] tab)
        {
            


        }

    }
    class Energia
    {
        public int rejestracja_poczatkowa_energi { private get; set; }
        public int biezacy_stan_licznika { get; set; }
        public Energia(int a1, int s2)
        {
            rejestracja_poczatkowa_energi = a1;
            biezacy_stan_licznika = s2;
        }
        public void Pokaz_bizacy_stan()
        {
            Console.WriteLine("stan poczatkowy energii:{0,5}\n stan biezacy energii:{1,5}", rejestracja_poczatkowa_energi, biezacy_stan_licznika);
        }
        public void Obecny_stan_Energii()
        {
            int obecny = biezacy_stan_licznika - rejestracja_poczatkowa_energi;
            Console.WriteLine("Obecny stan licznika energii wynosi:{0}", biezacy_stan_licznika);
        }
    }
    class Punkt
    {
        public int WA { get; set; }
        public int WB { get; set; }
        public string Nazwa_punktu { get; set; }
        public Punkt(int q1,int q2, string q3)
        {
            this.WA = q1;
            this.WB = q2;
            this.Nazwa_punktu = q3;
        }
        public void Przesun(int q1, int q2)
        {
            WA += q1;
            WB += q2;
        }
        public void Wyswietl()
        {
            Console.WriteLine("Wspolrzedne punktu:{0} wynosza nastepujaco:{1}, {2}", Nazwa_punktu, WA, WB);
        }
    }
    class Odcinek
    {
        public int punkt_a { get; set; }
        public int punkt_b { get; set; }

        public int punkt_c { get; set; }

        public int punkt_d { get; set; }
        public Odcinek(int punktA, int punktB, int punktC, int punktD)
        {
            this.punkt_a = punktA;
            this.punkt_b = punktB;
            this.punkt_c = punktC;
            this.punkt_d = punktD;
        }
        public void odcinek()
        {

            int obliczenie = (int)Math.Sqrt((punkt_b - punkt_a) * 2 + (punkt_d - punkt_c) * 2);
            Console.WriteLine("dlugosc odcinka wynosi:{0}", obliczenie);
        }
    }
    class prostopadloscian
    {
        public int dlugosc { get; set; }
        public int szerokosc { get; set; }
        public int wysokosc { get; set; }

        public int dlugosc2 { get; set; }
        public int szerokosc2 { get; set; }
        public int wysokosc2 { get; set; }
        public prostopadloscian(int dl1, int szer1, int wys1, int dl2, int szer2, int wys2)
        {
            this.dlugosc = dl1;
            this.szerokosc = szer1;
            this.wysokosc = wys1;
            this.dlugosc2 = dl2;
            this.szerokosc2 = szer2;
            this.wysokosc2 = wys2;
        }
       

        public int obliczenie_prostopadloscianu1(int dlugosc, int szerokosc, int wysokosc)
        {
            return dlugosc * szerokosc * wysokosc;
        }
        public int obliczenie_prostopadloscianu2(int dlugosc2, int szerokosc2, int wysokosc2)
        {
            return dlugosc2 * wysokosc2 * szerokosc2;
        }
        public void porownanie()
        {
            if (obliczenie_prostopadloscianu1(dlugosc,szerokosc,wysokosc)== obliczenie_prostopadloscianu2(dlugosc2, szerokosc2, wysokosc2)){
                Console.WriteLine("prostopadlosciany maja takie same objetosci!");
            }
            else
            {
                Console.WriteLine("prostopadlosciany nie maja takie same objetosci!");
            }
            
        }

    }
    public struct zad1
    {
        private int dlugosc { get; set; }
        private int szerokosc { get; set; }

        public zad1(int h1,int h2)
        {
            this.dlugosc = h1;
            this.szerokosc = h2;
        }
        private int Powierzchnia(int h1, int h2)
        {
            return dlugosc + szerokosc;
        }
        private int Obwod(int h1, int h2)
        {
            return dlugosc * szerokosc;
        }
        public void Prezentuj()
        {
            Console.WriteLine("Powierzchnia wynosi:{0}\n obwod wynosi:{1}", Powierzchnia(dlugosc,szerokosc),Obwod(dlugosc,szerokosc));
        }
    }
    class program
    {

        static void Main(string[] args)
        {
            double choose;
            Console.WriteLine("Prosze wybrac zadanie:");
            choose = Convert.ToDouble(Console.ReadLine());
            switch (choose)
            {
                case 6.1:
                    prostokat p = new prostokat(10, 20);
                    p.Prezentuj();
                    break;
                case 6.2:
                    prostokat[] q = new prostokat[3];
                    q[0] = new prostokat(1, 2);
                    q[1] = new prostokat(3, 4);
                    q[2] = new prostokat(5, 6);
                    foreach (prostokat i in q)
                    {
                        i.Prezentuj();
                    }
                    break;
                case 6.3:
                    Energia ii = new Energia(400, 2000);
                    ii.Pokaz_bizacy_stan();
                    ii.Obecny_stan_Energii();
                    break;
                case 6.4:
                    Punkt ppp = new Punkt(5,7,"Olsztyn");
                    ppp.Przesun(5,7);
                    ppp.Wyswietl();
                    break;
                case 6.5:

                    break;
                case 6.6:

                    break;
                case 6.7:
                    Odcinek odc = new Odcinek(5, 2, 8, 4);
                    odc.odcinek();
                    break;
                case 6.8:
                    prostopadloscian prost = new prostopadloscian(3, 5, 9, 3, 6, 4);
                    prost.porownanie();
                    break;
                case 6.9:
                    zad1 zz = new zad1(3,6);
                    zz.Prezentuj();
                    break;
            }
            Console.ReadKey();
        }
    }
}