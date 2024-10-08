using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3
{
    internal class DelegateExample
    {
        delegate int IntMethode();
        Func<int> sum;

        public void Start()
        {
            sum = SumFunctie;

            int result = sum();

            Console.WriteLine(result);
        }

        private int SumFunctie()
        {
           return 5;
        }
    }
}
