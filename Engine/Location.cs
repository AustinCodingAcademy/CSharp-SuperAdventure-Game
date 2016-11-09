using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location : Item
    {
        public string Description { get; set; }

        public Location(int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
