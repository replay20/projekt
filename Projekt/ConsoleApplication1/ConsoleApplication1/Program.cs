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
            Wycieczki Krakow = new Wycieczki();
            Krakow.nazwa = "Stare miasto Krakow";
            Krakow.kraj = "Polska";
            Krakow.kontynent = "Europa";
            Krakow.opis = "Wycieczka nastawiona na zwiedzanie najciekawszych zabytkow w Krakowie. Planowane jest zwiedzanie: Kosciola Mariackiego, Zamku Wawelskiego, rynku i wiele innych.";
            Wycieczki OsrodekWarch = new Wycieczki();
            OsrodekWarch.nazwa = "Osrodek Wypoczynkowy 'Warchaly' ";
            OsrodekWarch.kraj = "Polska";
            OsrodekWarch.kontynent = "Europa";
            OsrodekWarch.opis = "Ekskluzywna wycieczka, ktorej celem jest zwyczajne odprezenie sie. Zakladany jest nocleg w czterogwiazdkowym hotelu, ktory znajduje sie nad jeziorem Narty.";
        }
    }
}
