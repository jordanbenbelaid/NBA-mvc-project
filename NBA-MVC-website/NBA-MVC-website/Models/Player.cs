using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NBA_MVC_website.Models
{
    public partial class Player
    {
        public int PlayerId { get; set; }
        public int? TeamId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        [Range(0,100000)]
        public int PlayerPointsScored { get; set; }
        public string AllStarGames { get; set; }
        public string VideoLink { get; set; }
        public string PhotoLink { get; set; }

        public virtual Team Team { get; set; }
    }
}
