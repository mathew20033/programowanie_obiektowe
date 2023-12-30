using System;

namespace zadania
{
    class program
    {
        static void Main(string[] args)
        {
            /*zadanie 3.1*/
            int year;
            Console.WriteLine("Podaj rok:");
            year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine("{0} to rok przestępny", year);
            }
            else
            {
                Console.WriteLine("To nie jest rok przestępny!");
            }

            /*zadanie 3.2*/
            int number1, number2;
            Console.WriteLine("Podaj liczbe :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj kolejna liczbe:");
            number2 = Convert.ToInt32(Console.ReadLine());
            if(number2 % number1==0)
            {
                Console.WriteLine("{0} jest dzielnikiem liczby {1}", number2, number1);
            }
            else
            {
                Console.WriteLine("Liczba {0} nie jest dzielnikiem liczby{1}", number2, number1);
            }

            /*zadanie 3.3*/
            int liczba1, liczba2, liczba3;
            Console.WriteLine("Podaj pierwszą liczbę:");
            liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            liczba2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę:");
            liczba3 = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[3] { liczba1, liczba2, liczba3 };
            int  max1 = array1[0];
            foreach(int item in array1)
            {
                if (item > max1)
                {
                    max1 = item;
                }
                
            }
            Console.WriteLine("Największa liczba:{0}", max1);

            /*zadanie 3.4*/
            string user1;
            double liczba_1, liczba_2,wynik;
            Console.WriteLine("Podaj pierwszą liczbę");
            liczba_1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            liczba_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" + dodawanie");
            Console.WriteLine(" - odejmowanie");
            Console.WriteLine("*  mnożenie");
            Console.WriteLine("/  dzielenie");
            Console.WriteLine("wpisz znak operacji:");
            user1 = Console.ReadLine();
            switch (user1)
            {
                case "+":
                    wynik = liczba_1 + liczba_2;
                    Console.WriteLine("Wynik dodawania liczby{0,5} oraz liczby {1,5}  wynosi:{2,5}", liczba_1, liczba_2, wynik);
                    break;
                case "-":
                    wynik = liczba_1 - liczba_2;
                    Console.WriteLine("Wynik odejmowania liczby{0,5} oraz liczby {1,5}  wynosi:{2,5}", liczba_1, liczba_2, wynik);
                    break;
                case "*":
                    wynik = liczba_1 * liczba_2;
                    Console.WriteLine("Wynik mnożenia liczby{0,5} oraz liczby {1,5}  wynosi:{2,5}", liczba_1, liczba_2, wynik);
                    break;
                case "/":
                    wynik = liczba_1 / liczba_2;
                    Console.WriteLine("Wynik dzielenia liczby{0,5} oraz liczby {1,5}  wynosi:{2,5}", liczba_1, liczba_2, wynik);
                    break;
            }
            /*zadanie 3.5*/

            int a, b, c, delta, suma_liczb=0,wynik3;
            Console.WriteLine("podaj dane do zmiennej a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj dane do zmiennej b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj dane do zmiennej c:");
            c = Convert.ToInt32(Console.ReadLine());
            delta = (b * b) - 4 * a * c;
            if(delta > 0)
            {
                wynik3 = (int)Math.Sqrt(delta);
                suma_liczb += 2;
                Console.WriteLine("liczba pierwiastków równania kwadratowego wynosi:{0}", suma_liczb);
            }
            else if (delta == 0)
            {
                suma_liczb += 1;
                Console.WriteLine("liczba pierwiastków równania kwadratowego wynosi:{0}", suma_liczb);
            }
            else
            {
                Console.WriteLine("Brak miejsc zerowych dla równania kwadratowego!");
            }

