namespace Lekce_02_Ukol02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej počet hvězdiček: ");
            string vstup = Console.ReadLine();
            bool jeVstupPlatny = int.TryParse(vstup, out int pocetHvezdicek);

            for (int i = 0; i < pocetHvezdicek; i++)
            {
                Console.Write("*");
            }

            try
            {
                if (pocetHvezdicek < 0)
                {
                    throw new ArgumentOutOfRangeException("Počet hvězdiček nesmí být záporný.");
                }

                if (!jeVstupPlatny)
                {
                    throw new FormatException("Musí být zadáno celé číslo.");
                }
            }
            catch (Exception exception) when (exception is FormatException or ArgumentOutOfRangeException)
            {
                Console.WriteLine($"Došlo k výjimce: {exception.Message}");
            }
        }
    }
}

// Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.
