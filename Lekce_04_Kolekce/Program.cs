namespace Lekce_04_Kolekce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rytir bonifac = new Rytir("Bonifac", 2);
            Rytir artus = new Rytir("Artus", 1);
            Rytir geralt = new Rytir("Geralt", 3);

            Rytir[] poleRytiru = new Rytir[3] { bonifac, artus, geralt };

            for (int i = 0; i < poleRytiru.Length; i++)
            {
                poleRytiru[i].VypisJmenoAZivoty();
            }

            Rytir max = new Rytir("Max", 1);

            Console.WriteLine();

            // kolekce (List)
            List<Rytir> seznamRytiru = new List<Rytir>() { bonifac, artus, geralt };

            seznamRytiru.Add(max); // přidá položku // seznamRytiru.AddRange(poleRytiru)

            for (int i = 0; i < seznamRytiru.Count; i++)  // u listu používáme Count
            {
                seznamRytiru[i].VypisJmenoAZivoty();
            }

            Console.WriteLine();

            foreach (Rytir r in seznamRytiru) // elegantnější zápis pro průchod seznamem
            {
                r.VypisJmenoAZivoty();
            }

            Rytir filip = new Rytir("Filip", 1);

            seznamRytiru.Insert(0, filip); // vložení na konktrétní index v seznamu

            foreach (Rytir r in seznamRytiru)
            {
                r.VypisJmenoAZivoty();
            }

            seznamRytiru.Remove(filip); // remove smaže danou položku

            int poziceRytire = seznamRytiru.IndexOf(geralt); // dotaz na index v seznamu
            Console.WriteLine($"Rytir geralt je na pozici {poziceRytire}");

            bool jeVSeznamu = seznamRytiru.Contains(geralt); // dotaz, zda tam daná položka je
            if ( jeVSeznamu )
            {
                Console.WriteLine("Je tam.");
            }
            else
            {
                Console.WriteLine("Není.");
            }

            string jmenoKSmazani = "Geralt";
            Rytir nalezenyRytir = seznamRytiru.Find(r => r.Jmeno == jmenoKSmazani);

            seznamRytiru.Remove(nalezenyRytir);

            foreach (Rytir r in seznamRytiru)
            {
                r.VypisJmenoAZivoty();
            }

            // Sort

            Console.WriteLine();

            seznamRytiru.Sort(PorovnejRytire);

            foreach (Rytir r in seznamRytiru)
            {
                r.VypisJmenoAZivoty();
            }

            seznamRytiru.Clear(); // smažu celý seznam
        }

        private static int PorovnejRytire(Rytir prvni, Rytir druhy)
        {
            return string.Compare(prvni.Jmeno, druhy.Jmeno, true);
        }
    }
}
