using StoriesMasterMobileApp.Interfaces.Services.OpenChat;
using StoriesMasterMobileApp.Models.InteractionPages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StoriesMasterMobileApp.Services.OpenChat
{
    public class ChatMessagesAppService : BaseAppService, IChatMessagesAppService
    {
        public async Task<IEnumerable<OpenChatMessage>> GetLast10RoomMessagesAsync(string roomId)
        {
            var messages = new List<OpenChatMessage>()
            {
                new OpenChatMessage(){UserName="Player 1", Content=Guid.NewGuid().ToString()},
                new OpenChatMessage(){UserName="Player 2", Content=Guid.NewGuid().ToString()},
                new OpenChatMessage(){UserName="Player 1", Content=Guid.NewGuid().ToString()},
                new OpenChatMessage(){UserName="Player 2", Content=Guid.NewGuid().ToString()},
                new OpenChatMessage(){UserName="Player 1", Content=Guid.NewGuid().ToString()},
                new OpenChatMessage(){UserName="Player 2", Content=Guid.NewGuid().ToString()},
                new OpenChatMessage(){UserName="Player 1", Content=Guid.NewGuid().ToString()},
                new OpenChatMessage(){UserName="Player 2", Content=Guid.NewGuid().ToString()}
            };

            return messages;
        }

        protected override void ReleaseResources()
        {
            base.ReleaseResources();
        }
    }
}
