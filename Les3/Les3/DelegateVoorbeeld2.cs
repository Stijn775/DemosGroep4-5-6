using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3
{
    internal class DelegateVoorbeeld2
    {
        delegate void ToonMethode(int x, int y);
        delegate void ToonIetsAnders(int x, int y);

        ToonMethode toonMethode;
        ToonIetsAnders toonIetsAnders;

        public void start()
        {
            toonMethode = ToonSom;
            toonMethode += ToonVerschil;
            toonMethode -= ToonSom;

            toonMethode = ToonSom;
            toonMethode(10, 5);
      
        }

        private void ToonSom(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        private void ToonVerschil(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x-y}");
        }

        private int BerekenSom(int x, int y)
        {
            return x + y;
        }
    }
}
