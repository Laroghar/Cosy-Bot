using Discord.WebSocket;
using System;
using System.Threading.Tasks;

public class HelloCommand : Command
{
    private DiscordSocketClient socket;
    private SocketMessage message;

    public HelloCommand(DiscordSocketClient socket, SocketMessage message) : base(socket, message)
    {
        this.socket = socket;
        this.message = message;
    }

    public override async Task Exec()
    {
        await this.message.Channel.SendMessageAsync("Greetings!");
    }
}
