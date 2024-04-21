namespace Lekce_02_Ukol02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Zadej počet hvězdiček: ");
                string vstup = Console.ReadLine();
                int pocetHvezdicek = int.Parse(vstup);

                for (int i = 0; i < pocetHvezdicek; i++)
                {
                    Console.Write("*");
                }
            }
            catch
            { 
                Console.WriteLine("Zadal jsi neplatný vstup.");
                Console.ReadLine();
            }
        }
    }
}

// Napište program, který se zeptá na počet hvězdiček a potom je v cyklu zobrazí na konzoli.
