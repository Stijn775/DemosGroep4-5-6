using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare
{
    internal class Persoon : IComparable, IComparable<Persoon>
    {
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }

        public int CompareTo(object? obj)
        {
            if(!(obj is Persoon))
            {
                throw new ArgumentException("Object is not a Person");
            }

            Persoon compareObj = (Persoon)obj;

            return CompareTo(compareObj);

        }

        public int CompareTo(Persoon? other)
        {
            if (Familienaam.CompareTo(other.Familienaam) == 0)
            {
                return Voornaam.CompareTo(other.Voornaam);
            }

            return Familienaam.CompareTo(other.Familienaam);
        }

        public override string? ToString()
        {
            return $"{Voornaam} {Familienaam}";
        }

     
    }
}
