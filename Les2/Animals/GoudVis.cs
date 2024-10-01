using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class GoudVis : IZwem, IGeluid
    {
        public void MaakGeluid()
        {
            Console.WriteLine("Blub blub");
        }

        public void Zwem()
        {
            Console.WriteLine("Ik zwem in een rondje");
        }
    }
}
