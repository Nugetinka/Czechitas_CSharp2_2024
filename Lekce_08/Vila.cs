namespace Lekce_08
{
    class Vila : PohadkovaBytost, ITancujiciBytost, IKouzelnaBytost
    {
        public void BudNeviditelny()
        {
            Console.WriteLine("Víla je neviditelná.");
        }

        public void BudViditelny()
        {
            Console.WriteLine("Víla je viditelná.");
        }

        public override void PredstavSe()
        {
            Console.WriteLine("Já jsem víla.");
        }

        public void PrestanTancovat()
        {
            Console.WriteLine("Víla netancuje");
        }

        public void ZacniTancovat()
        {
            Console.WriteLine("Víla tancuje");
        }
    }
}
