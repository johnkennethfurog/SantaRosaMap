using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace SantaRosaMap.CustomControls
{
    public class MapPin : Pin
    {
        public MapPin()
        {

        }

        public string Barangay { get; set; }
        public PinType CustomType { get; set; }
    }
    public enum PinType
    {
        Mall,
        Hospital,
        School,
        Church,
        Bank,
        Store,
        Postal,
        Plaza,
        Barangay
    }
}
