using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CosyBot.Commands
{
    class TestCommand : Command
    {
        private DiscordSocketClient socket;
        private SocketMessage message;

        public TestCommand(DiscordSocketClient socket, SocketMessage message) : base(socket, message)
        {
            this.socket = socket;
            this.message = message;
        }

        public override async Task Exec()
        {
            await this.message.Channel.SendMessageAsync("Test!");
        }
    }
}
