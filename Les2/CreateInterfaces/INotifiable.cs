using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateInterfaces
{
    // Een interface voor een notificatie die kan verschijnen. Elke notificatie bestaat uit een logo, titel en beschrijving. Je kan ook op een notificatie klikken. Noem deze interface INotifiable.
    internal interface INotifiable
    {
        string LogoUrl { get; }
        string Title { get; }
        string Description { get; }

        void OnClick(EventHandler evt);
    }
}
