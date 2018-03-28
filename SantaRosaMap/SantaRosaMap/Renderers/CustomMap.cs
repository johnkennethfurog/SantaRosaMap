using SantaRosaMap.CustomControls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace SantaRosaMap.Renderers
{
    public class CustomMap : Map
    {
        public delegate void MapPinDelegate(System.Collections.Specialized.NotifyCollectionChangedEventArgs e);
        public static event MapPinDelegate MapPinChanged;

        public delegate void PinSelected(Pin pin);
        public event PinSelected PinSelectedEvent;

        public static readonly BindableProperty MapPinsProperty =
            BindableProperty.Create(nameof(MapPins), returnType: typeof(IList), declaringType: typeof(CustomMap), propertyChanged: CollectionChanged);

        private static void CollectionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (oldValue != null)
            {
                var oldCollection = oldValue as ObservableCollection<MapPin>;
                oldCollection.CollectionChanged += NewCollection_CollectionChanged;

            }

            if (newValue == null)
                return;

            var newCollection = newValue as ObservableCollection<MapPin>;

            if (newCollection != null)
                newCollection.CollectionChanged += NewCollection_CollectionChanged;
        }

        private static void NewCollection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            MapPinChanged?.Invoke(e);
        }

        public IList MapPins
        {
            get { return (IList)GetValue(MapPinsProperty); }
            set { SetValue(MapPinsProperty, value); }
        }

        public void InvokePinSelected(Pin pin)
        {
            PinSelectedEvent?.Invoke(pin);
        }

    }
}
