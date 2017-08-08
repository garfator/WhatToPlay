using Discord;

using Discord.Commands;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord_Bot
{
    class Mybot
    {
        IDiscordClient discord;


        public Mybot()
        {
            discord = new IDiscordClient(x =>

           {
               x.LogLevel = LogSeverity.Info;
               x.LogHandler = Log;
           });

            discord.ExecuteAndWait(async () =>


            {



            }  };
        }

       private void Log(object sender, LogMessage e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
