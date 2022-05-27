namespace Uhlovodiky
{
    public static class Zaklady
    {
        public static Dictionary<int, Zaklad> SlovnikZakladu = new()
        {
            { 1, new Zaklad("meth", 1) },
            { 2, new Zaklad("eth", 2) },
            { 3, new Zaklad("prop", 3) },
            { 4, new Zaklad("but", 4) },
            { 5, new Zaklad("pent", 5) },
            { 6, new Zaklad("hex", 6) },
            { 7, new Zaklad("hept", 7) },
            { 8, new Zaklad("okt", 8) },
            { 9, new Zaklad("non", 9) },
            { 10, new Zaklad("dek", 10) }
        };
    }
}
