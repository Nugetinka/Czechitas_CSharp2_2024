using System.Text;

namespace Lekce_03_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------");
            string oddelovac = new string('-', 20);
            Console.WriteLine(oddelovac);

            char maleAcko = 'a';
            char velkeAcko = 'A';
            Console.WriteLine(maleAcko + velkeAcko);
            int ciselnaHodnotaMaleAcko = (int)maleAcko;
            int ciselnaHodnotaVelkeAcko = (int)velkeAcko;
            Console.WriteLine(ciselnaHodnotaMaleAcko);
            Console.WriteLine(ciselnaHodnotaVelkeAcko);

            for (int i = 0; i < 127; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(" ");
                Console.WriteLine((char)i);
            }

            int vychoziInt = default(int);
            string vychoziString = default(string);
            Console.WriteLine(vychoziInt == null);
            Console.WriteLine(vychoziString == null);

            string vstup = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(vstup))
            {
                Console.WriteLine("Špatný vstup");
                vstup = Console.ReadLine();
            }

            Console.WriteLine($"malé a vypadá takto: {maleAcko}");

            string uzivatelskeJmeno = "Kristýna";
            string heslo = "Czechitas";
            Console.WriteLine("Zadej jmeno: ");
            string vstupJmeno = Console.ReadLine();
            string vstupOcisteny = vstupJmeno.Trim();
            Console.WriteLine($"Vstup původní: [{vstupJmeno}] a po očištění [{vstupOcisteny}]");
            if (string.Equals(uzivatelskeJmeno, vstupOcisteny, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Zadej heslo: ");
                string vstupHeslo = Console.ReadLine();
                if (vstupHeslo == heslo)
                {
                    Console.WriteLine("Vítej, vše v pořádku.");
                }
            }

            string prvniString = "aa";
            string druhyString = "ab";
            int vysledekPorovnani = string.Compare(prvniString, druhyString, StringComparison.Ordinal);
            Console.WriteLine($"Výsledek porovnání: {vysledekPorovnani}");

            string dlouhyText = "Ahoj Pepo, jak se máš? Ahoj.";
            bool obsahujePepu = dlouhyText.Contains("pepo", StringComparison.OrdinalIgnoreCase);
            int indexPepa = dlouhyText.IndexOf("Pepo");
            Console.WriteLine($"Obsahuje pepu: {obsahujePepu} na {indexPepa} pozici");

            string prvnich10znaku = dlouhyText.Substring(startIndex: 0, length: 10);
            Console.WriteLine($"Prvních 10 znaků: {prvnich10znaku}");
            string odPepy = dlouhyText.Substring(startIndex: indexPepa);
            Console.WriteLine($"Znaky od Pepy {odPepy}");

            string pozdravHonzy = dlouhyText.Replace("Pepo", "Honzo");
            Console.WriteLine($"Pozdrav Honzy: {pozdravHonzy}");

            string pozdravPepyCau = dlouhyText.Replace("Ahoj", "Čau");
            Console.WriteLine($"Pozdrav s Čau: {pozdravPepyCau}");

            string jidlaVcelku = "rizek, kedlubna";
            string[] jidla = jidlaVcelku.Split(',');
            //string[] jidla = { "rizek", "kedlubna" };
            for (int i = 0; i < jidla.Length; i++)
            {
                Console.Write(jidla[i].PadRight(20, '.'));
            }


           // Vytvoření přes SB
           StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(sb.ToString());

            // Vytvoření bez SB
            string souhrn = "";
            for (int i = 0; i < 1000; i++)
            {
                souhrn += i;
            }
            Console.WriteLine(souhrn);
        }
    }
}
