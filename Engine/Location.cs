using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class location
    {
        public int ID {get; set;}
        public string Name { get; set; }
        public string Description { get; set; }

        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }
        public location LocationToNorth { get; set; }
        public location LocationToEast { get; set; }
        public location LocationToSouth { get; set; }
        public location LocationToWest { get; set; }

        public location(int id, string name, string description,
            Item itemRequiredToEnter = null,
            Quest questAvailableHere = null,
            Monster monsterLivingHere = null,
            )
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = itemRequiredToEnter;
            QuestAvailableHere = questAvailableHere;
            MonsterLivingHere = monsterLivingHere;

        }

    }
}
