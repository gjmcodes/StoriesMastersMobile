using Prism;
using Prism.Ioc;
using StoriesMasterMobileApp.ViewModels;
using StoriesMasterMobileApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism.Autofac;
using CrossCutting.IoC;
using StoriesMasterMobileApp.Interfaces.Services.OpenChat;
using StoriesMasterMobileApp.Services.OpenChat;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace StoriesMasterMobileApp
{
    public partial class App : PrismApplication
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("AppMasterDetailPage/NavigationPage/InteractionTabsPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Xamarin.Forms.NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<OpenChatPage>();
            containerRegistry.RegisterForNavigation<CombatPage>();
            containerRegistry.RegisterForNavigation<InteractionTabsPage>();
            containerRegistry.RegisterForNavigation<AppMasterDetailPage>();
            containerRegistry.RegisterForNavigation<GameNavigationPage>();

            RegisterAppServices(containerRegistry);

            containerRegistry.BootstrapDependencies();
        }

        void RegisterAppServices(IContainerRegistry container)
        {
            container.Register<IChatMessagesAppService, ChatMessagesAppService>();
        }
    }
}
