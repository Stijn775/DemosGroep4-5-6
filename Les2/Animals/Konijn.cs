using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Konijn : ILoop, IGeluid
    {
        public void Loop()
        {
            Console.WriteLine("Ik huppel rond!");
        }

        public void MaakGeluid()
        {
            Console.WriteLine("Snuffel snuffel");
        }
    }
}
