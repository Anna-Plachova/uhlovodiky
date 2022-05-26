using System.Text.RegularExpressions;

namespace Uhlovodiky
{
    internal class Alkan : IUhlovodik
    {
        public string Pripona { get => "an"; }
        public string NapovedaKNazvu { get => "Nejde o název alkanu. Název alkanu je tvořen základem (podle počtu uhlíků) a příponou -an"; }
        public string NapovedaKeVzorci { get => "Nejde o vzorec alkanu. Vzorec alkanu je CxHy (x = počet atomů uhlíku, y = počet atomů vodíku.). Musí platit, že y = 2.x + 2"; }
        public Regex Vzor { get => new Regex("([C|c])(\\d*)([H|h])(\\d+)"); }

        public string NazevZeVzorce(string vzorec)
        {
            var shoda = Vzor.Match(vzorec);
            if (shoda.Success == false)
                throw new Exception(NapovedaKeVzorci);

            var pocetUhliku = 1;
            if(string.IsNullOrEmpty(shoda.Groups[2].Value) == false)
                pocetUhliku = int.Parse(shoda.Groups[2].Value);

            var pocetVodiku = int.Parse(shoda.Groups[4].Value);

            var spravnyPocetVodiku = (pocetUhliku * 2) + 2;
            if(pocetVodiku != spravnyPocetVodiku)
                throw new Exception(NapovedaKeVzorci);

            return $"{Zaklady.SlovnikZakladu[pocetUhliku].ZakladNazvu}{Pripona}";
        }

        public string VzorecZNazvu(string nazev)
        {
            if (nazev.EndsWith(Pripona, StringComparison.OrdinalIgnoreCase) == false)
                throw new Exception(NapovedaKNazvu);

            var zakladNazvu = nazev.Substring(0, nazev.Length - Pripona.Length);

            var zaklad = Zaklady.SlovnikZakladu.Values.SingleOrDefault(zaklad => zaklad.ZakladNazvu.Equals(zakladNazvu, StringComparison.OrdinalIgnoreCase));
            if(zaklad == null)
                throw new Exception(NapovedaKNazvu);

            var vzorec = $"C{zaklad.PocetUhliku}H{zaklad.PocetUhliku * 2 + 2}";
            return vzorec;
        }
    }
}
