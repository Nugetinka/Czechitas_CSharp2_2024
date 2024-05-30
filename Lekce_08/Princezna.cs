using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_08
{
    class Princezna : TancujiciPohadkovaBytost
    {
        public override void PredstavSe()
        {
            Console.WriteLine("Já jsem princezna.");
        }

        public override void PrestanTancovat()
        {
            Console.WriteLine("Princezna přestala tancovat.");
        }

        public override void ZacniTancovat()
        {
            Console.WriteLine("Princezna začala tancovat.");
        }
    }
}
