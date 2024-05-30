using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce_08
{
    class Carodej : PohadkovaBytost, IKouzelnaBytost
    {
        public void BudNeviditelny()
        {
            Console.WriteLine("Čaroděj je neviditelný.");
        }

        public void BudViditelny()
        {
            Console.WriteLine("Čaroděj je viditelný.");
        }

        public override void PredstavSe()
        {
            Console.WriteLine("Já jsem čaroděj.");
        }
    }
}
