namespace Lekce_02_Ukol04
{
    internal class Lucistnik
    {
        private int PocetSipu;

        public Lucistnik(int pocetSipu)
        {
            if (pocetSipu >= 0)
            {
                PocetSipu = pocetSipu;
            }
            else
            {
                Console.WriteLine("Počet šípů nemůže být negativní.");
            }
        }

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

        public int NastavPocetSipu()
        { 
            return PocetSipu; 
        }
    }
}
