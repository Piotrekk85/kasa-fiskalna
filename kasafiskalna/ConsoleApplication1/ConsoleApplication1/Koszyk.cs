using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ten plik jest źle poformatowany, nie korzysta z domyślnego formatowania z VS
namespace ConsoleApplication1
{
    class Koszyk
    {
        private List<Produkt> zakupy;
        public Koszyk()
        {
           zakupy = new List<Produkt>();
        }
        
        public void DodajProdukt(string nazwa, double cenaJednostkowa, double ilosc)  //metody nazywam stosując notacje DwaWyrazy(), metodę lepiej zrobić z parametrami, zmienamy typy na double jak w klasie Produkt
        {
            zakupy.Add(new Produkt(nazwa, cenaJednostkowa, ilosc));
        }

        
        
        public void WyswietlProdukty()
        {
            if (zakupy.Count >0)
            {
                foreach (var element in zakupy)
                {
                    element.WypiszInfo();
                }
            }
            else
            {
                Console.WriteLine("Koszyk pusty");
            }
            

        }

        public void SkopiujProdukt()
        {
            if (zakupy.Count > 0)
            {
                Produkt ostatni = (Produkt)zakupy[zakupy.Count - 1].Clone();
                zakupy.Add(ostatni);
                Console.WriteLine("Skopiowano.");
            }
            else
            {
                Console.WriteLine("Pusty koszyk. Dodaj najpierw coś na koszyk przed skopiowaniem");
            }
        }

        public double ObliczSume()
        {
            double sumaKoszyka=0;
            for (int i=0;i<zakupy.Count;i++)
            {
                sumaKoszyka += zakupy[i].PodajSume();
            }
            return sumaKoszyka;
        }

        public void UsunPozycje(int pozycja)
        {
            if ( pozycja >=0 && pozycja <zakupy.Count)
            {
                zakupy.RemoveAt(pozycja);
                Console.WriteLine("Pozycja usunięta.");
            }
            else
            {
                Console.WriteLine("wprowadzony numer jest spoza zakresu");
            }
                
        }

        public string OpiszKoszyk()
        {
            string opisK = "Paragon";
            foreach(var element in zakupy)
            {
                opisK += Environment.NewLine +element.PodajOpis();
            }
            opisK += Environment.NewLine + "Suma: " + ObliczSume();
            return opisK;


        }

        public void Wyczysc()
        {
            zakupy.Clear();
        }
    }

}
