using System.Text.RegularExpressions;

namespace Uhlovodiky
{
    public interface IUhlovodik
    {
        public string Pripona { get; }
        public string NapovedaKNazvu { get; }
        public string NapovedaKeVzorci { get; }
        public Regex Vzor { get; }

        string VzorecZNazvu(string nazev);
        string NazevZeVzorce(string vzorec);
    }
}
