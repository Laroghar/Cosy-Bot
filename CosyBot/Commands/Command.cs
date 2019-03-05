using Discord.WebSocket;
using System.Threading.Tasks;

public class Command
{
    private DiscordSocketClient socket;
    private SocketMessage message;

    public Command(DiscordSocketClient socket, SocketMessage message)
	{
        this.socket = socket;
        this.message = message;
	}

    public async Task Exec()
    {
    }
}
