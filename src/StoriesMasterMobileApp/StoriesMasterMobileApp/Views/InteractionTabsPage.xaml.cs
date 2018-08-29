using StoriesMasterMobileApp.Interfaces.Views;
using Xamarin.Forms;

namespace StoriesMasterMobileApp.Views
{
    public partial class InteractionTabsPage : TabbedPage
    {
        public InteractionTabsPage()
        {
            InitializeComponent();
        }

        protected override async void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();

            ResetPageBindingContext();

            await (BindingContext as ITabbedPageNavigation).NavigatedToTabbedPageAsync();
        }

        void ResetPageBindingContext()
        {
            BindingContext = this.CurrentPage.BindingContext;
        }
    }
}
