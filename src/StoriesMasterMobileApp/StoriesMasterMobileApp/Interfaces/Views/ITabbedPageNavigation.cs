using System.Threading.Tasks;

namespace StoriesMasterMobileApp.Interfaces.Views
{
    public interface ITabbedPageNavigation
    {
        Task NavigatedToTabbedPageAsync();
        void ExitedFromTabbedPageAsync();
    }
}
