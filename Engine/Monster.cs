using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardsExperiencePoints { get; set; }
        public int RewardGold { get; set; }

        public Monster(int id, string name, int maximumDamage, int rewardsExperiencePoints, int rewardGold, int currentHitPoints, int maximumHitPoints)    
            : base (currentHitPoints, maximumHitPoints)
        {
            ID = id;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardsExperiencePoints = rewardsExperiencePoints;
            RewardGold = rewardGold;
        
        }
    }
}
