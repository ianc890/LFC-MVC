using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LFCMVC.Models
{
    public class Player
    {
        private ICollection<Fixture> _fixtures;

        public Player()
        {
            _fixtures = new List<Fixture>();
        }
        public int PlayerId { get; set; }
        public string Image { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public int PlayerPositionId { get; set; }
        [ForeignKey("PlayerPositionId")] 
        public virtual PlayerPosition PlayerPosition { get; set; }
        [Display(Name = "Squad Number")]
        public int SquadNumber { get; set; }
        public int TeamId { get; set; }
        [ForeignKey("TeamId")] 
        public virtual Team Team { get; set; }
        public virtual ICollection<Fixture> Fixtures
        {
            get { return _fixtures; }
            set { _fixtures = value; }
        }
    }
}