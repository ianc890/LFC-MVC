using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LFCMVC.Models
{
    public class Fixture
    {
        public int FixtureId { get; set; }
        public DateTime Date { get; set; }
        public string Stadium { get; set; }
        [Display(Name = "Home Team")]
        public string HomeTeam { get; set; }
        [Display(Name = "Home Score")]
        public int HomeScore { get; set; }
        [Display(Name = "Away Score")]
        public int AwayScore { get; set; }
        [Display(Name = "Away Team")]
        public string AwayTeam { get; set; }
        public int CompetitionId { get; set; }
        public virtual Competition Competition { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}