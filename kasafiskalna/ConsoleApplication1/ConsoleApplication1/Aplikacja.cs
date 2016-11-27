using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Aplikacja
    {
        private char klawisz;
        Koszyk koszyk1 = new Koszyk();

        public void WczytajKlawisz()
        {
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

        //ta metoda nie potrzebuje parametru klawisz, jest to pole w klasie
        public void WykonajDzialanie()
        {
            while (klawisz != 'E' && klawisz != 'e')
            {
                if (klawisz == 'P' || klawisz == 'p')
                {
                    //wyswietlenie i pobranie informacji o nazwie produktu
                    Console.WriteLine("Podaj nazwę produktu");
                    string nazwa = Console.ReadLine();
                    //wyswietlenie i pobranie informacji o cenie jednostrkowej produktu
                    Console.WriteLine("Podaj cene jednostkową produktu");
                    double cena = Convert.ToDouble(Console.ReadLine());
                    //wyswietlenie i pobranie informacji o cenie jednostrkowej produktu
                    Console.WriteLine("Podaj ilość produktu");
                    double ilosc = Convert.ToDouble(Console.ReadLine());
                    //dodanie produktu na listę zakupy
                    koszyk1.DodajProdukt(nazwa, cena, ilosc);
                    //potwierdzenie
                    Console.WriteLine("Dodano produkt do koszyka.");

                }
                if (klawisz == 'K' || klawisz == 'k')
                {
                    koszyk1.SkopiujProdukt();
                    
                }
                if (klawisz == 'Z' || klawisz == 'z')
                {
                    koszyk1.WyswietlProdukty();
                }
                if (klawisz == 'S' || klawisz == 's')
                {
                    Console.WriteLine("Suma zakupów w koszyku: {0}",koszyk1.ObliczSume());
                }
                if (klawisz == 'X' || klawisz == 'x')
                {
                    Console.WriteLine("Podaj numer pozycji w koszyku do usuniecie");
                    int nr = Convert.ToInt32(Console.ReadLine());
                    koszyk1.UsunPozycje(nr);

                }
                if (klawisz == 'W' || klawisz == 'w')
                {
                    string nazwaPliku = System.DateTime.Now.Day.ToString() + System.DateTime.Now.Month.ToString() + System.DateTime.Now.Year.ToString() + System.DateTime.Now.Hour.ToString() + System.DateTime.Now.Minute.ToString() + System.DateTime.Now.Second.ToString() +".txt";
                    using(StreamWriter sw = new StreamWriter(nazwaPliku))
                    {
                        sw.Write(koszyk1.OpiszKoszyk());
                    }
                    koszyk1.Wyczysc();
                    


                }
                if (klawisz == 'N')
                {
                    koszyk1.Wyczysc();
                }
                
                WczytajKlawisz();
               
            }
        }
    }
}
