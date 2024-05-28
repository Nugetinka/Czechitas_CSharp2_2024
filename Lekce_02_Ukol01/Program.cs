namespace Lekce_02_Ukol01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulacka kalkulacka = new Kalkulacka();

            Console.Write("Zadej první číslo: ");
            double cislo1 = kalkulacka.NactiDesetinneCisloZKonzole();

            Console.Write("Zadej druhé číslo: ");
            double cislo2 = kalkulacka.NactiDesetinneCisloZKonzole();

            double vysledek = kalkulacka.Secti(cislo1, cislo2);

            Console.WriteLine($"Součet čísel: {cislo1} + {cislo2} = {vysledek}");
        }
    }
}

// Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.