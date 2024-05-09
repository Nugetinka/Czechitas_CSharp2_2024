namespace Lekce_04_Ukol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Vypiš aktuální datum a čas, nemusíš řešit, v kterém je to časovém pásmu.
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("-----------------------");

            // 2. Vytvoř proměnnou typu DateTime a ulož do ní svoje datum narození.
            // Potom vypiš, kolik dnů od té doby uteklo.
            DateTime datumNarozeni = new DateTime(1987, 9, 7);
            TimeSpan vek = DateTime.Now - datumNarozeni;
            Console.WriteLine($"Od mého narození uteklo {vek.TotalDays} dní.");
            Console.WriteLine("-----------------------");

            // 3. Vytvoř list stringů a vlož do něj 5 různých hodnot.
            List<string> listPredmetu = new List<string>
            {
                "matematika",
                "čeština",
                "vlastivěda",
                "zeměpis",
                "angličtina"
            };

            VypisList(listPredmetu);
            Console.WriteLine("-----------------------");

            static void VypisList(List<string> listPredmetu)
            {
                foreach (string predmet in listPredmetu)
                {
                    Console.WriteLine(predmet);
                }
            }

            // 4. Smaž z tohoto listu libovolnou hodnotu.
            listPredmetu.Remove("zeměpis");

            VypisList(listPredmetu);
            Console.WriteLine("-----------------------");

            // 5. Zjisti, jestli tento list obsahuje nějakou hodnotu pomocí list metody Contains
            bool jeVSeznamu = listPredmetu.Contains("dějepis");
            if (jeVSeznamu)
            {
                Console.WriteLine("Je v seznamu předmětů.");
                Console.WriteLine("-----------------------");
            }
            else
            {
                Console.WriteLine("Není v seznamu předmětů.");
                Console.WriteLine("-----------------------");
            }

            // 6. Vypiš do konzole, kolik je v tom listu prvků a
            // připoj k tomu všechny ty hodnoty (např: "2: modra, zelena").
            Console.WriteLine($"Počet prvků v listu je: {listPredmetu.Count()}");
            Console.WriteLine("Seznam prvků: ");

            VypisList(listPredmetu);
            Console.WriteLine("-----------------------");

            // 7. Vytvoř slovník, kde klíčem bude položka nákupu (string)
            // a hodnotou cena té položky, a vlož nějaké hodnoty (např: <"chleba", 20>).
            Dictionary<string, int> polozkyNakupu = new Dictionary<string, int>
            {
                { "chleba", 20 },
                { "houska", 5 },
                { "koláček", 15 },
                { "rohlík", 3 },
            };

            VypisSlovnik(polozkyNakupu);
            Console.WriteLine("-----------------------");

            static void VypisSlovnik(Dictionary<string, int> polozkyNakupu)
            {
                foreach (var (pecivo, cena) in polozkyNakupu)
                {
                    Console.WriteLine($"{pecivo} : {cena}");
                }
            }

            // 8. Zjisti, jestli slovník obsahuje nějakou konkrétní potravinu
            // a pokud ano, vypiš její cenu, pokud ne, vypiš, že není.
            VratCenuPolozky("rohlík", polozkyNakupu);
            VratCenuPolozky("kukuřice", polozkyNakupu);
            Console.WriteLine("-----------------------");

            static void VratCenuPolozky(string pecivo, Dictionary<string, int> polozkyNakupu)
            {
                bool nasloSe = polozkyNakupu.TryGetValue(pecivo, out int cena);
                if (nasloSe)
                {
                    Console.WriteLine($"Položka se našla - {pecivo} : {cena}");
                }
                else
                {
                    Console.WriteLine("Položka se nenašla.");
                }
            }

            // 9. Řekněme, že už jsi do slovníku přidala např. chleba a zjistila,
            // že máš v nákupní tašce ještě jeden -> uprav hodnotu k tomu klíči tak,
            // aby obsahovala hromadnou cenu za všechny stejné položky.
            VypisSlovnik(polozkyNakupu);
            Console.WriteLine("-----------------------");
            AktualizujHromadneCeny("rohlík", polozkyNakupu);
            VypisSlovnik(polozkyNakupu);
            Console.WriteLine("-----------------------");

            static void AktualizujHromadneCeny(string pecivo, Dictionary<string, int> polozkyNakupu)
            {
                if (polozkyNakupu.ContainsKey(pecivo))
                {
                    int novaCena = polozkyNakupu[pecivo] * 2;
                    polozkyNakupu[pecivo] = novaCena;
                }
                else
                {
                    Console.WriteLine("Položka se nenechází v nákupním seznamu.");
                }
            }
        }
    }
}
