using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateInterfaces
{
    // Een interface voor het lezen van data
    internal interface IReadable
    {
        string Read(string path); // String kan ook void zijn.
    }
}
