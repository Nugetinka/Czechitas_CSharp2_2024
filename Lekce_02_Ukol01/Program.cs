namespace Lekce_02_Ukol01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Zadej první číslo: ");
                string vstup1 = Console.ReadLine();
                if (!double.TryParse(vstup1, out double cislo1))
                {
                    throw new ArgumentException($"První číslo:{vstup1} není platné.");
                }

                Console.WriteLine("Zadej druhé číslo: ");
                string vstup2 = Console.ReadLine();
                if (!double.TryParse(vstup2, out double cislo2))
                {
                    throw new ArgumentException($"Druhé číslo:{vstup2} není platné.");
                }

                double sum = cislo1 + cislo2;

                Console.WriteLine($"Součet čísel: {cislo1} + {cislo2} = {sum}");
            }
            catch (Exception)
            {
                Console.WriteLine("Zadaný vstup je neplatný.");
            }
        }
    }
}

// Napište program, který se zeptá na dvě čísla a zobrazí jejich součet.