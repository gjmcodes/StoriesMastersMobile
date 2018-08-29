using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using StoriesMasterMobileApp.ViewModels.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StoriesMasterMobileApp.ViewModels
{
    public class GameNavigationPageViewModel : BaseTabbedPageViewModel
    {
        public GameNavigationPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
        }
    }
}
