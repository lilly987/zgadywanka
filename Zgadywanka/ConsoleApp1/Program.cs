﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra za dużo za mało");

            //1.Komputer losuje
            #region losowanie
            var los = new Random(); // tworze obiekt typu random
            int wylosowana = los.Next(1,101);

#if DEBUG

            Console.WriteLine(wylosowana);

#endif
            Console.WriteLine("wylosowalem liczbe od 1 do 100. \nOdgadnij ja!");
            #endregion

            bool odgadniete = false;
            //dopóki nie odgadniesz
            while (! odgadniete)
            {

            //2.Człowiek proponuje
            Console.Write("Podaj swoja propozycje: ");
            int propozycja = int.Parse(Console.ReadLine());

            //3.Komp ocenia
            if(propozycja < wylosowana)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("za mało!");
                Console.ResetColor();
            }
            else if( propozycja > wylosowana)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Za dużo!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("trafiono");
                Console.ResetColor();
                    odgadniete = true;
            }

                Console.WriteLine("koniec GRY");
            }
        }
    }
}
