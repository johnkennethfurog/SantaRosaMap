using SantaRosaMap.CustomControls;
using System;
using System.Collections.Generic;
using System.Text;

namespace SantaRosaMap.Helpers
{
    public static class PinHelper
    {
        public static List<MapPin> StaticPins = new List<MapPin>();
        public static void LoadStaticPins()
        {

            StaticPins.Clear();

            StaticPins.Add(new MapPin { Address = "129 Rizal Blvd, Brgy. Tagapo, Santa Rosa, 4026 Laguna", Barangay = "Tagapo", CustomType = PinType.Barangay, Label = "Tagapo Barangay Hall", Position = new Xamarin.Forms.Maps.Position(14.313149, 121.096672) });
            StaticPins.Add(new MapPin { Address = "Tatlong Hari St, Santa Rosa, Laguna", Barangay = "Market Area", CustomType = PinType.Barangay, Label = "Market Area Barangay Hall", Position = new Xamarin.Forms.Maps.Position(14.318949, 121.112111) });
            StaticPins.Add(new MapPin { Address = "Santa Rosa, Laguna", Barangay = "Sinalhan", CustomType = PinType.Barangay, Label = "Sinalhan Barangay Hall", Position = new Xamarin.Forms.Maps.Position(14.330190, 121.111646) });
            StaticPins.Add(new MapPin { Address = "Brgy Aplaya , Santa Rosa, Laguna", Barangay = "Aplaya", CustomType = PinType.Barangay, Label = "Aplaya Barangay Hall", Position = new Xamarin.Forms.Maps.Position(14.313735, 121.121318) });
            StaticPins.Add(new MapPin { Address = "Santa Rosa, Laguna", Barangay = "Caingin", CustomType = PinType.Barangay, Label = "Caingin Barangay Hall", Position = new Xamarin.Forms.Maps.Position(14.298646, 121.128104) });
            StaticPins.Add(new MapPin { Address = "Santa Rosa, Laguna", Barangay = "Ibaba", CustomType = PinType.Barangay, Label = "Ibaba Barangay Hall", Position = new Xamarin.Forms.Maps.Position(14.314879, 121.119820) });
            StaticPins.Add(new MapPin { Address = "Santa Rosa, Laguna", Barangay = "Malusak", CustomType = PinType.Barangay, Label = "Malusak Barangay Hall", Position = new Xamarin.Forms.Maps.Position(14.312883, 121.114590) });
            StaticPins.Add(new MapPin { Address = "Leon Arcillas bldv, kanluran, santa rosa, 4026, laguna", Barangay = "Kanluran", CustomType = PinType.Barangay, Label = "Kanluran Barangay Hall", Position = new Xamarin.Forms.Maps.Position(14.313314, 121.107522) });
            StaticPins.Add(new MapPin { Address = "West Drive, bgry.4026, santa rosa laguna", Barangay = "Labas", CustomType = PinType.Barangay, Label = "Labas Barangay Hall", Position = new Xamarin.Forms.Maps.Position(14.306853, 121.109944) });
            StaticPins.Add(new MapPin { Address = "Santa Rosa, Laguna, 4026", Barangay = "Pooc", CustomType = PinType.Barangay, Label = "Pooc Barangay Hall", Position = new Xamarin.Forms.Maps.Position(14.300389, 121.111915) });


            StaticPins.Add(new MapPin { Address = "National Road, Barrio Tagapo, Santa Rosa, Laguna", Barangay = "Tagapo", CustomType = PinType.Mall, Label = "SM Sta. Rosa", Position = new Xamarin.Forms.Maps.Position(14.313288, 121.099555) });
            StaticPins.Add(new MapPin { Address = "National Highway, Tagapo, Santa Rosa, Laguna", Barangay = "Tagapo", CustomType = PinType.Hospital, Label = "New Sinai MDI Hospital", Position = new Xamarin.Forms.Maps.Position(14.317551, 121.098544) });
            StaticPins.Add(new MapPin { Address = "Tiongco Subdivision, Santa Rosa, Laguna", Barangay = "Tagapo", CustomType = PinType.School, Label = "PUP Santa Rosa", Position = new Xamarin.Forms.Maps.Position(14.313414, 121.106526) });
            StaticPins.Add(new MapPin { Address = "Cattleya St, LM Subdivision, Market Area, Santa Rosa, 4026 Laguna", Barangay = "Market Area", CustomType = PinType.Hospital, Label = "Santa Rosa Community Hospital", Position = new Xamarin.Forms.Maps.Position(14.318731, 121.110995) });
            StaticPins.Add(new MapPin { Address = "Tatlong Hari St, Santa Rosa, 4026 Laguna", Barangay = "Market Area", CustomType = PinType.Store, Label = "Santa Rosa Public Market", Position = new Xamarin.Forms.Maps.Position(14.315437, 121.111884) });
            StaticPins.Add(new MapPin { Address = "Jasmin St. DP Subdivision, Market Area, Santa Rosa, 4026 Laguna", Barangay = "Market Area", CustomType = PinType.Church, Label = "Our Lady Fatima Church", Position = new Xamarin.Forms.Maps.Position(14.317731, 121.110299) });
            StaticPins.Add(new MapPin { Address = "Brgy Sinalhan, Santa Rosa, Laguna", Barangay = "Sinalhan", CustomType = PinType.School, Label = "Sinalhan Elementary School", Position = new Xamarin.Forms.Maps.Position(14.325995, 121.116190) });
            StaticPins.Add(new MapPin { Address = "Brgy Sinalhan, Santa Rosa, Laguna", Barangay = "Sinalhan", CustomType = PinType.Church, Label = "Sinalhan Chapel", Position = new Xamarin.Forms.Maps.Position(14.333928, 121.099659) });
            StaticPins.Add(new MapPin { Address = "Brgy Aplaya, Santa Rosa, Laguna", Barangay = "Aplaya", CustomType = PinType.School, Label = "Aplaya National Highschool", Position = new Xamarin.Forms.Maps.Position(14.317915, 121.121404) });
            StaticPins.Add(new MapPin { Address = "Brgy Aplaya, Santa Rosa, Laguna", Barangay = "Aplaya", CustomType = PinType.Church, Label = "Iglesia ni Cristo", Position = new Xamarin.Forms.Maps.Position(14.322114, 121.118207) });
            StaticPins.Add(new MapPin { Address = "Brgy Aplaya, Santa Rosa, Laguna", Barangay = "Aplaya", CustomType = PinType.Church, Label = "United Church of Christ in the Philippines", Position = new Xamarin.Forms.Maps.Position(14.316771, 121.120803) });
            StaticPins.Add(new MapPin { Address = "brgy caingin, santa rosa, laguna", Barangay = "Caingin", CustomType = PinType.School, Label = "The maritime training center of the philippines", Position = new Xamarin.Forms.Maps.Position(14.302648, 121.126967) });
            StaticPins.Add(new MapPin { Address = "brgy caingin, santa rosa, laguna", Barangay = "Caingin", CustomType = PinType.School, Label = "Caingin Elementary School", Position = new Xamarin.Forms.Maps.Position(14.304447, 121.125550) });
            StaticPins.Add(new MapPin { Address = "brgy caingin, santa rosa, laguna", Barangay = "Caingin", CustomType = PinType.Church, Label = "CAINGIN CHRISTIAN CHURCH", Position = new Xamarin.Forms.Maps.Position(14.306725, 121.124655) });
            StaticPins.Add(new MapPin { Address = "brgy ibaba, santa rosa, laguna", Barangay = "Ibaba", CustomType = PinType.Church, Label = "Proclaimers of salvation and lords ministry church", Position = new Xamarin.Forms.Maps.Position(14.314606, 121.120032) });
            StaticPins.Add(new MapPin { Address = "34 F. gomez Street, Kanluran, Santa Rosa, Laguna", Barangay = "Ibaba", CustomType = PinType.School, Label = "holy family learning center", Position = new Xamarin.Forms.Maps.Position(14.314032, 121.117954) });
            StaticPins.Add(new MapPin { Address = "F. Gomez Street, Santa Rosa, 4026 Laguna", Barangay = "Ibaba", CustomType = PinType.Church, Label = "iglesia filipina independiente", Position = new Xamarin.Forms.Maps.Position(14.313697, 121.118004) });
            StaticPins.Add(new MapPin { Address = "Ambrocia Subdivision, Santa Rosa, Laguna", Barangay = "Ibaba", CustomType = PinType.School, Label = "Laguna Eastern Academy", Position = new Xamarin.Forms.Maps.Position(14.313210, 121.116935) });
            StaticPins.Add(new MapPin { Address = "Rizal blvd, Corner zavalla street, brgy malusak, santa rosa, laguna 4026", Barangay = "Malusak", CustomType = PinType.Bank, Label = "Union Bank of the philippines", Position = new Xamarin.Forms.Maps.Position(14.312965, 121.112371) });
            StaticPins.Add(new MapPin { Address = "4026, Rizal blvd Santa rosa laguna", Barangay = "Malusak", CustomType = PinType.Postal, Label = "Santa Rosa City Hall", Position = new Xamarin.Forms.Maps.Position(14.314532, 121.113730) });
            StaticPins.Add(new MapPin { Address = "waling-waling street Santa rosa laguna", Barangay = "Malusak", CustomType = PinType.Store, Label = "Watsons Savemore Garden villas Santa Rosa", Position = new Xamarin.Forms.Maps.Position(14.311669, 121.116612) });
            StaticPins.Add(new MapPin { Address = "rizal blvd,Santa Rosa laguna, 4026", Barangay = "Malusak", CustomType = PinType.Postal, Label = "Santa rosa postal office", Position = new Xamarin.Forms.Maps.Position(14.313905, 121.112533) });
            StaticPins.Add(new MapPin { Address = "7103 Tatlong Hari St, Market Area, Santa Rosa, 4026 Laguna", Barangay = "Malusak", CustomType = PinType.Store, Label = "Mercury Drug", Position = new Xamarin.Forms.Maps.Position(14.313812, 121.112674) });
            StaticPins.Add(new MapPin { Address = "F. Gomez Street,kanluran, Santa Rosa, 4026 Laguna", Barangay = "Kanluran", CustomType = PinType.Church, Label = "Catholic church santa rosa de lima parish", Position = new Xamarin.Forms.Maps.Position(14.313995, 121.111229) });
            StaticPins.Add(new MapPin { Address = "Santa Rosa, 4026 Laguna", Barangay = "Kanluran", CustomType = PinType.Plaza, Label = "City plaza, Peoples park santa rosa", Position = new Xamarin.Forms.Maps.Position(14.313847, 121.112355) });
            StaticPins.Add(new MapPin { Address = "rizal blvd, kanluran, santa rosa, 4026, laguna", Barangay = "Kanluran", CustomType = PinType.Bank, Label = "maybank santa rosa", Position = new Xamarin.Forms.Maps.Position(14.313644, 121.112285) });
            StaticPins.Add(new MapPin { Address = "673 rizal blvd santa rosa laguna", Barangay = "Labas", CustomType = PinType.School, Label = "Labas elementary school", Position = new Xamarin.Forms.Maps.Position(14.306479, 121.111065) });
            StaticPins.Add(new MapPin { Address = "Olympus Cir, santa rosa laguna", Barangay = "Labas", CustomType = PinType.Church, Label = "kingdom hall of jehovah's witnesses", Position = new Xamarin.Forms.Maps.Position(14.306227, 121.111011) });
            StaticPins.Add(new MapPin { Address = "Olympus Cir, santa rosa laguna", Barangay = "Labas", CustomType = PinType.School, Label = "Colegio de santa rosa de lima", Position = new Xamarin.Forms.Maps.Position(14.307149, 121.111077) });
            StaticPins.Add(new MapPin { Address = "Captain perlas street, santa rosa village, santa rosa 4026, laguna", Barangay = "Pooc", CustomType = PinType.Church, Label = "Saint john bosco parish ", Position = new Xamarin.Forms.Maps.Position(14.299996, 121.113313) });
            StaticPins.Add(new MapPin { Address = "Metroville subd, santa rosa 4026 laguna", Barangay = "Pooc", CustomType = PinType.Church, Label = "Iglesia ni Cristo", Position = new Xamarin.Forms.Maps.Position(14.298557, 121.107851) });
            StaticPins.Add(new MapPin { Address = "Mabolo, Pooc, santa rosa 4026 laguna", Barangay = "Pooc", CustomType = PinType.Church, Label = "Catholic church sto.nino Catholic chapel", Position = new Xamarin.Forms.Maps.Position(14.301931, 121.112301) });


        }
    }
}
