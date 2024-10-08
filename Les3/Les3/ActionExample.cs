using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3
{
    internal class ActionExample
    {
        Action doeIets;
        Action<string> action;
        public void Start()
        {
            doeIets = PrintDemo;
            doeIets();

            action = PrintString;
            action("demo");

        }

        private void PrintDemo()
        {
            Console.WriteLine("print demo");
        }

        private void PrintString(string s)
        {
            Console.WriteLine(s);
        }
    }
}
