using System;
using System.Collections.Generic;

namespace NBA_MVC_website.Models
{
    public partial class Team
    {
        public Team()
        {
            Player = new HashSet<Player>();
        }

        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamChampionships { get; set; }
        public string TeamFinaslAppearances { get; set; }
        public string TeamConference { get; set; }

        public virtual ICollection<Player> Player { get; set; }
    }
}
