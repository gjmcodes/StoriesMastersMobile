using Prism.Navigation;
using StoriesMasterMobileApp.Interfaces.Services.OpenChat;
using StoriesMasterMobileApp.Models.InteractionPages;
using StoriesMasterMobileApp.ViewModels.Behavior;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace StoriesMasterMobileApp.ViewModels
{
    public class OpenChatPageViewModel : BaseTabbedPageViewModel
    {

        private readonly IChatMessagesAppService _chatMessagesAppService;
        string currentRoomId = "abc";

        public OpenChatPageViewModel(
            INavigationService navigationService,
            IChatMessagesAppService chatMessagesAppService) : base(navigationService)
        {
            _chatMessagesAppService = chatMessagesAppService;
            Messages = new ObservableCollection<OpenChatMessage>();
        }

        public ObservableCollection<OpenChatMessage> Messages { get; private set; }


        protected override async Task LoadDataAsync()
        {
            var data = await _chatMessagesAppService.GetLast10RoomMessagesAsync(currentRoomId);

            foreach (var item in data)
            {
                Messages.Add(item);
            }
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
        }

        public override void OnNavigatedFrom(NavigationParameters parameters)
        {
            base.OnNavigatedFrom(parameters);
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
        }

    }
}
