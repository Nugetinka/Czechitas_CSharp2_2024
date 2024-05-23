namespace Lekce_06_BR01
{
    internal class Obdelnik
    {
        public double Sirka;
        public double Vyska;

        public Obdelnik(double sirka, double vyska)
        {
            if (sirka <= 0)
            {
                throw new ArgumentException("Šířka musí být větší než nula");
            }

            if (vyska <= 0)
            {
                throw new ArgumentException("Výška musí být větší než nula");
            }

            Sirka = sirka;
            Vyska = vyska;
        }

        public Obdelnik(double strana) : this(strana, strana)
        { 
            // ctverec
        }

        public void VypisParametryObdelniku()
        {
            Console.WriteLine($"Šířka: {Sirka}, Výška: {Vyska}");
        }
    }
}
