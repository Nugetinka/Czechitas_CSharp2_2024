namespace Lekce_04_BR02
{
    internal class TelefonniSeznam
    {
        private Dictionary<string, int> telefonniSeznam;

        public TelefonniSeznam() 
        {
            telefonniSeznam = new Dictionary<string, int>
            {
                { "Kristýna", 725317988 },
                { "Lucie", 123456789 },
                { "Alena", 737558422 }
            };
        }

        public void NovyZaznam(string jmeno, int cislo)
        {
            if (!telefonniSeznam.ContainsKey(jmeno))
            {
                telefonniSeznam.Add(jmeno, cislo);
            }
            else
            {
                Console.WriteLine("Tohle jméno již existuje.");
            }
        }

        public int VratTelefonniCislo(string jmeno)
        {
            bool nasloSe = telefonniSeznam.TryGetValue(jmeno, out int telefonniCislo);
            if (nasloSe)
            {
                return telefonniCislo;
            }

            return 0;
        }

        public void VypisVse()
        {
            foreach(var (jmeno, telefonniCislo) in telefonniSeznam)
            {
                Console.WriteLine($"{jmeno} : {telefonniCislo}");
            }
        }

        public void SmazZaznam(string jmeno)
        {
            if (telefonniSeznam.ContainsKey(jmeno))
            {
                telefonniSeznam.Remove(jmeno);
            }
            else
            {
                Console.WriteLine("Tohle jméno není v seznamu.");
            }
        }

        public void SmazTelefonniSeznam()
        {
            telefonniSeznam.Clear();
        }
    }
}
