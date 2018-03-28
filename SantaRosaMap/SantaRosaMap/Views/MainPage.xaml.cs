using Prism.Events;
using SantaRosaMap.CustomControls;
using SantaRosaMap.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace SantaRosaMap.Views
{
	public partial class MainPage : ContentPage
	{

		public MainPage (IEventAggregator eventAggregator)
		{
			InitializeComponent ();
            maps.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(14.313288, 121.099555), Distance.FromMiles(1)));
            eventAggregator.GetEvent<NavigateToLocationCommand>().Subscribe(LocatPin);

        }

        private void LocatPin(MapPin obj)
        {
            Task.Delay(1000).ContinueWith(x =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    maps.MoveToRegion(MapSpan.FromCenterAndRadius(obj.Position, Distance.FromMiles(.25)));
                    maps.InvokePinSelected(obj as Pin);
                    
                });

            });
        }

        protected override void OnAppearing()
        {
            base.OnAppearing(); 
        }
    }
}