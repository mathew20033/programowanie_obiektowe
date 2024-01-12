using System;
namespace zadanie_car_osoba_pacjent_produkt
{
        class Car
        {
            private string marka { get; set; }
            private int rok { get; set; }
            private string model { get; set; }
            private int iloscDrzwi { get; set; }
            private int pojemnoscSilnika { get; set; }
            public int srednieSpalanie { get; set; }
        
            public string Marka
            {
                get { return marka; }
                set { marka = value; }
            }
            public int Rok
            {
                get { return rok; }
                set
                {
                    if (rok >= 1769 && rok <= 2017)
                    {
                        { rok = value; }
                    }
                }
            }
            public int SrednieSpalanie
            {
                get { return srednieSpalanie; }
                set { srednieSpalanie = value; }
            }
            private double ObliczSpalanie(double dlugoscTrasy)
            {
                return srednieSpalanie * dlugoscTrasy;
            } 
            public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
            {
                return (double)ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
            }
        }
        class Osoba { 
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public int rokUrodzenia { get; set; }
            public int waga { get; set; }
            public int wzrost { get; set; }
            public bool okluary { get; set; }
            public Plec plec { get; set; }
            internal enum Plec
            {
                K,M
            }
            public Osoba(string a, string b, int c, int d,int e ,bool f, Plec plec)
            {
                this.Imie = a;
                this.Nazwisko = b;
                this.rokUrodzenia = c;
                this.waga = d;
                this.wzrost = e;
                this.okluary = f;
                this.plec = plec;

            }

            public int obliczWiek()
            {
                return DateTime.Now.Year - rokUrodzenia;
            }
            public void DodajPrzedrostek()
            {
                if(plec == Plec.M)
                {
                    Console.WriteLine("Dyrektorem jest Pan {0} {1}", Imie, Nazwisko);
                }
                else
                {
                    Console.WriteLine("Dyrektorka jest Pani {0} {1}", Imie, Nazwisko);
                }
            }
        
        }
        class pacjent
        {
            public string imie { get; set; }
            public string nazwisko { get; set; }
            public int wzrost { get; set; }
            public double waga { get; set; }
            
            public pacjent(string a, string b, int c, double d)
            {
                this.imie = a;
                this.nazwisko = b;
                this.wzrost = c;
                this.waga = d;
            }
            public void ObliczBMI()
            {
                double wzrost_pacjenta = wzrost / 100.0;
                double BMI = waga / (wzrost_pacjenta * wzrost);
                if(BMI <= 16)
                {
                    Console.WriteLine("wyglodzenie");
                }
                else if (BMI < 16 && BMI >=16.99)
                {
                    Console.WriteLine("Wychudzenie");
                }
                else if (BMI < 17 && BMI >=18.49)
                {
                    Console.WriteLine("niedowaga");
                }
                else if (BMI <18.5 && BMI>=24.99)
                {
                    Console.WriteLine("waga prawidlowa");
                }
                else if (BMI <25 && BMI>=29.99)
                {
                    Console.WriteLine("nadwaga");
                }
                else if (BMI <30 && BMI >=34.99)
                {
                    Console.WriteLine("otylosc I stopnia");
                }
                else if (BMI <35 && BMI>=39.99)
                {
                    Console.WriteLine("otylosc II stopnia");
                }
                else
                    {
                        Console.WriteLine("otylosc III stopnia");
                    }
            }

        }
        class produkt
        {
            public string nazwa { get; set; }
            public double cena { get; set; }
            public produkt ( string a, double b)
            {
                this.nazwa = a;
                this.cena = b;
            }

        }
        class koszyk
        {
            List<produkt> ListaTowarow = new List<produkt>();
            public void Zakpuy(produkt Produkt)
            {
                ListaTowarow.Add(Produkt);
            }
            public void Wypisz()
            {
                double suma_cen = 0;
                foreach(var produkt in ListaTowarow)
                {
                    Console.Write("Nazwa towaru:{0}\ncena:{1}", produkt.nazwa, produkt.cena);
                    suma_cen += produkt.cena;
                }
                Console.WriteLine("suma za zakupy wynosi:{0}", suma_cen);
            }
        }
        class Zespolone
        {
            public int liczby_rzeczywiste { get; set; }
            public int liczy_urojone { get; set; }
            public Zespolone (int a, int b)
            {
                liczby_rzeczywiste = a;
                liczy_urojone = b;
            }
            public static Zespolone Dodaj(Zespolone a, Zespolone b)
            {
                return new Zespolone(a.liczby_rzeczywiste + b.liczby_rzeczywiste, a.liczy_urojone + b.liczy_urojone);
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Zadania\n1.Car\n2.Osoba\n3.pacjent\n4.produkt i koszyk\n5.Zespolone");
                Console.WriteLine("Prosze podac numer zadania:");
                int choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        string CarName = "Moj Samochod";
                        Console.WriteLine(CarName);
                        Car car1 = new Car();
                        car1.Marka = "Mercedes";
                        car1.Rok = 2024;
                        Console.WriteLine("Marka:{0}\nRok produkcji:{1}\n", car1.Marka, car1.Rok);
                        /*Car car2 = new Car();
                        car2.Marka = "Ford";
                        car2.rok = 2020;
                        Console.WriteLine("Marka:{0}\nRok produkcji:{1}\n", car2.Marka, car2.Rok);
                        car1 = car2;*/
                        Console.WriteLine("Diagram UML");
                        Console.WriteLine("------------------------------");
                        Console.WriteLine("|             Car             |");
                        Console.WriteLine("| + marka:string              |");
                        Console.WriteLine("| + rok:int                   |");
                        Console.WriteLine("| + model:string              |");
                        Console.WriteLine("| + iloscDrzwi:int            |");
                        Console.WriteLine("| + pojemnoscSilnika:int      |");
                        Console.WriteLine("| + srednieSpalanie:int       |");
                        Console.WriteLine("------------------------------");
                        car1.SrednieSpalanie = 25;
                        Console.WriteLine("koszt przejazdu wyniesie:{0}", car1.ObliczKosztPrzejazdu(250.0,6.98));
                        break;
                    case 2:
                        Osoba dyrektor = new Osoba("Alan", "WIWI", 1983, 83, 185, false, Osoba.Plec.M);
                        Console.WriteLine("Imie:{0}\nNazwisko:{1}\nRok urodzenia:{2}\n", dyrektor.Imie, dyrektor.Nazwisko, dyrektor.obliczWiek());
                        dyrektor.DodajPrzedrostek();
                        break;
                    case 3:
                        pacjent Pacjent = new pacjent("ALALA", "WIWIWI", 178, 54);
                        Pacjent.ObliczBMI();    
                        break;
                    case 5:
                        Zespolone zespolone1 = new Zespolone(2, 3);
                        Zespolone zespolone2 = new Zespolone(4, 5);
                        Zespolone zz = Zespolone.Dodaj(zespolone1, zespolone2);
                        Console.WriteLine("{0} + {1}i", zz.liczby_rzeczywiste, zz.liczy_urojone);
                        break;
                }

                Console.ReadKey();
            }
        }
}