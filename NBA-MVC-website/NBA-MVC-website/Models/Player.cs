using System;
using System.Collections.Generic;

namespace NBA_MVC_website.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public int? TeamId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string PlayerPointsScored { get; set; }
        public string AllStarGames { get; set; }
        public string VideoLink { get; set; }
        public string PhotoLink { get; set; }

        public virtual Team Team { get; set; }
    }
}
