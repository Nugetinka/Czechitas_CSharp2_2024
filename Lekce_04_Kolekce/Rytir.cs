using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_04_Kolekce
{
    public class Rytir
    {
        public string Jmeno;
        public int PocetZivotu;

        public void VypisJmenoAZivoty()
        {
            Console.WriteLine($"Jsem rytíř {Jmeno}, mám {PocetZivotu} životů.");
        }

        public Rytir(string jmeno, int pocetZivotu) 
        {
            Jmeno = jmeno;
            PocetZivotu = pocetZivotu;
        }
    }
}
