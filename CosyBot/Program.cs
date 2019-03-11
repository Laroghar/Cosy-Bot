using System;
using System.Threading.Tasks;
using System.Timers;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace CosyBot
{
    public class Program
    {
        private static System.Timers.Timer timer;
        DiscordSocketClient discord;
        private CommandManager manager;

        public static void Main(string[] args)
        {
            timer = new Timer( 60 * 1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;

            new Program().MainAsync().GetAwaiter().GetResult();

        }

        public async Task MainAsync()
        {
            discord = new DiscordSocketClient();
            discord.Log += Log;
            await LoginDiscord("NTM2NTQwMzczMjAwMTQyMzQ2.D2OdMw.OyMToxArLzH2ltTXzg1Mcv7gfUE", discord);
            discord.MessageReceived += MessageReceived;
            await Task.Delay(-1);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private Task LoginDiscord(String token, DiscordSocketClient client)
        {
            client.LoginAsync(TokenType.Bot, token);
            client.StartAsync();
            this.manager = new CommandManager(discord);
            return Task.CompletedTask;
        }

        private async Task MessageReceived(SocketMessage message)
        {
            await manager.ExecCommand(message);
        }
        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("still active",
                              e.SignalTime);
        }


    }
}

