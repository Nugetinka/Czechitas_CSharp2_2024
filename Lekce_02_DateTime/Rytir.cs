using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_02
{
    internal class Rytir
    {
        public string Jmeno {  get; set; }
        public int PocetZivotu { get; set; }

        public DateTime datumNarozeni;

        public Rytir(string jmeno, int pocetZivotu)
        {
            Jmeno = jmeno;
            PocetZivotu = pocetZivotu;
        }

        public void VypisJmenoAZivoty()
        {
            Console.WriteLine($"Jmenuji se {Jmeno} a mám {PocetZivotu} životů.");
        }
    }
}
