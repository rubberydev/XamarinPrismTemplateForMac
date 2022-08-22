using System;
using Prism.Navigation;

namespace XamarinPrismTemplateForMac.ViewModels
{
    public class MainPageViewModel : ViewModelBase, INavigatedAware
    {
        private INavigationService _navigationService;

        public MainPageViewModel(
            INavigationService navigationService) : base(navigationService)
        {
            Title = "Main page";
            this._navigationService = navigationService;
        }
    }
}
