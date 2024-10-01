using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2
{

   abstract class Demo
    {

        public abstract string Name { get; }

        public string PrintMe()
        {
            return Name;
        }
    }
    internal interface IPersoon
    {
        string Familienaam { get; set; }
        string PrintMe();
    }

    internal class Persoon : IPersoon
    {
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }

        public string PrintMe()
        {
            return $"Persoon {Familienaam}";
        }
    }

    class Student : IPersoon
    {
        public string Familienaam { get ; set ; }
        public string Voornaam { get; set; }
        public string klas { get; set; }
        public List<string> vakken { get; set; }

        public string PrintMe()
        {
            return $"Student {Familienaam}";
        }
    }
}