            /* zadanie 3.6*/
            double masa, wzrost, BMI;
            Console.WriteLine("Podaj mase ciała w kilogramach:");
            masa = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach:");
            wzrost = Convert.ToDouble(Console.ReadLine());
            BMI = masa / (wzrost * wzrost);
            if(BMI < 16.0)
            {
                Console.WriteLine("Kategoria : wygłodzenie!");
                Console.WriteLine("Waga ciała: niedowaga!");
            }
            else if (BMI>=16.0 && BMI <= 16.99)
            {
                Console.WriteLine("Kategoria: wychudzenie!");
                Console.WriteLine("Waga ciała: niedowaga!");
            }
            else if (BMI >= 17.0 && BMI <= 18.49)
            {
                Console.WriteLine("Kategoria: niedowaga!");
                Console.WriteLine("Waga ciała: niedowaga!");
            }
            else if(BMI >=18.5 && BMI <= 24.99)
            {
                Console.WriteLine("Kategoria : pożądana masa ciała");
                Console.WriteLine("Waga ciała: wartość prawidłowa!");
            }
            else if (BMI>=25.0 && BMI <= 29.99)
            {
                Console.WriteLine("Kategoria : nadwaga!");
                Console.WriteLine("Waga ciała: nadwaga!");
            }
            else if (BMI>=30.0 && BMI <= 34.99)
            {
                Console.WriteLine("Kategoria : otyłość I stopnia!");
                Console.WriteLine("Waga ciała: otyłość!");
            }
            else if(BMI>= 35.0 && BMI <= 39.99)
            {
                Console.WriteLine("Kategoria : otyłość II stopnia!");
                Console.WriteLine("Waga ciała: otyłość!");
            }
            else
            {
                Console.WriteLine("Kategoria : otyłość III stopnia!");
                Console.WriteLine("Waga ciała: otyłość!");
            }

            /* zadanie 3.7*/
            Console.WriteLine("Wpisz numer dnia tygodnia");
            string numer = Console.ReadLine();
            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;
                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia!");
                    break;
            }

            /* zadnaie 3.8 */
            double user_srednia;
            Console.WriteLine("Podaj średnią ocen:");
            user_srednia = Convert.ToDouble(Console.ReadLine());
            if(user_srednia>= 2.0 && user_srednia <= 3.99)
            {
                Console.WriteLine("Kwota stypendium:{0} zł", 0.00);
            }
            else if(user_srednia>= 4.0 && user_srednia <= 4.79)
            {
                Console.WriteLine("Kwota stypendium:{0} zł", 350.00);
            }
            else{
                Console.WriteLine("Kwota stypendium:{0} zł", 550.00);
            }

            /* zadanie 3.9*/

            int aa;
            
            Console.WriteLine("podaj liczbę wierszy:");
            aa = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= aa; i++)
            {
                for (int j = 1; j <=i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < aa; i++)
            {
                for (int j = 0; j <= aa-i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i <aa; i++)
            {
                for (int j = 1; j < aa-1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i <= aa; ++i)
            {
                for (int j = 0; j < aa; ++j)
                {
                    if(i == 1 || i == aa || j == 0 || j == aa - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /* zadanie 3.10*/

            int silnia = 1, user3;
            Console.WriteLine("Podaj liczbe do obliczenia silni:");
            user3 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= user3; ++i)
            {
                silnia *= i;
            }
            Console.WriteLine("Silnia wynosi:{0}", silnia);

            /*zadanie 3.11*/
            int sum=0,count=0;
            while (sum < 100)
            {
                count++;
                sum += count;
            }
            Console.WriteLine("Aby przekroczyć 100, trzeba dodać {0} liczb", count);

            /*zadanie 3.12*/
            int user_number,sum2=0;
            do
            {
                Console.WriteLine("Podaj liczbe całkowitą różną od zera:");
                user_number = Convert.ToInt32(Console.ReadLine());
                if(user_number== 0)
                {
                    break;
                }
                else
                {
                    sum2 += user_number;
                }
            }
            while (true);
            Console.WriteLine("suma wprowadzonych liczb użytkownika wynosi:{0}", sum2);

            /* zadanie 3.13*/
            int n,w=0;
            Console.WriteLine("podaj liczbę do sumy szeregu:");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; ++i)
            {
                if(i%2 == 0)
                {
                    w -= i;
                }
                else{
                    w += i;
                }
            }
            Console.WriteLine("suma ciągu wynosi:{0}", w);

            /* zadanie 3.14*/
            int nnn;
            Console.WriteLine("Podaj liczbe do przedziału:");
            nnn = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=nnn;++i)
            {
                int summ = 0;
                for (int j=1;j< i; ++j)
                {
                    if (i % j == 0)
                    {
                        summ += j;
                    }
                }
                if (summ == i){
                    Console.WriteLine("Liczba:{0}", summ);
                }
            }

            /* zadnie 3.15*/
            for (int z_1 =0;z_1 <= 10; ++z_1)
            {
                for (int z_2 =0; z_2 <= 5; ++z_2)
                {
                    for (int z_3 =0; z_3 <= 2; ++z_3)
                    {
                        if(z_1 * 1 + z_2 * 2 + z_2*3 * 5 == 10)
                        {
                            Console.WriteLine("złotówki{0,5}  dwa złote:{1,5}   pięć złotych:{2,5}", z_1, z_2, z_3);
                        }
                    }
                }
            }


            Console.ReadKey();
            
        }
    }
}