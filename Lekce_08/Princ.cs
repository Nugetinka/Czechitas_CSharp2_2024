using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_08
{
    class Princ : TancujiciPohadkovaBytost
    {
        public override void PredstavSe()
        {
            Console.WriteLine("Já jsem princ.");
        }

        public override void PrestanTancovat()
        {
            Console.WriteLine("Princ přestal tancovat.");
        }

        public override void ZacniTancovat()
        {
            Console.WriteLine("Princ začal tancovat.");
        }
    }
}
