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
                    RandomCharacterGenerator randomCharacterGenerator = new RandomCharacterGenerator();
                   message.Channel.SendMessageAsync("Name : " + message.Author.Mention + Environment.NewLine + 
                       "Race : " + randomCharacterGenerator.characterRace + Environment.NewLine + 
                       "Class : " + randomCharacterGenerator.characterClass + Environment.NewLine +
                       "-- Ability Scores --" + Environment.NewLine +
                       "Strength : " + randomCharacterGenerator.strengthAbil + Environment.NewLine +
                       "Dexterity : " + randomCharacterGenerator.dexterityAbil + Environment.NewLine +
                       "Constitution : " + randomCharacterGenerator.constitutionAbil + Environment.NewLine +
                       "Intelligence : " + randomCharacterGenerator.intelligenceAbil + Environment.NewLine + 
                       "Wisdom : " + randomCharacterGenerator.wisdomAbil + Environment.NewLine + 
                       "Charisma : " + randomCharacterGenerator.charismaAbil);
                }
            }
        }
    }
}
