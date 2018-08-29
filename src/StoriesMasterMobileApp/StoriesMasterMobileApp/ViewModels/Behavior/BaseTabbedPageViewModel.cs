using Prism.Navigation;
using StoriesMasterMobileApp.Interfaces.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoriesMasterMobileApp.ViewModels.Behavior
{
    public abstract class BaseTabbedPageViewModel : ViewModelBase, ITabbedPageNavigation
    {
        public BaseTabbedPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        protected virtual async Task LoadDataAsync()
        {
            await Task.Delay(0);
        }

        public async Task NavigatedToTabbedPageAsync()
        {
            await LoadDataAsync();
        }

        public async void ExitedFromTabbedPageAsync()
        {
            var teste = string.Empty;
        }
    }
}
