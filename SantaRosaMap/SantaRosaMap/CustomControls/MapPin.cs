using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Maps;

namespace SantaRosaMap.CustomControls
{
    public class MapPin : Pin
    {

        public const string default_image = "no_image.png";
        public MapPin()
        {
            SmallImages = default_image;
        }

        public string Barangay { get; set; }
        public PinType CustomType { get; set; }
        public string SmallImages { get; set; }
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
