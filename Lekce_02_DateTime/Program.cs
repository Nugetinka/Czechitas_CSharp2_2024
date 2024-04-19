namespace Lekce_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PraceSCasem(); // Výklad DateTime
        }

        private static void PraceSCasem()
        {
            Console.WriteLine("Hello, World!");

            // tridu Rytir - 2 vlastnosti a 1 metodu
            // Jmeno, pocet zivotu

            Rytir albrecht = new Rytir("Albrecht", 3);

            albrecht.VypisJmenoAZivoty();

            //albrecht.datumNarozeni = DateTime.Now; // toto je okamžitý čas v počítači
            albrecht.datumNarozeni = new DateTime(1987, 9, 7);
            albrecht.datumNarozeni = albrecht.datumNarozeni.AddHours(12).AddDays(3); // přidávám hodiny a dny přímo do DateTime

            //Console.WriteLine($"Narodil jsem se {albrecht.datumNarozeni}");
            Console.WriteLine($"Narodil jsem se {albrecht.datumNarozeni.Day}.{albrecht.datumNarozeni.Month}.{albrecht.datumNarozeni.Year}");

            TimeSpan vek = DateTime.Now - albrecht.datumNarozeni;
            Console.WriteLine($"Můj věk je {vek.Days / 365}");

            DateTime novyCas = new DateTime(1987, 9, 7, 6, 30, 30);
            TimeSpan odecetHodinAMinut = novyCas - albrecht.datumNarozeni;
            Console.WriteLine($"Můj věk je {odecetHodinAMinut.TotalDays / 365}");
        }
    }
}
