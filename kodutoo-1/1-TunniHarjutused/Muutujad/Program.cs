namespace kodutoo_1.Muutujad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Muutujad harjutus 1 - andmed ja lemmiktoidud

            Console.WriteLine("=== Harjutus 1 ===");

            string nimi = "Malle";
            int vanus = 45;
            int sunniaasta = 1978;
            string toidud = "pasta, pitsa, takod";

            Console.WriteLine("Minu nimi on " + nimi + ", olen " + vanus + " aastat vana, sündisin aastal " + sunniaasta + " ja minu lemmiktoidud on: " + toidud);

            Console.WriteLine();

            // Muutujad harjutus 2 - koolipäeva iseloomustus

            Console.WriteLine("=== Harjutus 2 ===");

            string lemmikAine = "Programmeerimine";
            int tundideArv = 4;
            string tuju = "hea";

            Console.WriteLine("Käisin koolis " + tundideArv + " tundi, mu lemmik õppeaine on " + lemmikAine + " ja tuju on " + tuju);
            Console.WriteLine();

            // Muutujad harjutus 3 - Päike & maa

            Console.WriteLine("=== Harjutus 3 ===");

            const int paike = 1392700;
            const int maa = 365;
            const int valgus = 299792;

            Console.WriteLine("Päikese läbimõõt: " + paike + " km");
            Console.WriteLine("Maa tiirlemisaeg ümber Päikese: " + maa + " päeva");
            Console.WriteLine("Valguse kiirus: " + valgus + " km/s");

        }

    }
}
