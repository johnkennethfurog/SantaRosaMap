using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using SantaRosaMap.CustomControls;
using SantaRosaMap.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace SantaRosaMap.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ObservableCollection<MapPin> MapPins { get; }

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            MapPins = new ObservableCollection<MapPin>(PinHelper.StaticPins);
            Title = "Santa Rosa Map";

        }


        private DelegateCommand _searchCommand;
        public DelegateCommand SearchCommand =>
            _searchCommand ?? (_searchCommand = new DelegateCommand(ExecuteSearchCommand));

        private async void ExecuteSearchCommand()
        {
            await NavigationService.NavigateAsync("SearchPage");
        }
    }
}
