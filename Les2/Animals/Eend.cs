using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Eend : IZwem, ILoop, IGeluid
    {
        public void Loop()
        {
            Console.WriteLine("Ik loop in het gras!");
        }

        public void MaakGeluid()
        {
            Console.WriteLine("Kwak kwak");
        }

        public void Zwem()
        {
            Console.WriteLine("Ik zwem in de vijver");
        }
    }
}
