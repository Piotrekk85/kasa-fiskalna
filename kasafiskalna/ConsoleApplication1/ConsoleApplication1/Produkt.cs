using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Produkt
    {
        private string nazwa;
        private int cenaJednostkowa;
        private int ilosc;

        public Produkt(string nazwa, int cenaJednostkowa, int ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }

    }
}
