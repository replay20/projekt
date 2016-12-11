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
            Wycieczki EgiptKult = new Wycieczki();
            EgiptKult.nazwa = "Wycieczka kulturoznawcza po Egipcie";
            EgiptKult.kraj = "Egipt";
            EgiptKult.kontynent = "Afryka";
            EgiptKult.opis = "Wycieczka nastawiona na zwiedzanie najciekawszych miejsc w Egipcie. Planowane jest zwiedzanie: Piramid i Sfinksa w Gizie, Stolicy Egiptu – Kairu oraz starożytnej stolicy – Memfisu.";
            Wycieczki FiordyNorw = new Wycieczki();
            FiordyNorw.nazwa = "Norwegia - Fiordy";
            FiordyNorw.kraj = "Norwegia";
            FiordyNorw.kontynent = "Europa";
            FiordyNorw.opis = "Kraina nieziemskich widoków. Lazurowe wody najpiękniejszych norweskich fiordów widzianych z pokładu luksusowego statku. Pocztówkowe krajobrazy – wodospady, lodowce, ostre szczyty. Północny kraniec Europy – słynny Nordkapp. Dzikie skały Lofotów. Spotkanie z tajemniczymi trollami. Hanzeatyckie Bergen i urocze Stavanger.";
            Wycieczki ChinyKult = new Wycieczki();
            ChinyKult.nazwa = "Pekin i Szanghaj";
            ChinyKult.kraj = "Chiny";
            ChinyKult.kontynent = "Azja";
            ChinyKult.opis = "Wycieczka nastawiona na zwiedzanie najciekawszych miejsc w  Pekinie i Szanghaju, między innymi zwiedzanie Świątyni Nefrytowego Buddy, Ogrodów Yuyuan, Zakazanego Miasta oraz Placu Niebiańskiego Spokoju.";
            Wycieczki WlochyKult = new Wycieczki();
            WlochyKult.nazwa = "Malownicza Toskania i Rzym";
            WlochyKult.kraj = "Włochy";
            WlochyKult.kontynent = "Europa";
            WlochyKult.opis = "Wycieczka nastawiona na zwiedzanie najciekawszych miejsc w Toskanii i Rzymie, między innymi zwiedzanie starówki oraz katedry we Florencji, jednego z najpiękniejszych miast we Wloszech – Sieny, zwiedzanie Rzymu oraz Watykanu.";
            Wycieczki USAKult = new Wycieczki();
            USAKult.nazwa = "Wschodnie Wybrzeze USA i Kanada";
            USAKult.kraj = "USA i Kanada";
            USAKult.kontynent = "Ameryka Pln.";
            USAKult.opis = "Wycieczka nastawiona na zwiedzanie najciekawszych miejsc na Wschodnim Wybrzezu USA oraz Kanady, zwiedzanie miedzy innymi Wodospadu Niagara, Bostonu, Nowego Jorku, podziemnego miasta – Quebec oraz Ottawy.";
            Wycieczki WenezuelaKult = new Wycieczki();
            WenezuelaKult.nazwa = "Wenezuela i Archipelag Roques";
            WenezuelaKult.kraj = "Wenezuela";
            WenezuelaKult.kontynent = "Ameryka Pld.";
            WenezuelaKult.opis = "Piaszczyste wydmy i atol koralowy. Pięknie odrestaurowana zabytki kolonialne. Rejs łodzią po lagunie – domy na palach. Ośnieżone szczyty Andów i pustkowia páramos. Safari na sawannie. Cuda przyrody w kilku parkach narodowych. Najwyższy wodospad świata – Salto Ángel. Kraina kowbojów llanero i nocleg na rancho. Spływ łodziami po rzece Orinoko.";
            Wycieczki AlgieriaSport = new Wycieczki();
            AlgieriaSport.nazwa = "Miliony Ziaren Piasku";
            AlgieriaSport.kraj = "Algieria";
            AlgieriaSport.kontynent = "Afryka";
            AlgieriaSport.opis = "Wycieczka nastawiona na aktywne zwiedzanie najciekawszych miejsc w Algierii, miedzy innymi spotkanie z Tuaregami KelAzdżer – nomadami Pustyni, Płaskowyż Jabbaren – pieszy trekking oraz Trekking na wielbłądach.";
            Wycieczki JaponiaSport = new Wycieczki();
            JaponiaSport.nazwa = "Uśmiech Gejszy";
            JaponiaSport.kraj = "Japonia";
            JaponiaSport.kontynent = "Azja";
            JaponiaSport.opis = "Wycieczka nastawiona na aktywne zwiedzanie najciekawszych miejsc w Japonii, miedzy innymi zwiedzanie Tokio oraz Kioto, Imabari - wycieczka rowerowa na Shimanami Kaido. ";
            Wycieczki USASport = new Wycieczki();
            USASport.nazwa = "Magia Krajobrazów";
            USASport.kraj = "USA";
            USASport.kontynent = "Ameryka Płn.";
            USASport.opis = "Wyprawa po najpiękniejszych parkach narodowych USA. Zobaczysz wszystkie kultowe krajobrazy Stanów Zjednoczonych - monumentalne szczyty Yosemite, znaną z westernów Dolinę Pomników, niesamowite formacje skalne kanionu Bryce, księżycowe przestrzenie Doliny Śmierci, olbrzymie sekwoje i legendarny Wielki Kanion. Zawitasz również do znanych metropolii - Los Angeles, Las Vegas i San Francisco. ";
            Wycieczki PeruSport = new Wycieczki();
            PeruSport.nazwa = "Klasyka Peru";
            PeruSport.kraj = "Peru";
            PeruSport.kontynent = "Ameryka Płd.";
            PeruSport.opis = "Spędzisz niezapomniany dzień w ruinach Machu Picchu, zobaczysz słynne linie Nazca, kanion Colca i jezioro Titicaca. Popłyniesz na IslasBallestas przywitać się z pingwinami i poszalejesz na wydmach w Ica, przemierzysz klimatyczne uliczki Cuzco i spędzisz czas z Indianami na wyspie Taquila. ";
            Wycieczki HiszpaniaSport = new Wycieczki();
            HiszpaniaSport.nazwa = "Sierra Nevada – Andaluzja – Granada i Góry Betyckie";
            HiszpaniaSport.kraj = "Hiszpania";
            HiszpaniaSport.kontynent = "Europa";
            HiszpaniaSport.opis = "Andaluzja to najpiękniejszy region Hiszpanii - miasta czarują zabytkami z czasów, gdy mieszkali tu Arabowie, bliskość gorącej Afryki i ośnieżone szczyty Sierra Nevada zachwycają niezwykłością kontarstów. Kwitną migdałowce a lasy oliwne zachęcają zapachem i smakiem. Wieczorami w głowie szumi  flamenco!W programie połączono spektakularne wycieczki górskie, klimat hiszpańskich schronisk, nadmorskie kurorty, wędrówkę na 'koniec Europy' - Gibraltal i niezwykłe miasta hiszpańskiej Andaluzji: Kadyks, Granada, Sevilla, Cordoba, Ronda.";
            Wycieczki NowaZelandiaSport = new Wycieczki();
            NowaZelandiaSport.nazwa = "Drugi Koniec Świata";
            NowaZelandiaSport.kraj = "Nowa Zelandia";
            NowaZelandiaSport.kontynent = "Australia i Oceania";
            NowaZelandiaSport.opis = " Ten roadtrip zabierze Cię w podróż po obu wyspach Nowej Zelandii, od dzikich plaży północy do pięknych fiordów południa. Na trasie czekają unikalne krajobrazy i miejsca, z których słynie Nowa Zelandia: czarna plaża Piha Beach, Hobbiton, jaskinie Waitomo, gejzery w Rotorua, trekking w Tongariro, jezioro Tekapo, rejs po Milford Sound, lodowiec Franz Josef, skały naleśnikowe czy głazy narzutowe Moeraki. A to tylko wycinek przebogatego programu! ";
            Wycieczki MazuryRek = new Wycieczki();
            MazuryRek.nazwa = "Wycieczka po mazurach";
            MazuryRek.kraj = "Polska";
            MazuryRek.kontynent = "Europa";
            MazuryRek.opis = "Wycieczka rekreacyjna, podczas której zwiedzisz między innymi Olsztyn, Giżycko, Gierłozy, zobaczysz jak wygląda żeglarska stolica Polski – Mikołajki oraz odbędziesz rejs po jez. Niegocin, oraz wiele innych! ";
            Wycieczki WielkopolskaRek = new Wycieczki();
            WielkopolskaRek.nazwa = "Wielkopolska bez tajemnic";
            WielkopolskaRek.kraj = "Polska";
            WielkopolskaRek.kontynent = "Europa";
            WielkopolskaRek.opis = "Wycieczka rekreacyjna, podczas której zwiedzisz między innymi Licheń, Poznań, Gniezno, Kruszwice oraz odbędziesz rejs statkiem po jeziorze Gopło. ";
            Wycieczki WieliczkaRek = new Wycieczki();
            WieliczkaRek.nazwa = "Kopalnia soli w Wieliczce szlakiem górników.";
            WieliczkaRek.kraj = "Polska";
            WieliczkaRek.kontynent = "Europa";
            WieliczkaRek.opis = "Kopalnia Soli w Wieliczce to żelazny punkt zagranicznych wycieczek do Polski, 3-kilometrowy podziemny spacer, który odbyły miliony turystów z całego świata. Przed nami zabytkowe korytarze i komory powstałe z wydrążenia zalegających tu ogromnych brył solnych. ";

            Wycieczki KarpaczRek = new Wycieczki();
            KarpaczRek.nazwa = "Karpacz i okolice.";
            KarpaczRek.kraj = "Polska";
            KarpaczRek.kontynent = "Europa";
            KarpaczRek.opis = " Zamek Chojnik, Park Miniatur Zabytków Dolnego Śląska, Świątynia Wang i wodospad Podgórnej – to tylko niektóre z miejsc, które trzeba zobaczyć w Karkonoszach.";

            Wycieczki WarszawaRek = new Wycieczki();
            WarszawaRek.nazwa = "Najciekawsze miejsca w Warszawie.";
            WarszawaRek.kraj = "Polska";
            WarszawaRek.kontynent = "Europa";
            WarszawaRek.opis = " Nadwiślańskie plaże, Powiśle, Praga – jakie miejsca i atrakcje w Warszawie trzeba zobaczyć w pierwszej kolejności? Mimo że stolicę najczęściej kojarzymy z Pałacem Kultury i Nauki, trudno określić, gdzie naprawdę bije jej serce albo od razu ustalmy – tych miejsc jest wiele, między innymi Muzeum Powstania Warszawskiego, Centrum Nauki Kopernik, Multimedialny Park Fontann i wiele innych.";

            Wycieczki LodzRek = new Wycieczki();
            LodzRek.nazwa = "Łódź: Atrakcje fabrycznego miasta.";
            LodzRek.kraj = "Polska";
            LodzRek.kontynent = "Europa";
            LodzRek.opis = "Łódź przeistacza się z typowo robotniczego ośrodka w miasto kultury i inspiracji. Powstają nowe muzea, galerie sztuki, wielka rewitalizacja miasta. Przykładem zachodzących zmian jest rozkwitające centrum Manufaktura i odbywający się w Łodzi coroczny festiwal designu. Odwiedzimy między innymi Manufakturę, Muzeum Fabryki oraz Muzeum Sztuki Współczesnej! ";

            bool i,j;
            string odp;
            i = true;
            j = true;
            Console.WriteLine("Witaj w programie, ktory podpowie ci, gdzie mozesz wybrac sie na wypoczynek (moze byc kilka miejsc).\n");
            Console.WriteLine("Odpowiedz na kilka pytan, ktore zada Ci program. Zeby odpowiedziec na pytania wpisz liczbe, ktora symbolizuje odpowiedz.");
            do
            {
                Console.WriteLine("Co preferujesz?\n1) Relaks\n2) Zwiedzanie\n3 Uprawianie Sportu\n4) Bez znaczenia");
                odp = (Console.ReadLine());
                if (odp == "1")
                {
                    Krakow.ilosc_punktow = Krakow.ilosc_punktow - 1;
                    OsrodekWarch.ilosc_punktow = OsrodekWarch.ilosc_punktow + 1;
                    EgiptKult.ilosc_punktow = EgiptKult.ilosc_punktow - 1;
                    ChinyKult.ilosc_punktow = ChinyKult.ilosc_punktow - 1;
                    WlochyKult.ilosc_punktow = WlochyKult.ilosc_punktow - 1;
                    USAKult.ilosc_punktow = USAKult.ilosc_punktow - 1;
                    WenezuelaKult.ilosc_punktow = WenezuelaKult.ilosc_punktow - 1;
                    FiordyNorw.ilosc_punktow = FiordyNorw.ilosc_punktow + 1;
                    MazuryRek.ilosc_punktow = MazuryRek.ilosc_punktow + 1;
                    WielkopolskaRek.ilosc_punktow = WielkopolskaRek.ilosc_punktow + 1;
                    WieliczkaRek.ilosc_punktow = WieliczkaRek.ilosc_punktow + 1;
                    KarpaczRek.ilosc_punktow = KarpaczRek.ilosc_punktow + 1;
                    WarszawaRek.ilosc_punktow = WarszawaRek.ilosc_punktow + 1;
                    LodzRek.ilosc_punktow = LodzRek.ilosc_punktow + 1;
                
                do
                {
                    Console.WriteLine("Czy chcesz jechać w góry czy na plażę?\n1) W gory\n2) Na plaze\n3) Bez znaczenia");
                    odp = (Console.ReadLine());
                    if (odp == "1")
                    {
                        FiordyNorw.ilosc_punktow = FiordyNorw.ilosc_punktow + 1;
                        WieliczkaRek.ilosc_punktow = WieliczkaRek.ilosc_punktow + 1;
                        KarpaczRek.ilosc_punktow = KarpaczRek.ilosc_punktow + 1;

                        j = false;
                    }

                    if (odp == "2")
                    {

                        OsrodekWarch.ilosc_punktow = OsrodekWarch.ilosc_punktow + 1;

                        j = false;
                    }
                    else
                        if (odp == "3")
                        j = false;

                }
                while (j == true);
                j = true;
                }
                i = false;

                if (odp == "2")
                {
                    Krakow.ilosc_punktow = Krakow.ilosc_punktow + 1;
                    OsrodekWarch.ilosc_punktow = OsrodekWarch.ilosc_punktow - 1;
                    EgiptKult.ilosc_punktow = EgiptKult.ilosc_punktow + 1;
                    ChinyKult.ilosc_punktow = ChinyKult.ilosc_punktow + 1;
                    WlochyKult.ilosc_punktow = WlochyKult.ilosc_punktow + 1;
                    USAKult.ilosc_punktow = USAKult.ilosc_punktow + 1;
                    WenezuelaKult.ilosc_punktow = WenezuelaKult.ilosc_punktow + 1;
                    FiordyNorw.ilosc_punktow = FiordyNorw.ilosc_punktow - 1;
                    MazuryRek.ilosc_punktow = MazuryRek.ilosc_punktow - 1;
                    WielkopolskaRek.ilosc_punktow = WielkopolskaRek.ilosc_punktow - 1;
                    WieliczkaRek.ilosc_punktow = WieliczkaRek.ilosc_punktow - 1;
                    KarpaczRek.ilosc_punktow = KarpaczRek.ilosc_punktow - 1;
                    WarszawaRek.ilosc_punktow = WarszawaRek.ilosc_punktow - 1;
                    LodzRek.ilosc_punktow = LodzRek.ilosc_punktow - 1;
                    i = false;
                }
                if (odp == "3")
                {

                    AlgieriaSport.ilosc_punktow = AlgieriaSport.ilosc_punktow + 1;
                    JaponiaSport.ilosc_punktow = JaponiaSport.ilosc_punktow + 1;
                    USASport.ilosc_punktow = USASport.ilosc_punktow + 1;
                    AlgieriaSport.ilosc_punktow = AlgieriaSport.ilosc_punktow + 1;
                    PeruSport.ilosc_punktow = PeruSport.ilosc_punktow + 1;
                    HiszpaniaSport.ilosc_punktow = HiszpaniaSport.ilosc_punktow + 1;
                    NowaZelandiaSport.ilosc_punktow = NowaZelandiaSport.ilosc_punktow + 1;
                    i = false;
                }
                else
                    if (odp == "4")
                    i = false;
            } while (i == true);


            i = true;
            do
            {
                Console.WriteLine("Wycieczka w kraju czy za granica?\n1) W kraju\n2) Za granica\n3) Bez znaczenia");
                odp = (Console.ReadLine());
                if (odp == "1")
                {
                    Krakow.ilosc_punktow = Krakow.ilosc_punktow + 1;
                    OsrodekWarch.ilosc_punktow = OsrodekWarch.ilosc_punktow + 1;
                    EgiptKult.ilosc_punktow = EgiptKult.ilosc_punktow - 1;
                    ChinyKult.ilosc_punktow = ChinyKult.ilosc_punktow - 1;
                    WlochyKult.ilosc_punktow = WlochyKult.ilosc_punktow - 1;
                    USAKult.ilosc_punktow = USAKult.ilosc_punktow - 1;
                    WenezuelaKult.ilosc_punktow = WenezuelaKult.ilosc_punktow - 1;
                    FiordyNorw.ilosc_punktow = FiordyNorw.ilosc_punktow - 1;
                    MazuryRek.ilosc_punktow = MazuryRek.ilosc_punktow + 1;
                    WielkopolskaRek.ilosc_punktow = WielkopolskaRek.ilosc_punktow + 1;
                    WieliczkaRek.ilosc_punktow = WieliczkaRek.ilosc_punktow + 1;
                    KarpaczRek.ilosc_punktow = KarpaczRek.ilosc_punktow + 1;
                    WarszawaRek.ilosc_punktow = WarszawaRek.ilosc_punktow + 1;
                    LodzRek.ilosc_punktow = LodzRek.ilosc_punktow + 1;
                    AlgieriaSport.ilosc_punktow = AlgieriaSport.ilosc_punktow - 1;
                    JaponiaSport.ilosc_punktow = JaponiaSport.ilosc_punktow - 1;
                    USASport.ilosc_punktow = USASport.ilosc_punktow - 1;
                    PeruSport.ilosc_punktow = PeruSport.ilosc_punktow - 1;
                    HiszpaniaSport.ilosc_punktow = HiszpaniaSport.ilosc_punktow - 1;
                    NowaZelandiaSport.ilosc_punktow = NowaZelandiaSport.ilosc_punktow - 1;
                    i = false;
                }
                if (odp == "2")
                {
                    Krakow.ilosc_punktow = Krakow.ilosc_punktow - 1;
                    OsrodekWarch.ilosc_punktow = OsrodekWarch.ilosc_punktow - 1;
                    EgiptKult.ilosc_punktow = EgiptKult.ilosc_punktow + 1;
                    ChinyKult.ilosc_punktow = ChinyKult.ilosc_punktow + 1;
                    WlochyKult.ilosc_punktow = WlochyKult.ilosc_punktow + 1;
                    USAKult.ilosc_punktow = USAKult.ilosc_punktow + 1;
                    WenezuelaKult.ilosc_punktow = WenezuelaKult.ilosc_punktow + 1;
                    FiordyNorw.ilosc_punktow = FiordyNorw.ilosc_punktow + 1;
                    AlgieriaSport.ilosc_punktow = AlgieriaSport.ilosc_punktow + 1;
                    JaponiaSport.ilosc_punktow = JaponiaSport.ilosc_punktow + 1;
                    USASport.ilosc_punktow = USASport.ilosc_punktow + 1;
                    PeruSport.ilosc_punktow = PeruSport.ilosc_punktow + 1;
                    HiszpaniaSport.ilosc_punktow = HiszpaniaSport.ilosc_punktow + 1;
                    NowaZelandiaSport.ilosc_punktow = NowaZelandiaSport.ilosc_punktow + 1;
                    MazuryRek.ilosc_punktow = MazuryRek.ilosc_punktow - 1;
                    WielkopolskaRek.ilosc_punktow = WielkopolskaRek.ilosc_punktow - 1;
                    WieliczkaRek.ilosc_punktow = WieliczkaRek.ilosc_punktow - 1;
                    KarpaczRek.ilosc_punktow = KarpaczRek.ilosc_punktow - 1;
                    WarszawaRek.ilosc_punktow = WarszawaRek.ilosc_punktow - 1;
                    LodzRek.ilosc_punktow = LodzRek.ilosc_punktow - 1;
                    i = false;
                    do
                    {
                        Console.WriteLine("Jaki kontynent cie interesuje?\n1) Europa\n2) Ameryka pln\n3) Ameryka pld\n4) Afryka\n5) Azja\n6) Bez znaczenia");
                        odp = (Console.ReadLine());
                        if (odp == "1")
                        {
                            WlochyKult.ilosc_punktow = WlochyKult.ilosc_punktow + 1;
                            FiordyNorw.ilosc_punktow = FiordyNorw.ilosc_punktow + 1;
                            HiszpaniaSport.ilosc_punktow = HiszpaniaSport.ilosc_punktow + 1;
                            j = false;
                        }
                        if (odp == "2")
                        {
                            USAKult.ilosc_punktow = USAKult.ilosc_punktow + 1;
                            USASport.ilosc_punktow = USASport.ilosc_punktow + 1;
                            j = false;
                        }
                        if (odp == "3")
                        {
                            WenezuelaKult.ilosc_punktow = WenezuelaKult.ilosc_punktow + 1;
                            PeruSport.ilosc_punktow = PeruSport.ilosc_punktow + 1;
                            j = false;
                        }
                        if (odp == "4")
                        {
                            EgiptKult.ilosc_punktow = EgiptKult.ilosc_punktow + 1;
                            AlgieriaSport.ilosc_punktow = AlgieriaSport.ilosc_punktow + 1;
                            j = false;
                        }
                        if (odp == "5")
                        {
                            ChinyKult.ilosc_punktow = ChinyKult.ilosc_punktow + 1;
                            JaponiaSport.ilosc_punktow = JaponiaSport.ilosc_punktow + 1;
                            j = false;
                        }
                        else
                            if (odp == "6")
                            j = false;
                    }
                    while (j == true);
                    j = true;
                }
            
            
                else
                    if (odp == "3")
                    i = false;
            }
            while (i == true);
            i = true;
            do
            {
                Console.WriteLine("Wolisz wysokie, niskie czy umiarkowane temperatury?\n1) Wysokie\n2) Umiarkowane\n3) Niskie\n4) Bez znaczenia");
                odp = (Console.ReadLine());
                if (odp == "1")
                {
                    EgiptKult.ilosc_punktow = EgiptKult.ilosc_punktow + 1;
                    WlochyKult.ilosc_punktow = WlochyKult.ilosc_punktow + 1;
                    WenezuelaKult.ilosc_punktow = WenezuelaKult.ilosc_punktow + 1;
                    FiordyNorw.ilosc_punktow = FiordyNorw.ilosc_punktow - 1;
                    AlgieriaSport.ilosc_punktow = AlgieriaSport.ilosc_punktow + 1;
                    PeruSport.ilosc_punktow = PeruSport.ilosc_punktow + 1;
                    HiszpaniaSport.ilosc_punktow = HiszpaniaSport.ilosc_punktow + 1;
                    NowaZelandiaSport.ilosc_punktow = NowaZelandiaSport.ilosc_punktow + 1;
                    i = false;
                }

            }
            while (i == true);
            i = true;
        }

    }
}
