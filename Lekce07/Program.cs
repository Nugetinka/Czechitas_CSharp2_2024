namespace Lekce07
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Hrdina pavel = new Hrdina();
            pavel.Jmeno = "Pavel";
            pavel.JakSeJmenuji();
            pavel.Zivoty = 11;
            
            Carodejnice bilaPani = new Carodejnice() { Jmeno = "bilaPani" };

            List<PohadkovaBytost> pohadkoveBytosti = new List<PohadkovaBytost>();
            pohadkoveBytosti.Add(pavel);
            pohadkoveBytosti.Add(bilaPani);

            pohadkoveBytosti.ForEach(x => x.JakSeJmenuji());

            pohadkoveBytosti.ForEach(x => x.Zautocim());
        }
    }

    public abstract class PohadkovaBytost
    {
        public string Jmeno { get; set; }

        public virtual void JakSeJmenuji()
        {
            Console.WriteLine(Jmeno);
        }

        public abstract void Zautocim();
    }

    public class Hrdina : PohadkovaBytost
    {
        public int Zivoty { get; set; } = 10;

        public override void Zautocim()
        {
            Console.WriteLine(Jmeno + " švihl mečem.");
        }
    }

    public class Carodejnice : PohadkovaBytost
    {
        public override void Zautocim()
        {
            Console.WriteLine(Jmeno + " vykouzlila ohnivou kouli.");
        }

        public override void JakSeJmenuji()
        {
            base.JakSeJmenuji();
            Console.WriteLine("Huuuu");
        }
    }
}

