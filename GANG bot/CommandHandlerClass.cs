using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using GANG_bot.CharacterGeneration;

namespace GANG_bot
{
    public class CommandHandlerClass : ModuleBase<SocketCommandContext>
    {
        public CommandHandlerClass()
        {
        }

        public void ExecuteCommand(SocketMessage message, string[] commands)
        {
            if (commands[0].ToLower().Equals("ping"))
            {
                message.Channel.SendMessageAsync("pong " + message.Author.Mention);

            } else if (commands[0].ToLower().Equals("generate")){
                if (commands[1].ToLower().Equals("character"))
                {
                    if (commands.Length < 3)
                    {
                        RandomCharacterGenerator randomCharacterGenerator = new RandomCharacterGenerator();

                        message.Channel.SendMessageAsync("Name : " + message.Author.Mention + Environment.NewLine +
                            "Race : " + randomCharacterGenerator.characterRace + Environment.NewLine +
                            "Class : " + randomCharacterGenerator.characterClass + Environment.NewLine +
                            "-- Ability Scores --" + Environment.NewLine +
                            randomCharacterGenerator.characterRace.Stats.ToString());
                    } else if (RandomCharacterGenerator.doesRaceExist(commands[2]) || RandomCharacterGenerator.doesClassExist(commands[2])){
                        if (commands.Length == 3) 
                        {
                            RandomCharacterGenerator generator = new RandomCharacterGenerator(commands[2]);

                            message.Channel.SendMessageAsync("Name : " + message.Author.Mention + Environment.NewLine +
                            "Race : " + generator.characterRace + Environment.NewLine +
                            "Class : " + generator.characterClass + Environment.NewLine +
                            "-- Ability Scores --" + Environment.NewLine +
                            generator.characterRace.Stats.ToString());
                        } else if(commands.Length == 4 && RandomCharacterGenerator.doesRaceExist(commands[2]) && RandomCharacterGenerator.doesClassExist(commands[3]))
                        {
                            RandomCharacterGenerator generator = new RandomCharacterGenerator(commands[2], commands[3]);
                            message.Channel.SendMessageAsync("Name : " + message.Author.Mention + Environment.NewLine +
                            "Race : " + generator.characterRace + Environment.NewLine +
                            "Class : " + generator.characterClass + Environment.NewLine +
                            "-- Ability Scores --" + Environment.NewLine +
                            generator.characterRace.Stats.ToString());
                        }
                    }
                } 
            }
        }
    }
}
