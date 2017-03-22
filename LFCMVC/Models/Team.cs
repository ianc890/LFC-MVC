using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LFCMVC.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        [Display(Name = "Team")]
        public string Name { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}