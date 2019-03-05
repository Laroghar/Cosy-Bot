using Discord.WebSocket;
using System.Threading.Tasks;

public class GoodbyeCommand : Command
{
    private DiscordSocketClient socket;
    private SocketMessage message;

    public GoodbyeCommand(DiscordSocketClient socket, SocketMessage message) : base(socket, message)
	{
        this.socket = socket;
        this.message = message;
    }

    public new async Task Exec()
    {
        await this.message.Channel.SendMessageAsync("Greetings!");
    }
}
