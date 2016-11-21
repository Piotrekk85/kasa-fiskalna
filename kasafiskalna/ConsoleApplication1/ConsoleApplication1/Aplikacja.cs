using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Aplikacja
    {
        private char klawisz;
        public void WczytajKlawisz()
        {
            Console.WriteLine("Dzień dobry!");
            Console.WriteLine("Co chcesz zrobić? Naciśnij odpowiedni klawisz.");
            Console.WriteLine("Legenda:");
            Console.WriteLine("P - dodaj produkt do koszyka");
            Console.WriteLine("K - skopiuj ostatnio wprowadzony produkt");
            Console.WriteLine("Z - pokaz zawartosc koszyka");
            Console.WriteLine("S - pokaz sume do zaplaty");
            Console.WriteLine("X - skasuj produkt z listy (musisz znac wczesniej numer na liscie)");
            Console.WriteLine("W - wydrukuj paragon");
            Console.WriteLine("N - dodaj nowy koszyk");
            Console.WriteLine("E - zakoncz dzialanie programu");
            klawisz = Convert.ToChar(Console.ReadLine());
        }
        public void WykonajDzialanie(char klawisz)
        {
            if (klawisz=='P')
            {
              Koszyk koszyk1 = new Koszyk();
              koszyk1.Dodajprodukt();

            }
            if (klawisz == 'K')
            {

            }
            if (klawisz=='Z')
            {

            }
            if (klawisz == 'S')
            {

            }
            if (klawisz == 'X')
            {

            }
            if (klawisz == 'W')
            {

            }
            if (klawisz == 'N')
            {

            }
            if (klawisz == 'E')
            {
                return;
            }
            if (klawisz == 'Z')
            {

            }
        }
    }
}
