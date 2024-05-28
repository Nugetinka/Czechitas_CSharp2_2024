public class Program
{
    public static void Main()
    {
        Zirafa zirafa = new Zirafa(5, "Žirafa", 4);
        Kun kun = new Kun(10, "Kůň", 50);

        Zvire zvire = zirafa;
        // Nelze přiřadit jakýkoliv datový typ
        // Zvire zvire2 = "";
        // Zvire zvire3 5;

        ZoologickaZahrada oloumackeZoo = new ZoologickaZahrada();
        oloumackeZoo.PridejZvire(zirafa);
        oloumackeZoo.PridejZvire(kun);

        oloumackeZoo.VypisVsechnyZvirata();
    }
}

public abstract class Zvire
{
    public int Vek { get; private set; }

    public string Druh { get; private set; }

    public Zvire(int vek, string druh)
    {
        Vek = vek;
        Druh = druh;
    }

    public abstract void VydavejZvuk();
}

public class Zirafa : Zvire
{
    public int pocetNohou { get; private set; }
    public Zirafa(int vek, string druh, int pocetNohou) : base(vek, druh)
    {
        pocetNohou = pocetNohou;
    }

    public override void VydavejZvuk()
    {
        Console.WriteLine("žif žif");
    }
}

public class Kun : Zvire
{
    public Kun(int vek, string druh, int rychlostBehu)
}

// 3 pilíře OOP
// 1 - zapouzdření
// 2 - dědičnost
// 3 - polymorfismus

//navrhnete vhodnou strukturu trid, ktera umozni v programu (v Mainu) vytvorit seznam zviratek v zoo koutku (List), 
//ktery pak muzeme jednoduse projit cyklem (foreach) a zadat kazdemu z nich prikaz VydavejZvuk
//pritom kazde zviratko bude vydavat jiny zvuk (vypise na konzoli Haf, haf nebo Mnau, mnau)
//v ramci cyklu nechci resit, jake konkretni zviratko to je
//vytvorte alespon 3 ruzna zviratka
//hint: budete potrebovat vhodnou bazovou tridu a virtual/abstract a override