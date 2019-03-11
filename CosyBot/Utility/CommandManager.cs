using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Reflection;
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
            this.commandList.Add("!Test", "TestCommand");
        }

        public async Task ExecCommand(SocketMessage message)
        {
            if (commandList.ContainsKey(message.Content)) {
                Type commandType = Type.GetType(commandList[message.Content], true);
                object[] parameters = { socket, message };
                Command command = (Command) Activator.CreateInstance(commandType, parameters);
                await command.Exec();
            }
        }



    }
}