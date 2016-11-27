using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Produkt: ICloneable
    {
        private string nazwa;
        private double cenaJednostkowa; //warto zmienic typ na double bo cena może nie byc calkwoita
        private double ilosc; // tu jw

        public Produkt(string nazwa, double cenaJednostkowa, double ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }

        //dla zupełnej poprawności warto dodać konstruktor domyślny
        public Produkt() { }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public string PodajOpis()
        {
            string opis = "Nazwa: " +nazwa + ", Cena jednostkowa: "+cenaJednostkowa + ", Ilość :" +ilosc+", Łączna cena: " +PodajSume();
            return opis;
        }

        public void WypiszInfo()
        {
            Console.WriteLine(PodajOpis());
        }

        public double PodajSume()
        {
            return cenaJednostkowa * ilosc;
        }

    }
}
