using System;
using System.Runtime.Intrinsics.X86;

namespace zad_5
{
    class program
    {
        static double Temperatura(double stopnie_F)
        {
            double stopnie_C;
            stopnie_C = (stopnie_F - 32.0) / 2.0;
            return stopnie_C;
        }
        static int zadanie2(int a, int b, int x)
        {

            if ((a<=x && x<=b))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static int[] mnozenie_tablicy(int[] array1, int mnozenie)
        {
            int[] array2 = new int[array1.Length];
            for(int i = 0; i < array1.Length; i++)
            {
                array2[i] = 2 * array1[i];
            }
            return array2;
        }
        static void mnozenie_tablicy_2(int[] array1, int mnozenie)
        {
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                array1[i] *= mnozenie;
            }
        }
        static string[] mnozenie_tablicy_3(string[] array1, int mnozenie)
        {
            string[] array2 = new string[array1.GetLength(0)];
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < mnozenie; j++)
                {
                    array2[i] += array1[i];
                }
            }
            return array2;
        }

        static void zadanie_3(ref double a, ref double b, double a1, double b2)
        {
            a += a1;
            b += b2;
        }
        static void zadanie_5(int a, int b, char c)
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }

        static int zadanie_7(int x, int n)
        {
            int aa = 0;
            for(int i = 1; i <= n; i++)
            {
                aa += x + i;
            }
            return aa;
        }
        static int zadanie_8(string a)
        {
            int x = 0;
            for (int i = 0; i < a.Length; i++)
            {
                x += a[i]-'0';
            }
            return x;
        }

        static int ciag_Fibonacciego(int n)
        {
            if(n ==0 || n == 1)
            {
                return n;
            }
            
            return ciag_Fibonacciego(n - 1) + ciag_Fibonacciego(n - 2);
            
        }

        static int Oblicz(int n)
        {
            if (n <= 1) return (1);
            else return (n + Oblicz(n - 1));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("zadanie 10 -> 5.010");
            double choose;
            Console.WriteLine("Prosze podac numer zadania:");
            choose = Convert.ToDouble(Console.ReadLine());
            switch (choose)
            {
                case 5.1:
                    double stopnie_F;
                    Console.WriteLine("Prosze podac temperature w stopniach Fahrenheita:");
                    stopnie_F = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Temperatura w stopniach Celsjusza wynosi:{0}", Temperatura(stopnie_F));
                    break;
                case 5.2:
                    int liczba1, liczba2, liczba3;
                    Console.WriteLine("Prosze podac liczbe do zmiennej a:");
                    liczba1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Prosze podac liczbe do zmiennej b:");
                    liczba2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Prosze podac liczbe do zmiennej x:");
                    liczba3 = Convert.ToInt32(Console.ReadLine());
                    int zwroc = zadanie2(liczba1, liczba2, liczba3);
                    if(zwroc == 0)
                    {
                        Console.WriteLine("x nie nalezy do przedzialu({0},{1})", liczba1, liczba2);
                    }
                    else if(zwroc ==1)
                    {
                        Console.WriteLine("x nalezy do przedzialu({0},{1})", liczba1, liczba2);
                    }
                    break;
                case 5.3:
                    double q, qq;
                    Console.WriteLine("Prosze podac wspolrzedne do A - x:");
                    q = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Prosze podac wspolrzedne do A - y:");
                    qq = Convert.ToDouble(Console.ReadLine());
                    double[] wek = new double[2];
                    wek[0] = 3;
                    wek[1] = 2;
                    Console.WriteLine("Punkt A = ({0},{1})", q, qq);
                    zadanie_3(ref q, ref qq, wek[0], wek[1]);
                    Console.WriteLine("Po przesuniecie Punkt A = ({ 0},{ 1})", q, qq);
                    break;
                case 5.4:
                    int[] array1 = new int[6];
                    int mnozenie;
                    for(int i = 0; i < array1.Length; i++)
                    {
                        Console.WriteLine("Prosze podac liczbe do tablicy:");
                        array1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Prosze podac liczbe do pomnozenia tablicy:");
                    mnozenie = Convert.ToInt32(Console.ReadLine());
                    mnozenie_tablicy(array1, mnozenie);
                    break;
                case 5.5:
                    int m1, m2;
                    char m3;
                    Console.WriteLine("Prosze podac dlugosc:");
                    m1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj szerokosc:");
                    m2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Prosze podac znak:");
                    m3 = Convert.ToChar(Console.ReadLine());
                    zadanie_5(m1, m2, m3);
                    Console.WriteLine();
                    zadanie_5(m1, m2, m3);
                    break;
                case 5.6:
                    string[] array2 = new string[3];
                    array2[0] = "ala";
                    array2[1] = "kot";
                    array2[2] = "dom";
                    int mnozenie2;
                    Console.WriteLine("Prosze podac ilosc mnozenia:");
                    mnozenie2 = Convert.ToInt32(Console.ReadLine());
                    string[] xx = mnozenie_tablicy_3(array2, mnozenie2);
                    foreach(var item in xx)
                    {
                        Console.Write(item+" ");
                    }
                    break;
                case 5.7:
                    int l1, l2;
                    Console.WriteLine("prosze podac liczbe do zmiennej x:");
                    l1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Prosze podac liczbe naturalna:");
                    l2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ciag liczb wynosi:{0}", zadanie_7(l1, l2));
                    break;
                case 5.8:
                    string l3;
                    Console.WriteLine("Prosze podac liczbe:");
                    l3 = Console.ReadLine();
                    Console.WriteLine("Suma podanej liczby wynosi:{0}", zadanie_8(l3));
                    break;
                case 5.9:
                    int n2;
                    Console.WriteLine("Prosze podac n-ty wyraz dla ciągu Fibonacciego:");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ciag Fobonacciego wynosi:{0}", ciag_Fibonacciego(n2));
                    break;
                case 5.010:
                    int n1;
                    Console.WriteLine("Prosze podac parametr n:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(Oblicz(n1));
                    break;
            }

            Console.ReadKey();
        }
    }
}
