using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateInterfaces
{
    // Interface die ervoor zorgt we checkboxen/radiobuttons kunnen printen op het scherm. We verwachten hier een Select en Deselect functie. We willen ook weten of een item geselecteerd is of niet. ISelectable
    internal interface ISelectable
    {
        void Display();
        void Select();
        void Deselect();
        bool Selected { get; }
    }
}
