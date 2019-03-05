using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CosyBot
{
    public class CommandManager
    {
        private Dictionary<string, string> commandList;
        private DiscordSocketClient socket;

        public CommandManager(DiscordSocketClient socket)
        {
            this.socket = socket;
            this.BuildDictionary();
        }

        private void BuildDictionary()
        {
            this.commandList = new Dictionary<string, string>();
            this.commandList.Add("!Bonjour", "HelloCommand");
            this.commandList.Add("!Aurevoir", "GoodbyeCommand");
        }

        public async Task ExecCommand(SocketMessage message)
        {
            if(commandList.ContainsKey(message.Content)) {
                Type commandType = Type.GetType(message.Content, true);
                List<object> parameters = new List<object>();
                parameters.Add(socket);
                parameters.Add(message);
                Command command = (Command) Activator.CreateInstance(commandType, parameters);
                await command.Exec();
            }
        }



    }
}