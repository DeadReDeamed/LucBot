using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace GANG_bot
{
    class Secret {
        
        public string Token { get; set; }
        public string Prefix { get;  set; }
    }
    class Program
    {
        static void Main(string[] args) => new Program().MainAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        private const string PREFIX = "?";
        private CommandHandlerClass commandHandlerClass;
        public async Task MainAsync()
        {
           commandHandlerClass = new CommandHandlerClass();

            _client = new DiscordSocketClient();
            _client.MessageReceived += CommandHandler;
            _client.Log += Log;

            var secret = JsonConvert.DeserializeObject<Secret>(File.ReadAllText("config.json"));

            await _client.LoginAsync(TokenType.Bot, token);
            await _client.StartAsync();

            await Task.Delay(-1);

        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private Task CommandHandler(SocketMessage message)
        {
            string [] commands;

            if(!message.Content.StartsWith(PREFIX)){
                return Task.CompletedTask;
            }

            if(message.Author.IsBot){
                return Task.CompletedTask;
            }

            if(message.Content.Contains(" ")){
                commands = message.Content.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            } else {
                commands = new string[1];
                commands[0] = message.Content;
            }

            commands[0] = commands[0].Substring(1);

            commandHandlerClass.ExecuteCommand(message, commands);

            return Task.CompletedTask;
        }
    }
}
