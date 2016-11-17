using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class PlayerQuest
    {
        public Quest Details { get; set; }
        public bool IsComplete { get; set; }

        public PlayerQuest(Quest details) {


            Details = details;
            IsComplete = false;
        }
    }
}
