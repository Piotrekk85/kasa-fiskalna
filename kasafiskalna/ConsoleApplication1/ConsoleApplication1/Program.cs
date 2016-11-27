using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dzień dobry!");
            Aplikacja nowe = new Aplikacja();
            nowe.WczytajKlawisz();
            nowe.WykonajDzialanie();
            Console.WriteLine("Do widzenia!");
            Console.ReadKey();

        }
    }
}
