using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StoriesMasterMobileApp.ViewModels
{
    public class AppMasterDetailPageViewModel : ViewModelBase
    {
        public AppMasterDetailPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            NavigationCommand = new DelegateCommand<string>(Navigate);
        }


        public DelegateCommand<string> NavigationCommand { get; }

        async void Navigate(string param)
        {
            await NavigationService.NavigateAsync(param);
        }
    }
}
