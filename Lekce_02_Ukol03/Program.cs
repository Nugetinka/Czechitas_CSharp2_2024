namespace Lekce_02_Ukol03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int myslimSiCislo = generator.Next(11);

            Console.WriteLine("Myslím si celé číslo od 0 do 10. Jaké číslo si myslím? Zadej jeho hodnotu: ");
            string zadanyTip = Console.ReadLine();
            bool jeZadanyTipPlatny = int.TryParse(zadanyTip, out int tip);

            if (jeZadanyTipPlatny)
            {
                while (tip != myslimSiCislo)
                {
                    if (tip > myslimSiCislo)
                    {
                        Console.WriteLine("Myslím si menší číslo, hádej znovu: ");
                        zadanyTip = Console.ReadLine();
                        jeZadanyTipPlatny = int.TryParse(zadanyTip, out tip);

                        if (!jeZadanyTipPlatny)
                        {
                            Console.WriteLine("Zadaný vstup je neplatný.");
                            return;
                        }
                    }
                    else if (tip < myslimSiCislo)
                    {
                        Console.WriteLine("Myslím si větší číslo, hádej znovu: ");
                        zadanyTip = Console.ReadLine();
                        jeZadanyTipPlatny = int.TryParse(zadanyTip, out tip);

                        if (!jeZadanyTipPlatny)
                        {
                            Console.WriteLine("Zadaný vstup je neplatný.");
                            return;
                        }
                    }
                }
                if (tip == myslimSiCislo)
                {
                    Console.WriteLine("To je správně! :)");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Zadaný vstup je neplatný.");
            }
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
