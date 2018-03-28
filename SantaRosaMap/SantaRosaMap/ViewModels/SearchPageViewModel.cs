using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using SantaRosaMap.CustomControls;
using SantaRosaMap.Events;
using SantaRosaMap.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace SantaRosaMap.ViewModels
{
	public class SearchPageViewModel : ViewModelBase
	{
        private IEventAggregator EventAggregator;

        private string _searchText;

        public string SearchText
        {
            get { return _searchText; }
            set { SetProperty(ref _searchText , value); }
        }

        private DelegateCommand _searchCommand;
        public DelegateCommand SearchCommand =>
            _searchCommand ?? (_searchCommand = new DelegateCommand(ExecuteSearchCommand));

        private void ExecuteSearchCommand()
        {
            SearchList.Clear();

            var _searchResult = SearchText.Trim()==""? PinHelper.StaticPins : PinHelper.StaticPins.Where(x => x.Label.ToLower().Contains(SearchText.ToLower()) ||
            x.Address.ToLower().Contains(SearchText.ToLower()));

            foreach (var res in _searchResult)
                SearchList.Add(res);
        }

        private DelegateCommand<MapPin> _tappedCommand;
        public DelegateCommand<MapPin> TappedCommand =>
            _tappedCommand ?? (_tappedCommand = new DelegateCommand<MapPin>(ExecuteTappedCommand));

        private async void ExecuteTappedCommand(MapPin pin)
        {
            EventAggregator.GetEvent<NavigateToLocationCommand>().Publish(pin);
            await NavigationService.GoBackAsync();
        }

        public ObservableCollection<MapPin> SearchList { get;}

        public SearchPageViewModel(INavigationService navigationService,
            IEventAggregator eventAggregator) : base(navigationService)
        {
            SearchList = new ObservableCollection<MapPin>(PinHelper.StaticPins);
            EventAggregator = eventAggregator;
            Title = "Search";
        }

        public override void Destroy()
        {
            SearchList.Clear();
            base.Destroy();
        }
    }
}
