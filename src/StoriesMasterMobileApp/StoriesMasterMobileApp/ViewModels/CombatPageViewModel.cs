using Prism.Navigation;
using StoriesMasterMobileApp.ViewModels.Behavior;

namespace StoriesMasterMobileApp.ViewModels
{
    public class CombatPageViewModel : BaseTabbedPageViewModel
	{
        public CombatPageViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
        }
    }
}
