using Lekce_08_BR01.PohadkoveBytosti;

namespace Lekce_08_BR01
{
    internal class Program
    {
        static void Main()
        {
            PohadkovaBytost princezna = new Princezna();
            PohadkovaBytost rytir = new Rytir();
            PohadkovaBytost carodejnice = new Carodejnice();

            List<PohadkovaBytost> pohadkoveBytosti = new List<PohadkovaBytost>
            {
                princezna,
                rytir,
                carodejnice
            };

            foreach (PohadkovaBytost pohadkovaBytost in pohadkoveBytosti)
            {
                pohadkovaBytost.NapisJakTravisVolnyCas();
            }
        }
    }
}

// Vytvořte abstraktní třídu PohadkovaBytost a v ní abstraktní metodu NapisJakTravisVolnyCas
// Vytvorte tridy Princezna, Rytir, Carodenice, ktere dedi PohadkovouBytost
// Naimplementujte metodu NapisJakTravisVolnyCas - vypsanemu textu na konzoli se meze nekladou
// Vytvorte instance od kazde tridy a vypiste informace o trávení volného času.
// Ulozit do kolekce.
