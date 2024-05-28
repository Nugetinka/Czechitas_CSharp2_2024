namespace Lekce_02_Ukol03
{
    internal class Program
    {
        private static int tip;

        static void Main(string[] args)
        {
            Random generator = new Random();
            int myslimSiCislo = generator.Next(11);

            Console.WriteLine("Myslím si celé číslo od 0 do 10. Jaké číslo si myslím? Zadej jeho hodnotu: ");
            int tip = NactiPlatnyTip();

            while (tip != myslimSiCislo)
            {
                if (tip > myslimSiCislo)
                {
                    Console.WriteLine("Myslím si menší číslo, hádej znovu: ");
                }
                else if (tip < myslimSiCislo)
                {
                    Console.WriteLine("Myslím si větší číslo, hádej znovu: ");
                }
                tip = NactiPlatnyTip();
            }

            Console.WriteLine("To je správně! :)");
        }

        static int NactiPlatnyTip()
        {
            while (true)
            {
                string zadanyTip = Console.ReadLine();
                bool jeZadanyTipPlatny = int.TryParse(zadanyTip, out tip);

                if (jeZadanyTipPlatny)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Zadal jsi neplatné číslo, zkus to znovu: ");
                }
            }
            return tip;
        }
    }
}


// Napište program, který umožní hádat číslo. Zeptá se, jaké číslo si myslím.
// Podle toho, jaké číslo se zadá, napíše, jestli je číslo větší nebo menší a umožní hádat tak dlouho, dokud se uživatel netrefí:
// Např.
//      Hádej číslo: 10
//      Číslo je menší, hádej znovu: 5
//      Číslo je větší, hádej znovu: 7
//      To je správně!
