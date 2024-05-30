namespace Lekce_06_BR01
{
    public class Program
    {
        public static void Main()
        {
            // BR 1
            // Vytvoření instancí třídy Obdelnik
            Obdelnik obdelnik1 = new Obdelnik(1, 2);
            Obdelnik ctverec = new Obdelnik(2);

            // Výpis parametrů obdélníků
            obdelnik1.VypisParametryObdelniku();
            ctverec.VypisParametryObdelniku();

            // BR2
            // Zvětšení parametrů obdélníků
            obdelnik1.ZvetsiParametryObdelniku(1, 3);
            ctverec.ZvetsiParametryObdelniku(2, 2);

            // Výpis nových/zvětšených parametrů obdélníků
            obdelnik1.VypisParametryObdelniku();
            ctverec.VypisParametryObdelniku();

            // Výpis obvodu a obsahu obdélníků
            Console.WriteLine($"Obsah: {obdelnik1.Obsah}");
            Console.WriteLine($"Obvod: {obdelnik1.Obvod}");

            Console.WriteLine($"Obsah: {ctverec.Obsah}");
            Console.WriteLine($"Obvod: {ctverec.Obvod}");
        }
    }
}

/* BREAKOUT ROOM 1
Vytvoř třídu Obdelnik (tak, aby byla v samostatnem souboru Obdelnik.cs), která bude mít dva fieldy: Sirka a Vyska.
Vytvoř konstruktor třídy Obdelnik s parametry sirka a vyska.
Přidej do třídy ještě jeden typ konstruktoru pro speciální případ obdelníku(čtverec) s jedním parametrem, který bude volat první konstruktor.
Obdelniku vytvorte funkci Vypis informace, ktery vypise vysku a sirku.
Vytvoř několik instancí třídy Obdelnik (například 2) a vypiš jejich vlastnosti pomoci metody VypisParameteryObdelniku.
    
BREAKOUT ROOM 2
Vyuzij tridu Obdelnik z prvniho BR.
Prepis fieldy Sirka a Vyska na properties.
Nastavte properties tak, aby je nebylo mozne zmenit po vytvoreni instance.
Vytvorte property Obsah, ktera umozni ziskat obsah obdelniku.
Vytvorte property Obvod, ktera umozni ziskat obvod obdelniku.
Vytvorte funkci Zvetsi, ktera zvetsi obdelnik o sirku a vysku.
Zajistete, aby nebylo mozne vytvorit obdelnik o obsahu 0 (vypiste hlasku a nastavte hodnotu na 1).
Napiste program, ktery vytvori obdelnik, vypise jeho velikosti, obsah a obvod.
*/