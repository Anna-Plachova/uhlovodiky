using System.Text.RegularExpressions;

namespace Uhlovodiky
{
    public class Alken : IUhlovodik
    {
        public string Pripona { get => "en"; }
        public string NapovedaKNazvu { get => "Nejde o název alkenu. Název alkenu je tvořen základem (podle počtu uhlíků, počet uhlíků musí být vyšší než 1) a příponou -en"; }
        public string NapovedaKeVzorci { get => "Nejde o vzorec alkenu. Vzorec alkenu je CxHy (x = počet atomů uhlíku, y = počet atomů vodíku.). Musí platit, že y = 2.x a zároveň x > 1"; }
        public Regex Vzor { get => new Regex("([C|c])(\\d+)([H|h])(\\d+)"); }

        public string NazevZeVzorce(string vzorec)
        {
            var shoda = Vzor.Match(vzorec);
            if (shoda.Success == false)
                throw new Exception(NapovedaKeVzorci);

            var pocetUhliku = int.Parse(shoda.Groups[2].Value);

            if (pocetUhliku < 2)
                throw new Exception(NapovedaKeVzorci);

            var pocetVodiku = int.Parse(shoda.Groups[4].Value);

            var spravnyPocetVodiku = (pocetUhliku * 2);
            if(pocetVodiku != spravnyPocetVodiku)
                throw new Exception(NapovedaKeVzorci);

            var zaklad = Zaklady.SlovnikZakladu.Single(zaklad => zaklad.PocetUhliku.Equals(pocetUhliku));
            return $"{zaklad.ZakladNazvu}{Pripona}";
        }

        public string VzorecZNazvu(string nazev)
        {
            if (nazev.EndsWith(Pripona, StringComparison.OrdinalIgnoreCase) == false)
                throw new Exception(NapovedaKNazvu);

            var zakladNazvu = nazev.Substring(0, nazev.Length - Pripona.Length);

            var zaklad = Zaklady.SlovnikZakladu.SingleOrDefault(zaklad => zaklad.ZakladNazvu.Equals(zakladNazvu, StringComparison.OrdinalIgnoreCase));
            if(zaklad == null || zaklad.PocetUhliku == 1)
                throw new Exception(NapovedaKNazvu);

            var vzorec = $"C{zaklad.PocetUhliku}H{zaklad.PocetUhliku * 2}";
            return vzorec;
        }
    }
}
