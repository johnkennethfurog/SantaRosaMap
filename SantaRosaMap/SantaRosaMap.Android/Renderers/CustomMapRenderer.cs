using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SantaRosaMap.CustomControls;
using SantaRosaMap.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;
using Xamarin.Forms.Platform.Android;
using static Android.Gms.Maps.GoogleMap;

[assembly: ExportRenderer(typeof(SantaRosaMap.Renderers.CustomMap), typeof(SantaRosaMap.Droid.Renderers.CustomMapRenderer))]
namespace SantaRosaMap.Droid.Renderers
{
    class CustomMapRenderer : MapRenderer, IInfoWindowAdapter
    {
        List<Marker> markers;
        public CustomMapRenderer(Context context) : base(context)
        {
            markers = new List<Marker>();
        }

        public Android.Views.View GetInfoContents(Marker marker)
        {
            var inflater = Android.App.Application.Context.GetSystemService(Context.LayoutInflaterService) as Android.Views.LayoutInflater;
            if (inflater != null)
            {
                Android.Views.View view;

                view = inflater.Inflate(Resource.Layout.MapInfoWindow, null);

                var custPin = GetCustomPin(new Position(marker.Position.Latitude,marker.Position.Longitude));

                var infoTitle = view.FindViewById<TextView>(Resource.Id.InfoWindowTitle);
                var infoSubtitle = view.FindViewById<TextView>(Resource.Id.InfoWindowSubtitle);
                var infoImage = view.FindViewById<ImageView>(Resource.Id.InfoWindowImage);


                if (custPin.SmallImages != "" || custPin.SmallImages == "no_image.png")
                {
                    var imgName = custPin.SmallImages.Replace(".jpg", "");
                    var imgResource = typeof(Resource.Drawable).GetField(imgName);

                    if (imgResource != null)
                    {
                        var imgId = (int)imgResource.GetValue(null);
                        var img = BitmapFactory.DecodeResource(Context.Resources, imgId);

                        infoImage.SetImageBitmap(img);
                    }
                }
                else
                {
                    infoImage.Visibility = ViewStates.Gone;
                }

                if (infoTitle != null)
                {
                    infoTitle.Text = marker.Title;
                }
                if (infoSubtitle != null)
                {
                    infoSubtitle.Text = marker.Snippet;
                }
                
                return view;
            }
            return null;
        }

        public Android.Views.View GetInfoWindow(Marker marker)
        {
            return null;

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Map> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                var customMap = (CustomMap)e.NewElement;
                customMap.PinSelectedEvent -= CustomMap_PinSelectedEvent;
                CustomMap.MapPinChanged -= CustomMap_MapPinChanged;
                markers.Clear();
            }

            if (e.NewElement != null)
            {
                Control.GetMapAsync(this);
                var customMap = (CustomMap)e.NewElement;
                CustomMap.MapPinChanged += CustomMap_MapPinChanged;
                customMap.PinSelectedEvent += CustomMap_PinSelectedEvent;
            }
        }

        private void CustomMap_PinSelectedEvent(Pin pin)
        {
            var marker = markers.FirstOrDefault(x => x.Position.Longitude == pin.Position.Longitude && x.Position.Latitude == pin.Position.Latitude);

            Task.Delay(1500).ContinueWith(x =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    marker.ShowInfoWindow();

                });

            });
           
        }

        void LoadCustomPins(CustomMap map)
        {
            foreach (var pin in map.MapPins)
                AddPinToMap(pin as Pin);
        }

        private void CustomMap_MapPinChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                foreach (var pin in e.NewItems)
                    AddPinToMap(pin as Pin);
            }
        }

        void AddPinToMap(Pin pin)
        {
            var m = NativeMap.AddMarker(CreateMarker(pin as Pin));
            markers.Add(m);
        }

        protected override MarkerOptions CreateMarker(Pin pin)
        {
            var custPin = GetCustomPin(pin.Position);

            var markOption = new MarkerOptions();
            markOption.SetPosition(new LatLng(pin.Position.Latitude, pin.Position.Longitude));
            markOption.SetTitle(custPin.Label);
            markOption.SetSnippet(custPin.Address);
            markOption.SetIcon(BitmapDescriptorFactory.FromResource(GetPinIcon(custPin)));
            return markOption;
        }

        int GetPinIcon(MapPin pin)
        {
            switch(pin.CustomType)
            {
                case CustomControls.PinType.Church:
                    return Resource.Drawable.ic_cross;
                case CustomControls.PinType.Hospital:
                    return Resource.Drawable.ic_hospital;
                case CustomControls.PinType.Plaza:
                    return Resource.Drawable.ic_bench;
                case CustomControls.PinType.Postal:
                    return Resource.Drawable.ic_postal;
                case CustomControls.PinType.School:
                    return Resource.Drawable.ic_school;
                case CustomControls.PinType.Barangay:
                    return Resource.Drawable.ms_hall;
                case CustomControls.PinType.Store:
                    return Resource.Drawable.ms_cart;
                case CustomControls.PinType.Mall:
                    return Resource.Drawable.ms_cart;
                case CustomControls.PinType.Bank:
                    return Resource.Drawable.ms_bank;
                default:
                    return Resource.Drawable.icon;
                   
            }
        }
        
        MapPin GetCustomPin(Position position)
        {
            var customMap = Element as CustomMap;
            MapPin customPin = null;
            foreach (var mapPin in customMap.MapPins)
            {
                var _pin = mapPin as MapPin;
                if (position.Equals(_pin.Position))
                {
                    customPin = _pin;
                    break;
                }
            }
            return customPin;
        }

        protected override void OnMapReady(GoogleMap map)
        {
            base.OnMapReady(map);
            var customMap = (CustomMap)Element;
            LoadCustomPins(customMap);

            NativeMap.SetInfoWindowAdapter(this);
        }
    }
}