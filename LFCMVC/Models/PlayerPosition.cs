using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LFCMVC.Models
{
    public class PlayerPosition
    {
        public int PlayerPositionId { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}