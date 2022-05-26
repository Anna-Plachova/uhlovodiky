namespace Uhlovodiky
{
    internal class Zaklad
    {
        public Zaklad(string zakladNazvu, int pocetUhliku)
        {
            ZakladNazvu = zakladNazvu;
            PocetUhliku = pocetUhliku;
        }

        public string ZakladNazvu { get; set; }
        public int PocetUhliku { get; set; }
    }
}
