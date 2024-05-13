using System.Collections;

namespace Lekce05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rytir borivoj = new Rytir() { Jmeno = "Borivoj", Zdravi = 100, KodZeme = "CZ" };
            Rytir vojtech = new Rytir() { Jmeno = "Vojtech", Zdravi = 100, KodZeme = "CZ" };
            Rytir miroslav = new Rytir() { Jmeno = "Miroslav", Zdravi = 80, KodZeme = "SK" };
            Rytir bronislav = new Rytir() { Jmeno = "Bronislav", Zdravi = 50, KodZeme = "SK" };
            Rytir vaclav = new Rytir() { Jmeno = "Vaclav", Zdravi = 80, KodZeme = "CZ" };
            Rytir radovan = new Rytir() { Jmeno = "Radovan", Zdravi = 10, KodZeme = "CZ" };
            Rytir istvan = new Rytir() { Jmeno = "Istvan", Zdravi = 35, KodZeme = "HU" };

            List<Rytir> rytiri = new List<Rytir>() { borivoj, vojtech, miroslav, bronislav, vaclav, radovan, istvan };
            List<Zeme> zeme = new List<Zeme>() {
                new Zeme() { Kod = "CZ", Nazev = "Cesko" },
                new Zeme() { Kod = "SK", Nazev = "Slovensko" },
                new Zeme() { Kod = "HU", Nazev = "Madarsko"}
            };

            var silniRytiri = rytiri.Where(r => r.Zdravi > 90);
            var silniRytiri2 = rytiri.Where(JeSilny);

            foreach (Rytir rytir in silniRytiri)
            {
                Console.WriteLine(rytir.Jmeno);
            }

            Console.WriteLine($"Pocet slabych rytiru: {rytiri.Count(r => r.Zdravi < 25)}"); //Count je LINQ

            var slabiRytiri = rytiri.Where(r => r.Zdravi < 60);
            Console.WriteLine($"Pocet slabych rytiru: {slabiRytiri.Count()}"); //Count neni LINQ

            var neexistujiciRytiri = rytiri.Where(r => r.Zdravi > 200);

            Rytir prvniNeexitujiciRytir = neexistujiciRytiri.FirstOrDefault();
            if (prvniNeexitujiciRytir is not null)
            {
                Console.WriteLine($"Neexistujici rytir je: {prvniNeexitujiciRytir.Jmeno}");
            }
            else
            {
                Console.WriteLine("Rytir opravdu neexistuje.");
            }

            Console.WriteLine($"Prvni rytir je: {rytiri.First().Jmeno}");
            Console.WriteLine($"Posledni rytir je: {rytiri.Last().Jmeno}");

            Console.WriteLine($"Prumerne zdravi rytire je: {rytiri.Average(r => r.Zdravi)}");
            Console.WriteLine($"Prumerne zdravi slabeho rytire je: {slabiRytiri.Average(r => r.Zdravi)}");

            Console.WriteLine($"Existuje rytir silnejsi nez 100: {rytiri.Any(r => r.Zdravi > 100)}");
            Console.WriteLine($"Jsou vsicni rytiri zdravejsi nez 5: {rytiri.All(r => r.Zdravi > 5)}");

            var rytiriPodleJmena = rytiri.OrderBy(r => r.Jmeno);
            foreach (Rytir rytir in rytiriPodleJmena)
            {
                //Console.WriteLine(rytir.Jmeno);
            }

            var rytiriPodleNarodnosti = rytiri.GroupBy(r => r.KodZeme);
            foreach (var skupinaRytiru in rytiriPodleNarodnosti)
            {
                //skupinaRytiru.Key
                Zeme zemeRytire = zeme.Find(zem => zem.Kod == skupinaRytiru.Key);
                Console.WriteLine(zemeRytire.Nazev);
                foreach (Rytir rytir in skupinaRytiru)
                {
                    Console.WriteLine(rytir.Jmeno);
                }
            }

            var rytiriVhezkyPojmenovanemGroupingu = rytiri.GroupBy(r => r.KodZeme, (kodZeme, skupinaRytiru) => new {
                ZemRytiru = kodZeme, // odpovida Key
                Skupina = skupinaRytiru
            }).ToList();
            foreach (var skupinaRytiru in rytiriVhezkyPojmenovanemGroupingu)
            {
                Console.WriteLine(skupinaRytiru.ZemRytiru);
                foreach (Rytir rytir in skupinaRytiru.Skupina)
                {
                    Console.WriteLine(rytir.Jmeno);
                }
            }

            var rytiriKolekceKolekci = rytiri.GroupBy(r => r.KodZeme, (kodZeme, skupinaRytiru) => skupinaRytiru);
            var rytiriJmena = rytiriKolekceKolekci.SelectMany(k => k.Select(r => r.Jmeno));
            Console.WriteLine("Jmena po seskupeni a zplosteni.");
            foreach (var jmeno in rytiriJmena)
            {
                Console.WriteLine(jmeno);
            }

            var rytiriSeZemi = from rytir in silniRytiri
                               join zem in zeme on rytir.KodZeme equals zem.Kod
                               select new
                               {
                                   Jmeno = rytir.Jmeno,
                                   Zeme = zem.Nazev
                               };
            var rytiriSeZemiOdM = rytiriSeZemi.Where(r => r.Jmeno.StartsWith("M"));
            var rytiriSeZemiList = rytiriSeZemiOdM.ToList();
            foreach (var rytirSeZemi in rytiriSeZemiList)
            {
                Console.WriteLine($"Jmenuji se {rytirSeZemi.Jmeno} a jsem z {rytirSeZemi.Zeme}");
            }
            foreach (var rytirSeZemi in rytiriSeZemiList)
            {
                Console.WriteLine($"Jmenuji se {rytirSeZemi.Jmeno} a jsem z {rytirSeZemi.Zeme}");
            }

            var definovanaCisle = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var definovanaCislaKromePrvnicTrech = definovanaCisle.Skip(3);
            var sudaCisla = definovanaCislaKromePrvnicTrech.Where(c => c % 2 == 0); //IEnumerable co se nezmeni
            Console.WriteLine("Vicenasobna enumerace co se nezmeni: ");
            foreach (var cislo in sudaCisla)
            {
                Console.Write(cislo + ", ");
            }
            Console.WriteLine();
            foreach (var cislo in sudaCisla)
            {
                Console.Write(cislo + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Vicenasobna enumerace co se zmeni: ");
            var nahodnacisla = new NahodnyEnumerable(); //IEnumerable co se zmeni
            var prvnichDesetNahodnych = nahodnacisla.Take(10);
            foreach (var cislo in prvnichDesetNahodnych)
            {
                Console.Write(cislo + ", ");
            }
            Console.WriteLine();
            foreach (var cislo in prvnichDesetNahodnych)
            {
                Console.Write(cislo + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Vicenasobna enumerace po ulozeni do listu: ");
            var prvnichDesetNahodnychVListu = prvnichDesetNahodnych.ToList();
            foreach (var cislo in prvnichDesetNahodnychVListu)
            {
                Console.Write(cislo + ", ");
            }
            Console.WriteLine();
            foreach (var cislo in prvnichDesetNahodnychVListu)
            {
                Console.Write(cislo + ", ");
            }

        }

        private static bool JeSilny(Rytir rytir)
        {
            return rytir.Zdravi > 90;
        }
    }

    class Rytir
    {
        public string Jmeno { get; set; }
        public int Zdravi { get; set; }
        public string KodZeme { get; set; }
    }

    class Zeme
    {
        public string Nazev { get; set; }
        public string Kod { get; set; }
    }

    // Tato trida je ukazka, ze IEnumerable nemusi byt pouze pevne definovana kolekce jako je List, ale ze muze vracet cisla i uplne nahodne
    internal class NahodnyEnumerable : IEnumerable<int>
    {
        private Random random;

        public NahodnyEnumerable()
        {
            random = new Random();
        }

        // Enumerator je zpusob, jak pozadat o dalsi prvek (normalne ho cteme z kolekce, ale tady je tahame z klobouku)
        public IEnumerator<int> GetEnumerator()
        {
            while (true)
            {
                yield return random.Next(1, 20);
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}