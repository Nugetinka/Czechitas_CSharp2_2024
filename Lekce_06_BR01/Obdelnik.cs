namespace Lekce_06_BR01
{
    public class Obdelnik
    {
        public double Sirka { get; private set; }
        public double Vyska { get; private set; }
        public double Obsah 
        { 
            get { return Sirka * Vyska; }
        }

        public double Obvod
        {
            get { return 2 * (Sirka + Vyska); }
        }

        public Obdelnik(double sirka, double vyska)
        {
            if (sirka <= 0)
            {
                throw new ArgumentException("Šířka musí být větší než 0.");
            }

            if (vyska <= 0)
            {
                throw new ArgumentException("Výška musí být větší než 0.");
            }

            Sirka = sirka;
            Vyska = vyska;
        }

        public Obdelnik(double strana) : this(strana, strana)
        {
            // čtverec
        }

        public void VypisParametryObdelniku()
        {
            Console.WriteLine($"Šířka: {Sirka}, Výška: {Vyska}");
        }

        public void ZvetsiParametryObdelniku(double pridanaSirka, double pridanaVyska)
        {
            Sirka += pridanaSirka;
            Vyska += pridanaVyska;
        }
    }
}
