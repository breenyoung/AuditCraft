using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AuditTool.Classes;
using WowDotNetAPI;
//using WowDotNetAPI.Extensions;
using WowDotNetAPI.Models;

namespace AuditTool.Classes
{
    public class ArmoryDal
    {

        private WowExplorer we = null;

        public ArmoryDal(Region region)
        {
            we = new WowExplorer(region);
        }

        public ArmoryDal()
        {
            we = new WowExplorer(Region.US);
        }

        public List<WowCharacter> GetGuildMembers(string realm, string guildName, int minimumLevel)
        {
            List<WowCharacter> members = new List<WowCharacter>();
            
            Guild guild = we.GetGuild(realm, guildName, GuildOptions.GetMembers);

            foreach (GuildMember member in guild.Members.Where(g => g.Character.Level >= minimumLevel).OrderBy(g => g.Character.Name))
            {

                WowCharacter wc = GetCharacter(realm, member.Character.Name);
                members.Add(wc);
            }

            return members;
        }


        public WowCharacter GetCharacter(string realm, string characterName)
        {

            
            Character c = we.GetCharacter(realm, characterName, CharacterOptions.GetItems);
            if (c != null)
            {
                WowCharacter wc = new WowCharacter();
                wc.Name = c.Name;
                wc.Avatar = c.Thumbnail;
                wc.Class = c.Class.ToString();
                wc.Race = c.Race.ToString();
                wc.AverageILevel = c.Items.AverageItemLevel;
                wc.AverageILevelEquipped = c.Items.AverageItemLevelEquipped;
                return wc;
            }

            return null;
            
        }
    }




}
