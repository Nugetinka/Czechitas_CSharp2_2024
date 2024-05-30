using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_08
{
    class Princezna : PohadkovaBytost, ITancujiciBytost
    {
        public override void PredstavSe()
        {
            Console.WriteLine("Já jsem princezna.");
        }

        public void PrestanTancovat()
        {
            Console.WriteLine("Princezna přestala tancovat.");
        }

        public void ZacniTancovat()
        {
            Console.WriteLine("Princezna začala tancovat.");
        }
    }
}
