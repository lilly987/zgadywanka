using System;
using System.Diagnostics;

namespace Gra_proceduralnie
{
    class Program
    {
        const string zaduzo = "ZA DUŻO";
        const string zamalo = "ZA MAŁO";
        const string trafiono = "TRAFIONO";
        static void Main(string[] args)
        {
            Console.WriteLine("Gra za dużo za mało");
            int a = wczytajLiczbe("Podaj dolny zakres losowania:  ");
            int b = wczytajLiczbe("Podaj górny zakres losowania:  ");
            int wylosowana = Losuj(a, b);
#if DEBUG

            Console.WriteLine(wylosowana);

#endif
            int licznik = 0;
            var stoper = new Stopwatch();
            stoper.Start();
            while (true)
            {
                //2.Człowiek proponuje
                licznik++; //licznik = licznik + 1;
                int propozycja = wczytajLiczbe("Podaj swoja propozycje lub X aby zakończyć: ");
                Console.WriteLine(ocena(wylosowana, propozycja));
                Console.WriteLine(wynik);
                if (wynik == "TRAFIONO");
                break;

                

            }
            stoper.Stop();
            Console.WriteLine($"liczba wyników = {licznik}");
            Console.WriteLine($"czas gry = {stoper.Elapsed}");
            Console.WriteLine("koniec gry");
        }

        //===================================================

        /// <summary>
        /// Losuje liczbe z podanego zakresu wlacznie
        /// </summary>
        /// <param name="min">dolne ograniczenie</param>
        /// <param name="max">gorne ograniczenie</param>
        /// <returns></returns>
        static int Losuj(int min = 1, int max = 100)
        {
            var min1 = Math.Min(min, max);
            var max1 = Math.Max(min, max);

            var rnd = new Random();
            var los = rnd.Next(min1, max1 + 1);
            return los;
        }

        static int wczytajLiczbe(string prompt = "")

        {
            bool poprawnie = false;
            int wynik = 0;

            do
            { 
            Console.Write(prompt);
            string wczytano = Console.ReadLine();
            if (wczytano == "x" || wczytano == "X")
                Environment.Exit(0);
            

            try
            {
                wynik = int.Parse(wczytano);
                    poprawnie = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("nie poprawny zapis liczby. Spróbuj jeszcze raz.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("przekroczony zakres");
            }
            catch (Exception)
            {
                Console.WriteLine("nieznany błąd");
            }
        }
            while(!poprawnie);
            return wynik;
        }


        static string ocena(int wylosowana, int propozycja);
        {
            if(wylosowana < propozycja)
            {
                return zaduzo;
            }
            else if(wylosowana > propozycja)
            {
                return zamalo;
            }
            else
            {
                return trafiono;
            }
        }
    }

}

