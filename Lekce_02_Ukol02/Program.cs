namespace Lekce_02_Ukol02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej počet hvězdiček: ");
            string vstup = Console.ReadLine();

            try
            {
                int pocetHvezdicek = int.Parse(vstup);

                if (pocetHvezdicek < 0)
                {
                    throw new ArgumentOutOfRangeException("Počet hvězdiček nesmí být záporný");
                }

                for (int i = 0; i < pocetHvezdicek; i++)
                {
                    Console.Write("*");
                }
            }
            catch (FormatException exception)
            {
                Console.WriteLine($"Došlo k výjimce: {exception.Message}");
            }
            catch (ArgumentOutOfRangeException exception)
            {
                Console.WriteLine($"Došlo k výjimce: {exception.Message}");
            }
        }
    }
}

// Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.
