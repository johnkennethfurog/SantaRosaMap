using System;
using System.Collections.Generic;
using System.Text;
using Prism.Events;
using SantaRosaMap.CustomControls;

namespace SantaRosaMap.Events
{
    public class NavigateToLocationCommand : PubSubEvent<MapPin> { }
}
