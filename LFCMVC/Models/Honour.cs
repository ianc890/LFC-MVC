using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LFCMVC.Models
{
    public class Honour
    {
        public int HonourId { get; set; }
        public string Image { get; set; }
        public string Award { get; set; }
        public int Amount { get; set; }
        public string Season { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Manager> Managers { get; set; }
    }
}