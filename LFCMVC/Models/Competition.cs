using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LFCMVC.Models
{
    public class Competition
    {
        public int CompetitionId { get; set; }
        public string Image { get; set; }
        [Display(Name = "Competition")]
        public string Name { get; set; }
        public virtual ICollection<Fixture> Fixtures { get; set; }
    }
}