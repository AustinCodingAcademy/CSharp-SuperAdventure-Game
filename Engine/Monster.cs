using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int MaximumHiPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set}
        public int RewardGold { get; set; }
    }
}
