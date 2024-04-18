namespace Lekce_03_BR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej den: ");
            string textDen = Console.ReadLine();
            int den = int.Parse(textDen);

            Console.WriteLine("Zadej měsíc: ");
            string textMesic = Console.ReadLine();
            int mesic = int.Parse(textMesic);

            Console.WriteLine("Zadej rok: ");
            string textRok = Console.ReadLine();
            int rok = int.Parse(textRok);

            DateTime ted = DateTime.Now;
            DateTime casDovolene = new DateTime(rok, mesic, den);

            TimeSpan casDoDovolene = casDovolene - ted;

            Console.WriteLine($"Dny: {casDoDovolene.Days}, Minuty: {casDoDovolene.Minutes}");

            Console.WriteLine(ted.ToString("yyyy-MM-dd hh:mm:ss"));
        }
    }
}

// Zbývající dny do dovolené
// Postupně se zeptej na den, měsíc a rok odjezdu na dovolenou. Pomocí DateTime a TimeSpand vypočítej počet zbývajícíh dní do odjezdu na dovolenou.
// stačí int.Parse
