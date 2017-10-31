using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot
{//Why does nothing work? No NuGetpackage?
    class Program
    {
        private CommandService commands;
        private DiscordSocketClient client;
        private IServiceProvider services;

        string token = "";

        static void Main(string[] args) => new Program().Start().GetAwaiter().GetResult();

        public async Task Start()

        {
            client = new DiscordSocketClient();

            commands = new CommandService();

            services = new ServiceCollection().BuildServiceProvider();

            await InstallCommands();

            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            client.Log += Log;

            await Task.Delay(-1);

              
        }

        public async Task InstallCommands()
        {
            client.MessageReceived += HandleCommand;

            await commands.AddModuleAsync(Assembly.GetEntryAssembly());
        }
        
        //{
        //    Mybot bot = new Mybot();

        //}
    }
}
// https://discordapp.com/oauth2/authorize?client_id=336918100127645706&scope=bot&permissions=0

//336918100127645706 https://www.youtube.com/watch?v=hE6ZFkSWbNc&t=50s
