using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AuditTool.Tasks;
using WowDotNetAPI;
using WowDotNetAPI.Models;

namespace AuditTool.Classes
{
    public class WowdotnetDal
    {
        private WowExplorer we = null;

        public WowdotnetDal(Region region)
        {
            we = new WowExplorer(region);
        }

        public WowdotnetDal()
        {            
            we = new WowExplorer(Region.US);
        }

        public ArmoryGuildResult GetGuildMembers(string realm, string guildName, int minimumLevel)
        {
            ArmoryGuildResult result = new ArmoryGuildResult();
            result.RealmName = realm;
            result.GuildName = guildName;
            
            Guild guild = we.GetGuild(realm, guildName, GuildOptions.GetMembers);

            if (guild != null)
            {

                result.GuildMembers =
                    guild.Members.Where(g => g.Character.Level >= minimumLevel).OrderBy(g => g.Character.Name);

                return result;
            }

            return null;
        }

        public ArmoryCharacterResult GetCharacter(string realm, string characterName)
        {
            ArmoryCharacterResult result = new ArmoryCharacterResult();

            result.RealmName = realm;
            result.CharacterName = characterName;            

            Character c = we.GetCharacter(realm, characterName, CharacterOptions.GetItems);

            if (c != null && c.Level > 0)
            {
                result.Level = c.Level;
                result.Class = c.Class.ToString();
                result.Thumbnail = c.Thumbnail;
                result.AverageILevel = c.Items.AverageItemLevel;
                result.AverageEquippedILevel = c.Items.AverageItemLevelEquipped;
                result.CharacterData = c;

                return result;
            }

            return null;


        }
    }
}
