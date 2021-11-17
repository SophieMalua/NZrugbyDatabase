using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NZrugbyDatabase.Models
{
    // This is telling you whats in the Teams folder
    public class Team
    {
        public int TeamID { get; set; }

        public string Name { get; set; }

        public int  yearRegistered { get; set; }

        public string Location { get; set; }

        public ICollection<Player> Player { get; set; }

        public ICollection<Manager> Manager { get; set; }

    }
}
