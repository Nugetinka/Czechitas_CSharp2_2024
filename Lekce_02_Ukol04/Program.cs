namespace Lekce_02_Ukol04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lucisnik alexander = new Lucisnik(10);

            while (alexander.PocetSipu > 0)
            {
                alexander.Vystrel();
            }
        }

        public class Lucisnik
        {
            public int PocetSipu;

            public void Vystrel()
            {
                PocetSipu--;

                if (PocetSipu > 0)
                {
                    Console.WriteLine("Vždy se trefím přímo doprostřed!");
                }
                else
                {
                    Console.WriteLine("Nemám šípy.");
                }
            }

            public Lucisnik(int pocetSipu)
            {
                PocetSipu = pocetSipu;
            }
        }
    }
}

// Vytvořte třídu Lucistnik, ktera bude mit vlastnost PocetSipu a metodu Vystrel. PocetSipu muze byt nastaven treba na 10.
// Pokud bude mit dost sipu, napise metoda Vystrel na konzoli text: Vzdy se strefim primo doprostred!
// Metoda Vystrel uvnitr s kazdym vystrelem snizi pocet sipu.
// Pokud bude pocet 0, metoda Vystrel vypise "Nemam sipy".
// Napiste program, ktery vytvori lucistnika a vystreli vsechny sipy.
