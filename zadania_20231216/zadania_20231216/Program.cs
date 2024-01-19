using System;
namespace zadania_20231216
{
    class program
    {
        class Pracownik
        {
            public virtual void Pracuj()
            {
                Console.WriteLine("logowanie");
            }

        }
        class Programista : Pracownik
        {
            public override void Pracuj()
            {
                base.Pracuj();
                Console.WriteLine("Obowiazki programisty");
            }
        }
        class Projektant : Pracownik
        {
            public override void Pracuj()
            {
                base.Pracuj();
                Console.WriteLine("Obowiazki projektanta!");
            }
        }
        class Księgowy : Pracownik
        {
            public override void Pracuj()
            {
                base.Pracuj();
                Console.WriteLine("Obowiazki księgowego!");
            }
        }
        abstract class Figura
        {
            public int liczba1 { get; set; }
            public int liczba2 { get; set; }
            public int liczba3 { get; set; }


            public abstract void Pole();


        }
        class Kwadrat : Figura
        {

            public override void Pole()
            {
                Console.WriteLine("Pole kwadratu: " + (liczba1 * liczba1));
            }
        }
        class Trojkat : Figura
        {
            public override void Pole()
            {
                Console.WriteLine("Pole trojkata: " + (liczba1 * liczba2 / 2));
            }
        }
        class Osoba
        {
            public string imie { get; set; }
            public string nazwisko { get; set; }
            public Osoba(string Imie,string Nazwisko)
            {
                this.imie = Imie;
                this.nazwisko = Nazwisko;
            }
            public virtual void WypiszInfo()
            {
                Console.WriteLine("Imie:{0}\nNazwisko:{1}\n", imie, nazwisko);
            }
        }
        class Student : Osoba
        {
            public int rokStudiów { get; set; }
            public int numerGrupy { get; set; }
            public int numerAlbumu { get; set; }
            public Student(int rok,int Numergrupy,int Numeralbumu,string Imie, string Nazwisko):base( Imie, Nazwisko)
            {
                this.rokStudiów = rok;
                this.numerGrupy = Numergrupy;
                this.numerAlbumu = Numeralbumu;
            }
            public override void WypiszInfo()
            {
                base.WypiszInfo();
                Console.WriteLine("Rok studiów:{0}\nnumer grupy:{1}\nnumer albumu:{2}\n",rokStudiów,numerGrupy,numerAlbumu);
            }

        }
        abstract class Figura2
        {
            protected int a = 1;
            protected int b = 2;
            protected int c = 3;

            

            abstract public int ObliczPole();
        }
        class Kwadra2 : Figura2
        {
            public override int ObliczPole()
            {
                return a * a;
            }
        }
        class trojkat2 : Figura2
        {
            public override int ObliczPole()
            {
                return a * b / 2;
            }
        }
        
        
            static void Main(string[] args)
            {


                Pracownik pracownik = new Pracownik();
                Programista programista = new Programista();
                pracownik.Pracuj();
                programista.Pracuj();
                Console.WriteLine();

                List<Pracownik> ListaPracownikow = new List<Pracownik>()
                {
                new Programista(),
                new Projektant(),
                new Księgowy()

                };
                foreach (Pracownik pp in ListaPracownikow)
                {
                    pp.Pracuj();
                }
                Osoba osoba = new Osoba("A1", "B1");
                Student student = new Student(2, 3, 13233, "A1", "B1");
                Osoba student1 = new Student(2, 3, 13233, "A1", "B1");
                student1.WypiszInfo();

                Kwadra2 kwadra2 = new Kwadra2();
                trojkat2 trojkat2 = new trojkat2();
                Console.WriteLine("Pole kwadratu wynosi:{0}\n", kwadra2);
                Console.WriteLine("Pole trojkata wynosi:{0}\n", trojkat2);
                List<Figura2> listy = new List<Figura2>();
                /*listy.Add(new Figura2(kwadra2));
                listy.Add(new Figura2(trojkat2));*/
                foreach(Figura2 pp in listy)
                {
                    pp.ObliczPole();
                }
            
                    Console.ReadKey();
                }

        }
    
}