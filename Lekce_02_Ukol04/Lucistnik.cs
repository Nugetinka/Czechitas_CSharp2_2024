namespace Lekce_02_Ukol04
{
    internal class Lucistnik
    {
        private int _pocetSipu;

        public Lucistnik(int pocetSipu)
        {
            if (pocetSipu >= 0)
            {
                _pocetSipu = pocetSipu;
            }
            else
            {
                Console.WriteLine("Počet šípů nemůže být negativní.");
            }
        }

        public void Vystrel()
        {
                _pocetSipu--;
        }

        public int VratPocetSipu()
        { 
            return _pocetSipu; 
        }
    }
}
