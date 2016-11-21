using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Koszyk
    {
       private List<Produkt> zakupy;
        public Koszyk()
       {
           zakupy = new List<Produkt>();
       }
       public void Dodajprodukt()
        {
           string nazwa;
           int cenaJednostkowa;
           int ilosc;
           nazwa = Convert.ToString(Console.ReadLine());
           cenaJednostkowa = Convert.ToInt32(Console.ReadLine());
           ilosc = Convert.ToInt32(Console.ReadLine());
           zakupy.Add(new Produkt(nazwa, cenaJednostkowa, ilosc));
        }
        public void WyswietlProdukt()
       {

       }
    }

}
