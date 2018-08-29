using StoriesMasterMobileApp.Models.InteractionPages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoriesMasterMobileApp.Interfaces.Services.OpenChat
{
    public interface IChatMessagesAppService : IBaseAppService
    {
        Task<IEnumerable<OpenChatMessage>> GetLast10RoomMessagesAsync(string roomId);
    }
}
